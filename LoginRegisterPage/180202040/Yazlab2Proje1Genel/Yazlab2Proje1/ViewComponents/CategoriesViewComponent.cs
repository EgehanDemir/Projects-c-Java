using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yazlab2Proje1.entity;
using Yazlab2Proje1.data;

namespace Yazlab2Proje1.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // var logins = new List<Login>()
            // {
            //     new Login {},
            //     new Login {},
            //     new Login {}
            // };
            return View();  
        }
    }   
}