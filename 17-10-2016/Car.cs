using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_10_2016
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        private static int iloscKol;

        public Car()
        { }
        public Car(string marka, double pojemnoscSilnika)
        {
            this.marka = marka;
            this.pojemnoscSilnika = pojemnoscSilnika;
        }
        public static Car Create()
        {
            return new Car();
        }

        public static Car kola()
        {
            iloscKol = 4;
            return new Car();
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }

    }
}