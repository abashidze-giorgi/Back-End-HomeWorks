using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckEndLessons.Lecture7
{
    public class ClassWork7
    {
        
        public void DoSomething()
        {
            Calculate calculateClass = new Calculate
            {
                Num1 = 10,
                Num2 = 23,
                Num3 = 41
            };
            calculateClass.Calc(calculateClass.Num1, calculateClass.Num2);
            calculateClass.Calc(calculateClass.Num1, calculateClass.Num2, calculateClass.Num3);
        }
    }
}
