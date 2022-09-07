using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yazlab2Proje3.data.Abstract;
using Yazlab2Proje3.entity;

namespace Yazlab2Proje3.data.Concrete.MySQL
{
    public class MySQLRegisterRepository:MySQLGenericRepository<Register,LoginContext>,IRegisterRepository
    {
    
    }
}