using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeckEndLessons.classes;
using BeckEndLessons.Lecture3;
namespace BeckEndLessons.Lecture3
{
    public class HomeWork3
    {
        #region HomeWork1

        public static void HomeWork3_1()
        {
            double userNum = WriteTextToConsole.GetNumberFromUser("Enter Num: ", foreColor: ConsoleColor.DarkYellow);

            var balance = userNum % 5;

            if (balance == 0)
            {
                WriteTextToConsole.WriteColoredText($"\"Yes, the number {userNum} is a multiple of five.", foreColor:ConsoleColor.Cyan);
                Console.WriteLine();
            }
            else
            {
                WriteTextToConsole.WriteColoredText($"No, the number {userNum} is not divisible by five without a remainder."
                    , foreColor: ConsoleColor.Cyan);
            }
        }
        #endregion

        public static void HomeWork3_2()
        {
            double firstNum = WriteTextToConsole.GetNumberFromUser("Enter first Num: ", foreColor: ConsoleColor.DarkYellow);
            double secondNum = WriteTextToConsole.GetNumberFromUser("Enter second Num: ", foreColor: ConsoleColor.DarkYellow);

            double sumNum = firstNum + secondNum;

            WriteTextToConsole.WriteColoredText($"Sum = {sumNum}", foreColor:ConsoleColor.DarkYellow);

            double multiplNum = firstNum * secondNum;
            WriteTextToConsole.WriteColoredText($"Multiply = {multiplNum}", foreColor:ConsoleColor.DarkYellow);

            double subNum;

            double divNum;

            if (firstNum > secondNum)
            {
                subNum = firstNum - secondNum;
                WriteTextToConsole.WriteColoredText($"Sub =  {subNum}", foreColor:ConsoleColor.DarkYellow);
                if (secondNum != 0)
                {
                    divNum = firstNum / secondNum;
                    WriteTextToConsole.WriteColoredText($"Division = {divNum}", foreColor:ConsoleColor.DarkYellow);
                }
                else
                {
                    WriteTextToConsole.WriteColoredText("Cannot be divided by zero", foreColor:ConsoleColor.DarkYellow);
                }
            }
            else
            {
                subNum = secondNum - firstNum;
                WriteTextToConsole.WriteColoredText($"Sub =  {subNum}", foreColor:ConsoleColor.DarkYellow);
                if (firstNum != 0)
                {
                    divNum = secondNum / firstNum;
                    Console.WriteLine();
                    WriteTextToConsole.WriteColoredText($"Division = {divNum}", foreColor:ConsoleColor.DarkYellow);
                }
                else
                {
                    WriteTextToConsole.WriteColoredText("Cannot be divided by zero", foreColor:ConsoleColor.DarkYellow);
                }
            }
        }

        public static void HomeWork3_3()
        {
            double numX = WriteTextToConsole.GetNumberFromUser("Please, enter X value", foreColor: ConsoleColor.DarkYellow);
            double numY = WriteTextToConsole.GetNumberFromUser("Please, enter Y value", foreColor: ConsoleColor.DarkYellow);
            double tempNum = numX;
            numX = numY;
            numY = tempNum;
            WriteTextToConsole.WriteColoredText($"Num X - {numX}, NumY - {numY}", foreColor:ConsoleColor.Cyan);
        }
    }
}
