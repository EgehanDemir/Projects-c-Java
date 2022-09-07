using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using GeoCoordinatePortable;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace yazlab11.GUI_2
{
    public partial class TeslimatRota : Form
    {
        string baslangicadres = "";
        double baslangicEnlem = 0.0;
        double baslangicBoylam = 0.0;
        GMap.NET.WindowsForms.GMapOverlay markers;
        GMapOverlay polygons = new GMapOverlay("polygons");
        List<Pozisyonlar> teslimNoktaları;
        bool stopThread;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Gaqe1QYxpDcnECrttN7PI38Ue4OwA6huKGBgxJag",
            BasePath = "https://yazlab11-c3dd7-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public TeslimatRota(string baslangicadres, double baslangicEnlem,double baslangicBoylam)
        {
            this.baslangicadres = baslangicadres;
            this.baslangicEnlem = baslangicEnlem;
            this.baslangicBoylam = baslangicBoylam;
            InitializeComponent();
        }

        public double getBirdDistance(double TN_enlem, double TN_boylam)
        {
            GeoCoordinate baslangicNoktasi = new GeoCoordinate(baslangicEnlem,baslangicBoylam);

            GeoCoordinate teslimatNoktası = new GeoCoordinate(TN_enlem,TN_boylam);

            return baslangicNoktasi.GetDistanceTo(teslimatNoktası) /1000;
        }

        public async void getPositions()
        {
            while (true) {
                if (stopThread != true)
                {
                    teslimNoktaları = new List<Pozisyonlar>();
                    IFirebaseConfig config = new FirebaseConfig
                    {
                        AuthSecret = "Gaqe1QYxpDcnECrttN7PI38Ue4OwA6huKGBgxJag",
                        BasePath = "https://yazlab11-c3dd7-default-rtdb.firebaseio.com/"
                    };
                    IFirebaseClient client = new FirebaseClient(config);
                    FirebaseResponse response = await client.GetTaskAsync("Kargolar");
                    List<Data2> convertedData = response.ResultAs<List<Data2>>();

                    var last = convertedData.Last();
                    foreach (var item in convertedData)
                    {
                        if (item != null && item.KargoDurum.Equals("Teslim Edilmedi"))
                        {
                            Pozisyonlar temp = new Pozisyonlar();
                            temp.KargoID = item.KargoID;
                            temp.KargoAdi = item.KargoAdi;
                            temp.KargoTuru = item.KargoTuru;
                            temp.KargoDurum = item.KargoDurum;
                            temp.KargoAdres = item.KargoAdres;
                            temp.KargoEnlem = Double.Parse(item.KargoEnlem);
                            temp.KargoBoylam = Double.Parse(item.KargoBoylam);
                            temp.BirdDistance = getBirdDistance(TN_enlem: temp.KargoEnlem, TN_boylam: temp.KargoBoylam);
                            teslimNoktaları.Add(temp);
                        }

                        if (item == last)
                        {
                            addMarkers();
                            kisayolbul FSW = new kisayolbul();

                            List<Pozisyonlar> tempNoktalar = new List<Pozisyonlar>();
                            Pozisyonlar tempNokta = new Pozisyonlar();
                            tempNokta.KargoEnlem = baslangicEnlem;
                            tempNokta.KargoBoylam = baslangicBoylam;
                            tempNoktalar.Add(tempNokta);
                            for(int i = 0; i < teslimNoktaları.Count; i++)
                            {
                                tempNoktalar.Add(teslimNoktaları[i]);
                            }

                            this.BeginInvoke(new MethodInvoker(delegate{

                                string bulananRota_Str = FSW.Find(teslimNoktaları: tempNoktalar).ToString();

                                string[] bulananRota_Array = bulananRota_Str.ToString().Split(' ');
                                int[] bulunanRota = new int[bulananRota_Array.Length];
                                for (int i = 0; i < bulananRota_Array.Length; i++)
                                {
                                    bulunanRota[i] = Convert.ToInt32(bulananRota_Array[i].ToString());
                                }

                                string sonuc = "";
                                for(var x=0;x< bulunanRota.Length;x++)
                                {
                                    if(bulunanRota[x] == 0)
                                    {
                                        sonuc += "Başlangıç-";
                                    }
                                    else
                                    {
                                        if (x != bulunanRota.Length - 1)
                                        {
                                            sonuc += tempNoktalar[bulunanRota[x]].KargoAdi + "-";
                                        }
                                        else
                                        {
                                            sonuc += tempNoktalar[bulunanRota[x]].KargoAdi;
                                        }
                                    }
                                }

                                polygons.Clear();
                                for (var x = 0; x < bulunanRota.Length-1; x++)
                                {
                                    PointLatLng firstPoint = new PointLatLng(tempNoktalar[bulunanRota[x]].KargoEnlem, tempNoktalar[bulunanRota[x]].KargoBoylam);
                                    PointLatLng secondPoint = new PointLatLng(tempNoktalar[bulunanRota[x +1]].KargoEnlem, tempNoktalar[bulunanRota[x +1]].KargoBoylam);
                                    drawRoute(firstPoint:firstPoint,secondPoint:secondPoint,Color.Red); 
                                }
                                label1.Text = sonuc;
                            }));
                            Thread.Sleep(5000);
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void addMarkers()
        {
            if(stopThread != true) { 
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    markers.Clear();

                    GMapMarker startPointMarker =
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        new GMap.NET.PointLatLng(baslangicEnlem, baslangicBoylam),
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);
                    startPointMarker.ToolTipText = "\nBaşlangıç Konumu\n\n" + "Adres:" + baslangicadres + "\nEnlem:" + baslangicEnlem.ToString() + "\nBoylam:" + baslangicBoylam.ToString();
                    markers.Markers.Add(startPointMarker);
                    mapView.Overlays.Add(markers);

                    foreach (var item in teslimNoktaları)
                    {
                        GMap.NET.WindowsForms.GMapMarker marker =
                            new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                                new GMap.NET.PointLatLng(item.KargoEnlem, item.KargoBoylam),
                                GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red);
                        marker.ToolTipText = "\nTeslimat Noktası\n\n" + "Kargo ID:" + item.KargoID + "\nKargo Adı:" + item.KargoAdi + "\nKargo Türü:" + item.KargoTuru + "\nKargo Durumu:" + item.KargoDurum + "\nKargo Adresi:" + item.KargoAdres + "\nEnlem:" + baslangicEnlem.ToString() + "\nBoylam:" + baslangicBoylam.ToString() + "\nB.N'ye olan Uzaklık:" + item.BirdDistance + " KM";
                        markers.Markers.Add(marker);
                        mapView.Overlays.Add(markers);
                        //
                    }
                }));
            }


            //drawRoute(firstPoint: new PointLatLng(baslangicEnlem, baslangicBoylam), secondPoint: new PointLatLng(teslimNoktaları[0].KargoEnlem, teslimNoktaları[0].KargoBoylam),lineColor: Color.Red);
        }

        public void drawRoute(PointLatLng firstPoint, PointLatLng secondPoint, Color lineColor)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(firstPoint);
            points.Add(secondPoint);
            GMapPolygon polygon = new GMapPolygon(points, "polygon");
            polygon.Stroke = new Pen(lineColor, 3);
            polygons.Polygons.Add(polygon);
            mapView.Overlays.Add(polygons);
        }

            private void TeslimatRota_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            
            mapView.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;                   

            mapView.ShowCenter = true;
            mapView.MinZoom = 0;                                                                            
            mapView.MaxZoom = 20;
            mapView.Zoom = 1;
            mapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;                
            mapView.CanDragMap = true;                                                                            
            mapView.DragButton = MouseButtons.Left;                                                          
            mapView.IgnoreMarkerOnMouseWheel = true;

            markers = new GMapOverlay("markers");

            Thread thread = new Thread(new ThreadStart(getPositions));
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mapView.ZoomAndCenterMarkers("markers");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopThread = true;
            DialogResult dialogResult = MessageBox.Show("Başlangıç konumu seçmeniz gerekmektedir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                TeslimatAdres baslangicKonumu = new TeslimatAdres();
                baslangicKonumu.Show();
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
