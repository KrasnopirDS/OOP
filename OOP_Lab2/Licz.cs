using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2
{
    internal class Licz
    {
        int value;

        public Licz(int IntValue)
        {
            value = IntValue;
        }
        public void Dodaj(int number)
        {
            value += number;
        }
        public void Odejm(int number)
        {
            value -= number;
        }
        public void StanValue()
        {
            Console.WriteLine($"Aktualna vartość: {value}");
        }
    }
}
