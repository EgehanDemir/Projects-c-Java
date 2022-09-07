using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yazlab2Proje1.data.Abstract;
using Yazlab2Proje1.entity;

namespace Yazlab2Proje1.data.Concrete.MySQL
{
    public class MySQLRegisterRepository:MySQLGenericRepository<Register,LoginContext>,IRegisterRepository
    {
    
    }
}