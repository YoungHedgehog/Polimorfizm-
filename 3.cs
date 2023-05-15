using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public abstract class Number
    {
        public abstract void Load();
        public abstract void Write();
    }

    public class NInt : Number
    {
        public int value;

        public override void Load()
        {
            Console.WriteLine("Give integer number:");
            value = int.Parse(Console.ReadLine());
        }

        public override void Write()
        {
            Console.WriteLine("Value integer " + value);
        }
    }

    public class NDouble : Number
    {
        public double value;

        public override void Load()
        {
            Console.WriteLine("Give double number:");
            value = double.Parse(Console.ReadLine());
        }

        public override void Write()
        {
            Console.WriteLine("Value of double number: " + value);
        }
        public static void Main(string[] args)
        {
            Number nInt = new NInt();
            Number nDouble = new NDouble();

            nInt.Load();
            nInt.Write();

            nDouble.Load();
            nDouble.Write();
            Console.ReadKey();
        }
    }
}
