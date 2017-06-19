﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.PIS.BusinessService.Contracts;
using OpenQbit.PIS.DataAccess.DAL.Contracts;

namespace OpenQbit.PIS.BusinessService.BLL
{
    public class MessageManager : IMessageMannager
    {
        IRepository _repository;
        public bool Delete<T>(T obj) where T : class
        {
            return _repository.Delete(obj);
        }

        public T Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _repository.Find(predicate);
        }

        public List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _repository.FindList(predicate);
        }

        public List<T> GetAll<T>() where T : class
        {
            return _repository.GetAll<T>();
        }

        public bool Recored<T>(T obj) where T : class
        {
            return _repository.Create(obj);
        }

        public bool Save()
        {
            return _repository.Save();
        }

        public bool Update<T>(T obj) where T : class
        {
            return _repository.Update(obj);
        }
    }
}
