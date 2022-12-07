namespace BeckEndLessons.Lecture7
{
    public static class HomeWork7
    {
        public static void HomeWork_7_1()
        {
            FileWorkerChild fWorker = new FileWorkerChild();
            fWorker.MaxSize = 128;
            fWorker.FileExtenshion = "txt";

            fWorker.Read(fWorker);
            fWorker.Write(fWorker);
            fWorker.Edit(fWorker);
            fWorker.Delete(fWorker);
        }
        public static void HomeWork_7_2()
        {
            double CreditAmount =  WriteTextToConsole.GetNumberFromUser("Please enter the required amount:", foreColor: ConsoleColor.DarkYellow);
            double CreditPeriod =  WriteTextToConsole.GetNumberFromUser("Please enter for how many months " +
                                    "you need to get a loan:", foreColor: ConsoleColor.DarkYellow);

            string bankAnswer = "";
            string microFinanceAnswer = "";

            var bank = new Bank();
            if (bank.CheckUserHistory()){
                bankAnswer = bank.CalculateLoanPercent(CreditPeriod, CreditAmount);
                WriteTextToConsole.WriteColoredText($"The bank gave you a loan in the amount of " +
                    $"\n{CreditAmount} USD and for {CreditPeriod} months. " +
                    $"\npercent of the total loan for {CreditPeriod} months is {bankAnswer} dollars.", foreColor: ConsoleColor.Cyan);
            }
            else
            {
                WriteTextToConsole.WriteColoredText("The bank denied you a loan.", foreColor:ConsoleColor.Cyan);
            }

            var mikroFinance = new MicroFinance();
            microFinanceAnswer = mikroFinance.CalculateLoanPercent(CreditPeriod, CreditAmount);
            WriteTextToConsole.WriteColoredText($"The microfinance company gave you a loan in the amount of " +
                $"\n{CreditAmount} USD and for {CreditPeriod} months. " +
                $"\npercent of the total loan for {CreditPeriod} months is {microFinanceAnswer} dollars.", foreColor: ConsoleColor.Cyan);
        }

    }
}
