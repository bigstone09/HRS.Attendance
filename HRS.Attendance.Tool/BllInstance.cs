using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.Attendance.Tool
{

    public class BllInstance<T>
    {

        public static T WriteInstance
        {
            get
            {
                string resolveName = "IocName";
                var instance = IocInstance.Resolve<T>(resolveName);
                if (ReferenceEquals(instance, null))
                {
                    instance = (T)Activator.CreateInstance(typeof(T), resolveName);
                    IocInstance.Register(resolveName, instance);
                    return instance;
                }
                return instance;
            }
        }

    }
}

