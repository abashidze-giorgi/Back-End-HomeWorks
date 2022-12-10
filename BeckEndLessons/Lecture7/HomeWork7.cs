using BeckEndLessons.classes;

namespace BeckEndLessons.Lecture7
{
    public class HomeWork7
    {
        HomeWorkModel hw1 = new HomeWorkModel()
        {
            name = "HomeWork_7_1",
            description = "Create an abstract class FileWorker that\nwill have 1 parameter maximum file size,1" +
                "\nAbstract parameter file extension and 4 methods Read(),Write(),Edit(),Delete()" +
                "\nMethods in the child class must be able to call the parent class" +
                "\nOverriding methods and also using parameters",
            index = 71,
        };

        HomeWorkModel hw2 = new HomeWorkModel()
        {
            name = "HomeWork_7_1",
            description = "Create an interface FinanceOperations that will have" +
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
                "\r\nService fee in the amount of $4",
            index = 72
        };
        public void HomeWork_7_1()
        {
            hw1.WriteDescAndRunFunction(hw1, Execution_7_1);
        }
        public void HomeWork_7_2()
        {
            hw2.WriteDescAndRunFunction(hw2, Execution_7_2);
        }

        private void Execution_7_1()
        {
            FileWorkerChild fWorker = new FileWorkerChild();
            fWorker.MaxSize = 128;
            fWorker.FileExtenshion = "txt";

            fWorker.Read(fWorker);
            fWorker.Write(fWorker);
            fWorker.Edit(fWorker);
            fWorker.Delete(fWorker);
        }


        private void Execution_7_2()
        {
            double loanAmount =  WriteTextToConsole.GetNumberFromUser("Please enter the required amount:", foreColor: ConsoleColor.DarkYellow);
            double loanPeriod =  WriteTextToConsole.GetNumberFromUser("Please enter for how many months " +
                                    "you need to get a loan:", foreColor: ConsoleColor.DarkYellow);

            var bank = new Bank();
            if (bank.CheckUserHistory()){
                string bankAnswer = bank.CalculateLoanPercent(loanPeriod, loanAmount);
                WriteTextToConsole.WriteColoredText($"The bank gave you a loan in the amount of " +
                    $"\n{loanAmount} USD and for {loanPeriod} months. " +
                    $"\npercent of the total loan for {loanPeriod} months is {bankAnswer} dollars.", foreColor: ConsoleColor.Cyan);
            }
            else
            {
                WriteTextToConsole.WriteColoredText("The bank denied you a loan.", foreColor:ConsoleColor.Cyan);
            }

            var mikroFinance = new MicroFinance();
            string microFinanceAnswer = mikroFinance.CalculateLoanPercent(loanPeriod, loanAmount);
            WriteTextToConsole.WriteColoredText($"The microfinance company gave you a loan in the amount of " +
                $"\n{loanAmount} USD and for {loanPeriod} months. " +
                $"\npercent of the total loan for {loanPeriod} months is {microFinanceAnswer} dollars.", foreColor: ConsoleColor.Cyan);
        }

    }
}
