using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AbstractClass
    {
        public abstract void AbstractMetod();
    }
    class ClassFirst : AbstractClass
    {
        public override void AbstractMetod()
        {
            Console.WriteLine("I'm first class");
        }
    }
    class ClassSecond : AbstractClass
    {
        public override void AbstractMetod()
        {
            Console.WriteLine("I'm second class");
        }
    }
    class ClassThird : AbstractClass
    {
        public override void AbstractMetod()
        {
            Console.WriteLine("I'm third class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AbstractClass> listObject = new List<AbstractClass>();
            listObject.Add(new ClassFirst());
            listObject.Add(new ClassSecond());
            listObject.Add(new ClassThird());
            listObject.Add(new ClassFirst());
            listObject.Add(new ClassSecond());
            listObject.Add(new ClassThird());
        }
    }
}
