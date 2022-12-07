using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckEndLessons.classes
{
    public class ClassAndHomeWorks
    {
        public Dictionary<string, int> ListOfExercises()
        {
            Dictionary<string, int> exercises = new Dictionary<string, int>();
            exercises.Add("Home work 3_1:", 31);
            exercises.Add("Home work 3_2:", 32);
            exercises.Add("Home work 3_3:", 33);
            //exercises.Add("Home work 3_1:", 4);
            //exercises.Add("Home work 3_1:", 5);
            //exercises.Add("Home work 3_1:", 6);
            exercises.Add("Home Work 7_1:", 71);
            exercises.Add("Home Work 7_2:", 72);
            //exercises.Add("HomeWork_5", 8);

            return exercises;
        }


        public Dictionary<int, string> ExerciseDescriptions()
        {
            Dictionary <int, string> descriptions = new Dictionary<int, string>();
            descriptions.Add(31, "shevamotsmot, ikopha tu ara useris mier shekvanili ricxvi 5-ze unashtod.\n" +
                                "pasukhi gamovitanot konsolshi.");
            descriptions.Add(32, "Write a program that performs sum, difference," +
                "\r\noperations of multiplication and division." +
                "\r\nNote\r\n1. When dividing and subtracting, choose the largest and it\r\n" +
                "Subtract the smallest\r\n" +
                "2. If the smallest number is 0, the program should output\r\nError 0 cannot be divided.");
            descriptions.Add(33, "Swap the values of the two variables");

            descriptions.Add(71, "Create an abstract class FileWorker that\nwill have 1 parameter maximum file size,1" +
                "\nAbstract parameter file extension and 4 methods Read(),Write(),Edit(),Delete()" +
                "\nMethods in the child class must be able to call the parent class" +
                "\nOverriding methods and also using parameters");
            descriptions.Add(72, "Create an interface FinanceOperations that will have" +
                "\r\n2 methods\r\nCalculateLoanPercent(int month, double AmountPerMonth)," +
                "\r\nCheckUserHistory()\r\nThe class Bank and MicroFinance implement FinanceOperations" +
                "\r\ninterface.\r\nIn the case of Bank, CheckUserHistory returns either true or random" +
                "\r\nfalse\r\nIn case of agreement, we should call CalculateLoanPercent()" +
                "\r\nwhich will calculate how much the customer n will have to pay" +
                "\r\nIn the case of taking a monthly loan, several will count" +
                "\r\nInterest has to be paid in total. Assume that the percentage" +
                "\r\nThere is a fixed maximum amount of 5%." +
                "\r\n\r\nIn the case of MicroFinance, CheckUserHistory is always True and" +
                "\r\nCalculateLoanPercent() will return the maximum loan amount in this" +
                "\r\nIn this case, the commission is 10% and is added every month" +
                "\r\nService fee in the amount of $4");

            return descriptions;
        }

    }
}
