using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /*    1. Napisz program z wykorzystaniem klasy figura.Umieść w niej 3 czyste funkcje wirtualne do obliczania: 
        obwodu, pola powierzchni, sumy kątów oraz promienia okręgu wpisanego w daną figurę dla następujących figur 
        geometrycznych - (trójkąt równoboczny, kwadrat, pięciokąt foremny, sześciokąt foremny). 
        Napisz klasy dla wyżej wymienionych figur wraz z funkcjami wirtualnymi, 
        które wykonują obliczenia dla obwodu, pola powierzchni, sumy kątów oraz promienia okręgu wpisanego dla konkretnej figury.*/
    abstract class Figura 
    {
        public abstract double obwod();
        public abstract double pole_powierzchni();
        public abstract double suma_katow();
        public abstract double promienOkreguWpisanego();

    }
    class TrojkatRownoboczny : Figura
    {
        private double _dlugoscBoku;
        public TrojkatRownoboczny(double dlugoscBoku) 
        {
            _dlugoscBoku = dlugoscBoku;
        }
        public override double obwod()
        {
            return 3 * _dlugoscBoku;
        }
        public override double pole_powierzchni()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(_dlugoscBoku, 2);
        }
        public override double promienOkreguWpisanego()
        {
            return _dlugoscBoku / (2 * Math.Sqrt(3));
        }
        public override double suma_katow()
        {
            return 180;
        }
    }
    class Kwadrat : Figura
    {
        private double _dlugoscBoku;
        public Kwadrat(double dlugoscBoku)
        {
            _dlugoscBoku = dlugoscBoku;
        }
        public override double obwod()
        {
            return 4 * _dlugoscBoku;
        }
        public override double pole_powierzchni()
        {
            return _dlugoscBoku * _dlugoscBoku;
        }
        public override double promienOkreguWpisanego()
        {
            return _dlugoscBoku / 2;
        }
        public override double suma_katow()
        {
            return 360;
        }
    }
    class PieciokatForemny : Figura
    {
        private double _dlugoscBoku;
        public PieciokatForemny(double dlugoscBoku)
        {
            _dlugoscBoku = dlugoscBoku;
        }
        public override double obwod()
        {
            return 5 * _dlugoscBoku;
        }
        public override double pole_powierzchni()
        {
            return (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4) * Math.Pow(_dlugoscBoku, 2);
        }
        public override double promienOkreguWpisanego()
        {
            return (_dlugoscBoku / 2) * Math.Sqrt(5 - (2 * Math.Sqrt(5)));
        }
        public override double suma_katow()
        {
            return 540;
        }
    }
    class SzesciokatForemny : Figura
    {
        private double _dlugoscBoku;
        public SzesciokatForemny(double dlugoscBoku)
        {
            _dlugoscBoku = dlugoscBoku;
        }
        public override double obwod()
        {
            return 6 * _dlugoscBoku;
        }
        public override double pole_powierzchni()
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(_dlugoscBoku, 2);
        }
        public override double promienOkreguWpisanego()
        {
            return (_dlugoscBoku / 2) * Math.Sqrt(3);
        }
        public override double suma_katow()
        {
            return 720;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double dlugoscBoku = 5;

            Figura trojkat = new TrojkatRownoboczny(dlugoscBoku);
            Console.WriteLine("Trójkąt równoboczny:");
            Console.WriteLine("Obwód: " + trojkat.obwod());
            Console.WriteLine("Pole: " + trojkat.pole_powierzchni());
            Console.WriteLine("Suma kątów: " + trojkat.suma_katow());
            Console.WriteLine("Promień okręgu wpisanego: " + trojkat.promienOkreguWpisanego());

            Figura kwadrat = new Kwadrat(dlugoscBoku);
            Console.WriteLine("\nKwadrat:");
            Console.WriteLine("Obwód: " + kwadrat.obwod());
            Console.WriteLine("Pole: " + kwadrat.pole_powierzchni());
            Console.WriteLine("Suma kątów: " + kwadrat.suma_katow());
            Console.WriteLine("Promień okręgu wpisanego: " + kwadrat.promienOkreguWpisanego());

            Figura pieciokat = new PieciokatForemny(dlugoscBoku);
            Console.WriteLine("\nPięciokąt foremny:");
            Console.WriteLine("Obwód: " + pieciokat.obwod());
            Console.WriteLine("Pole: " + pieciokat.pole_powierzchni());
            Console.WriteLine("Suma kątów: " + pieciokat.suma_katow());
            Console.WriteLine("Promień okręgu wpisanego: " + pieciokat.promienOkreguWpisanego());

            Figura szesciokat = new SzesciokatForemny(dlugoscBoku);
            Console.WriteLine("\nSześciokąt foremny:");
            Console.WriteLine("Obwód: " + szesciokat.obwod());
            Console.WriteLine("Pole: " + szesciokat.pole_powierzchni());
            Console.WriteLine("Suma kątów: " + szesciokat.suma_katow());
            Console.WriteLine("Promień okręgu wpisanego: " + szesciokat.promienOkreguWpisanego());
            Console.ReadKey();
        }
    }
}
