using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4_Zd1
{
    internal class Rectangle : Shape
    {
        public override void Draw() { Console.WriteLine($"Drawing a rectangle: x = {X}, y = {Y}, width = {Width}, height = {Height}"); }
    }
}
