using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOfFoo
{

    public class Foo
    {
        public virtual void Job1()
        {
            Console.WriteLine("Job1");
        }
    }


    public class Foo2
    {
        public virtual void Job1()
        {
            Console.WriteLine("Job1");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
