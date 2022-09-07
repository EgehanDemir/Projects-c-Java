using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yazlab2Proje1.data.Abstract
{
    public interface IRepository<T>
    {
        void Create(T entity);
        List <T> GetAll();
        void Enter(T entity);
    }
} 