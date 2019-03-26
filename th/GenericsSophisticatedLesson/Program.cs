using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSophisticatedLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Chekcer<Director> checker = new Chekcer<Director>();
            checker.MakeCheck(new Director());
        }
    }
}
