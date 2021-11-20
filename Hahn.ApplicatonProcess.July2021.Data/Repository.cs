using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Hahn.ApplicatonProcess.July2021.Data
{
    public class Repository<EntityType> where EntityType : class
    {
        private DataBaseContext DBContext;
        private DbSet<EntityType> DBSet;
        public Repository(DataBaseContext DbContext)
        {
            DBContext = DbContext;
            DBSet = DbContext.Set<EntityType>();
        }
        public virtual IEnumerable<EntityType> Select(Expression<Func<EntityType, bool>> Where = null, Func<IQueryable<EntityType>, IOrderedQueryable<EntityType>> OrderBy = null, string Includes = null)
        {
            IQueryable<EntityType> query = DBSet;

            if (Where != null)
            {
                query = query.Where(Where);
            }

            if (OrderBy != null)
            {
                query = OrderBy(query);
            }

            if (Includes != null)
            {
                foreach (string include in Includes.Split(','))
                {
                    query = query.Include(include);
                }
            }

            return query.ToList();
        }
        public virtual EntityType SelectById(object Id)
        {
            return DBSet.Find(Id);
        }
        public virtual void Insert(EntityType Entity)
        {
            DBSet.Add(Entity);
        }
        public virtual void Update(EntityType Entity)
        {
            DBSet.Attach(Entity);
            DBContext.Entry(Entity).State = EntityState.Modified;
        }
        public virtual void Delete(object Id)
        {
            object Entity = SelectById(Id);
            Delete(Entity);
        }
        public virtual void Save()
        {
            DBContext.SaveChanges();
        }
    }
}