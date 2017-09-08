using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace HRS.Attendance.Tool
{
    public static class IocInstance
    {
        private static readonly IUnityContainer _container = new UnityContainer();

        public static void Register<T>(string name, T t)
        {
            _container.RegisterInstance(name, t);
        }

        public static T Resolve<T>(string name)
        {
            if (_container.IsRegistered<T>(name))
            {
                return _container.Resolve<T>(name);
            }
            return default(T);
        }
        
    }
}