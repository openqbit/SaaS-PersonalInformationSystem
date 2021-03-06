﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.PIS.BusinessService.Contracts
{
    public interface ICommonServiceManager
    {
            
        bool Recored<T>(T obj) where T : class;
        bool Update<T>(T obj) where T : class;
        bool Delete<T>(T obj) where T : class;
        List<T> GetAll<T>() where T : class;
        T Find<T>(Expression<Func<T, bool>> predicate) where T : class;
        List<T> FindList<T>(Expression<Func<T, bool>> predicate) where T : class;
        bool Save();
    

    }
}
