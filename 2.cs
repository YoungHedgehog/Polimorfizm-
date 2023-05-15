using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IFirstInterface
    {
        void FirstMethod();
    }
    interface ISecondInterface
    { 
        void SecondMethod();
    }
    class FirstClass : IFirstInterface
    {
        public void FirstMethod() 
        {
            Console.WriteLine("I'm a first class");
        }
    }
    class SecondClass : ISecondInterface
    { 
        public void SecondMethod() 
        {
            Console.WriteLine("I'm a second class");
        }
    }
    class ThirdClass : IFirstInterface, ISecondInterface
    {
        public void FirstMethod() 
        {
            Console.WriteLine("I'm in third class *FirstMethod*");
        }
        public void SecondMethod()
        {
            Console.WriteLine("I'm in third class *SecondMethod*");
        }
    }
    class FourthClass : IFirstInterface, ISecondInterface
    {
        public void FirstMethod()
        {
            Console.WriteLine("I'm in fourth class *FirstMethod*");
        }
        public void SecondMethod()
        {
            Console.WriteLine("I'm in fourth class *SecondMethod*");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFirstInterface> listFirstObject = new List<IFirstInterface>();
            listFirstObject.Add(new FirstClass());
            listFirstObject.Add(new ThirdClass());
            listFirstObject.Add(new FourthClass());
            List<ISecondInterface> listSecondObject = new List<ISecondInterface>();
            listSecondObject.Add(new SecondClass());
            listSecondObject.Add(new ThirdClass());
            listSecondObject.Add(new FourthClass());
            Console.ReadKey();
        }
    }
}
