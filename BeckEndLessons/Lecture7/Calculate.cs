using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckEndLessons.Lecture7
{
    public class Calculate
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }

        public void Calc(int num1, int num2)
        {
            Console.WriteLine(num1 += num2);
        }
        public void Calc(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 += num2 += num3);
        }
    }
}
