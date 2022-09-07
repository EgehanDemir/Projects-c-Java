using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yazlab2Proje3.entity
{
    public class LoginRegister
    {
        public int LoginId { get; set; }
        public Login Login { get; set; }
        public int RegisterId { get; set; }
        public Register Register { get; set; }
    }
}