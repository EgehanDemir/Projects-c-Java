using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yazlab2Proje1.entity
{
    public class Register
    {
        public int RegisterId { get; set; }        
        public string username { get; set; }
        public string password { get; set; }
        public string passwordRepeat { get; set; }
        public string Email { get; set; }
        public List<LoginRegister> LoginRegisters { get; set; }
    }
}