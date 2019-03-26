using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSophisticatedLesson
{
    public class Chekcer<T> where T: Employee, IManager, new()
    {
        public void MakeCheck(T entity)
        {
            entity.DoManagerWork();
            // working... T
        }

        public T CreateEntity()
        {
            return new T();
        }
        //public bool MakeCheck(object obj)
        //{
        //    if (obj is IManager && obj is Employee)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

    }
}
