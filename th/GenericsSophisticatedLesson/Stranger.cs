using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSophisticatedLesson
{
    public class Stranger : IManager
    {
        public void DoManagerWork()
        {
            Console.WriteLine("Левый чувак делает менеджерскую работу");
        }
    }
}
