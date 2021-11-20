using System;
using System.Collections.Generic;
namespace Hahn.ApplicatonProcess.July2021.Data
{
    public class UnitOfWork : IDisposable
    {
        DataBaseContext DBContext = new DataBaseContext();
        private Dictionary<string, object> Repositories;
        public Repository<T> Repository<T>() where T : class
        {
            if (Repositories == null)
            {
                Repositories = new Dictionary<string, object>();
            }
            string RepositoryType = typeof(T).Name;
            if (!Repositories.ContainsKey(RepositoryType))
            {
                object repositoryInstance = Activator.CreateInstance(typeof(Repository<>).MakeGenericType(typeof(T)), DBContext);
                Repositories.Add(RepositoryType, repositoryInstance);
            }
            return (Repository<T>)Repositories[RepositoryType];
        }
        public void Dispose()
        {
            DBContext.Dispose();
        }
    }
}