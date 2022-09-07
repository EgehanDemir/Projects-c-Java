using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using GMap;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using yazlab11.GUI_2;

namespace yazlab11
{
    public partial class TeslimatAdres : Form
    {
        TeslimatDurum teslimatDurum;
        TeslimatRota teslimatRota;
        GMapOverlay markersOverlay;
        public TeslimatAdres(TeslimatDurum teslimatDurum= null)
        {
            if (teslimatDurum != null)
            {
                this.teslimatDurum = teslimatDurum;
            }
            InitializeComponent();
        }

        private void TeslimatDurum_Load(object sender, EventArgs e)
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

        }

        private void Btn_AdresBul_Click(object sender, EventArgs e)
        {
            markersOverlay = new GMapOverlay("markers");
            mapView.SetPositionByKeywords((address_textbox.Text).ToLower().ToString());
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(mapView.Position.Lat, mapView.Position.Lng), GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            mapView.Overlays.Add(markersOverlay);
            mapView.ZoomAndCenterMarkers("markers");
            enlem_textbox.Text = mapView.Position.Lat.ToString();
            boylam_textbox.Text = mapView.Position.Lng.ToString();
        }

        private void hkn_btn_Click(object sender, EventArgs e)
        {
            enlem_textbox.Text = mapView.Position.Lat.ToString();
            boylam_textbox.Text = mapView.Position.Lng.ToString();
        }

        private async void adresEkle_btn_Click(object sender, EventArgs e)
        {
            if (teslimatDurum != null)
            {
                this.teslimatDurum.AdresGuncelle(adres: address_textbox.Text.ToString(), enlem: enlem_textbox.Text.ToString(), boylam: boylam_textbox.Text.ToString());
            }else
            {
                teslimatRota = new TeslimatRota(baslangicadres: address_textbox.Text.ToString(),baslangicEnlem: Double.Parse(enlem_textbox.Text.ToString()), baslangicBoylam: Double.Parse(boylam_textbox.Text.ToString())) ;
                teslimatRota.Show();
            }
            this.Close();
        }

        private void sıfırla_btn_Click(object sender, EventArgs e)
        {
            address_textbox.Text = "";
            enlem_textbox.Text = "";
            boylam_textbox.Text = "";
            markersOverlay.Clear();
        }
    }
}
