using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB_interface
{
    public class InstanceOf<T>
    {
        public T Create()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}
