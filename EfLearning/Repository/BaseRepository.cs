using DataModel.Context;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public partial class BaseRepository : IDisposable
    {

        #region Properties
        public EfLearningContext Context { get; set; }
        #endregion


        #region Contructor

        [InjectionConstructor]
        public BaseRepository()
        {
            Context = new EfLearningContext();
        }

        public BaseRepository(EfLearningContext context)
        {
            Context = context;
        }

        #endregion
        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual T GetById<T>(object Id) where T : class
        {
            return Context.Set<T>().Find(Id);
        }

        public virtual IQueryable<T> All<T>() where T : class
        {
            return Context.Set<T>().AsQueryable();
        }

        public virtual IQueryable<T> GetManyWhere<T>(Expression<Func<T,bool>> expression) where T : class
        {
            return Context.Set<T>().Where(expression);
        }
        public virtual T GetSingleWhere<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return Context.Set<T>().Where(expression).SingleOrDefault();
        }

        public void Add<T>(T entity) where T : class
        {
            Context.Set<T>().Add(entity);
        }
        public void Add<T>(List<T> entityList) where T : class
        {
            foreach (T entity in entityList)
                Context.Set<T>().Add(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            Context.Set<T>().Remove(entity);
        }

        public void DeleteMany<T>(List<T> entities) where T : class
        {
            foreach (T entity in entities)
                Context.Set<T>().Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            Context.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void BeginTransaction()
        {
            Context.Database.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);
        }
    }
}
