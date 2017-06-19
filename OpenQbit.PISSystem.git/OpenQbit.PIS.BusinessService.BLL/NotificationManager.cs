using OpenQbit.PIS.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using OpenQbit.PIS.DataAccess.DAL.Contracts;

namespace OpenQbit.PIS.BusinessService.BLL
{
    public class NotificationManager : INotificationManager
    {
        IRepository _repository;
        public NotificationManager(IRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete<T>(T obj) where T : class
        {
            throw new NotImplementedException();
        }

        public T Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public bool Recored<T>(T obj) where T : class
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T obj) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
