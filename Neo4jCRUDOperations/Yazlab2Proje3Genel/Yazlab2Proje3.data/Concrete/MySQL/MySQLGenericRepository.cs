using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Yazlab2Proje3.data.Abstract;
using Yazlab2Proje3.entity;

namespace Yazlab2Proje3.data.Concrete.MySQL
{
    public class MySQLGenericRepository<TEntity,TContext> : IRepository<TEntity>
    where TEntity:class
    where TContext:DbContext,new()
    {
        public void Create(TEntity entity)
        {
            using(var context = new TContext()){
                context.Set<TEntity>().ToList();
            }
        }

        public void Enter(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}