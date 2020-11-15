using Library.DataAccess.Abstract;
using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.EntitiyFramework
{
    public class EfRepositoryBase<Tentity, TContext>
        : IEntitiyRepository<Tentity>
        where Tentity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(Tentity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<Tentity>().SingleOrDefault(filter);
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<Tentity>().ToList() :
                    context.Set<Tentity>().Where(filter).ToList();
            }
        }

        public void Update(Tentity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
