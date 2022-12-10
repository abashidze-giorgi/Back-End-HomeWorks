using BeckEndLessons.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckEndLessons.Lecture4
{
    public class HomeWork4
    {
        HomeWorkModel hw1 = new HomeWorkModel()
        {
            name = "HomeWork_4_1",
            description = "Write a program that receives 1 number from the console " +
            "\nand prints it multiplication table for this number" +
            "\na. Note: Use a loop.",
            index = 41
        };

        HomeWorkModel hw2 = new HomeWorkModel()
        {
            name = "HomeWork_4_2",
            Description = "Write a program that finds all even numbers from 1 to n and prints their squares.",
            index = 42
        };

        public void HomeWork_4_1()
        {
            hw1.WriteDescAndRunFunction(hw1,Execution_4_1);
        }

        public void Execution_4_1()
        {
            int num = Convert.ToInt32(WriteTextToConsole.GetNumberFromUser("Enter number from 1 to 9", foreColor: ConsoleColor.DarkYellow));
            WriteTextToConsole.WriteColoredText($"You enter number {num}", foreColor: ConsoleColor.Cyan);
            string output = "";
            for (int i = 1; i < 10; i++)
            {
                output += ($"{i} * {num} = {i * num}") + "\n";
            }
            WriteTextToConsole.WriteColoredText(output, foreColor: ConsoleColor.Cyan);
        }


        public void HomeWork_4_2()
        {
            hw2.WriteDescAndRunFunction(hw2, Execution_4_2);
        }

        private void Execution_4_2()
        {
            double num1 = WriteTextToConsole.GetNumberFromUser("Enter your number", foreColor: ConsoleColor.DarkYellow);
            WriteTextToConsole.WriteColoredText($"You enter number {num1}", foreColor: ConsoleColor.Cyan);
            Console.WriteLine("Output:");
            string output = "";
            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                    output += $"square of {i} is : {i * i}" + "\n";
                }
            }
            WriteTextToConsole.WriteColoredText(output, foreColor: ConsoleColor.Cyan);
        }
    }
}
