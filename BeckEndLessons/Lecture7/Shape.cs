using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckEndLessons.Lecture7
{
    public abstract class Shape
    {
        public abstract void GetArea();
    }


    public class Rectangle : Shape
    {
        public override void GetArea()
        {
            Console.WriteLine($"a*b/2");
        }
    }
}
