using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace StudentsSystem.Data.Repositories
{
    
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public GenericRepository(StudentsSystemDbContext context)
        {
            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }

        protected StudentsSystemDbContext Context { get; set; }

        protected IDbSet<T> DbSet { get; set; } 

        public IQueryable<T> All()
        {
            return this.DbSet.AsQueryable();
        }

        public T GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public T Add(T entity)
        {
            this.ChangeState(entity, EntityState.Added);
            return entity;
        }

        protected void ChangeState(T entity, EntityState state)
        {
            var entry = this.AttachIfDetached(entity);
            entry.State = state;
        }
        private DbEntityEntry AttachIfDetached(T entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            return entry;
        }
    }
}
