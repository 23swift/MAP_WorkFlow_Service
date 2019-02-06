
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DA
{
    public class Repository<TEntity, TPk> : IRepository<TEntity, TPk> where TEntity : class
    {
        protected MAS_DB Context;
        protected DbSet<TEntity> DbSet { get; set; }

        public Repository(MAS_DB context)
        {
            Context = context;

            DbSet = Context.Set<TEntity>();
            DbSet.AsNoTracking();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] children)
        {
            //children.ToList().ForEach(x => DbSet.Include(x).Load());
            children.ToList().ForEach(x =>
            {
                DbSet.Include(x).Load();
                //Context.Set<TEntity>().Include(x).AsNoTracking().Load();
            });

            return DbSet.Where(filter);
        }

        public TEntity Get(TPk id, params Expression<Func<TEntity, object>>[] children)
        {
            if (children.Count() > 0)
            {
                children.ToList().ForEach(x =>
                {
                    DbSet.Include(x).Load();
                    //Context.Set<TEntity>().Include(x).AsNoTracking().Load();
                });
            }

            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] children)
        {

            children.ToList().ForEach(x => DbSet.Include(x).Load());
            return DbSet.ToList();
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Delete(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);

        }
        //public void SaveChanges() {
        //    Context.SaveChanges();
        //}

        public void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        //public void AddOrUpdate(TEntity entity)
        //{

        //    Context.Set<TEntity>().ad
        //}

    }
}