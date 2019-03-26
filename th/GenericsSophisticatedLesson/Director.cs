using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSophisticatedLesson
{
    public class Director : Employee, IManager
    {
        public string FullName { get; set; }

        public void DoManagerWork()
        {
            Console.WriteLine($"{FullName} делает свою менеджерскую работу");
        }
    }
}
