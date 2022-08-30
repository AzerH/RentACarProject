using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EfEntityRepository
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new() 
        where TContext : DbContext, new() 
    {
        public void Add(TEntity entity)
        {
            using (TContext contex = new TContext())
            {
                var  ForAdd = contex.Entry(entity);
                 ForAdd.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var  ForDelete = context.Entry(entity);
                 ForDelete.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();


            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var  ForUpdate = context.Entry(entity);
                 ForUpdate.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
