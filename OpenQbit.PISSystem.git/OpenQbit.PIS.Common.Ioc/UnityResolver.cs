using Microsoft.Practices.Unity;
using OpenQbit.PIS.BusinessService.BLL;
using OpenQbit.PIS.BusinessService.Contracts;
using OpenQbit.PIS.Common.Utils.Logs;
using OpenQbit.PIS.DataAccess.DAL;
using OpenQbit.PIS.DataAccess.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.PIS.Common.Ioc
{
    public class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        private static void Register()
        {
            Container.RegisterType<IRepository, Repository>();
            Container.RegisterType<ILogger, Logger>();
            //BLL
            Container.RegisterType<IMessageManager, MessageManager>();
            Container.RegisterType<INotificationManager, NotificationManager>();
            
        }
        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = Container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }
        public static IUnityContainer GetContainer()
        {
            return Container;
        }
    }
}
