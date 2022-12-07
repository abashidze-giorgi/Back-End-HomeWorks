namespace BeckEndLessons.Lecture7
{
    public class Bank : IFinanceOperations
    {
        private double yearPercent = 0.05;
        private int monthsInYear = 12;
        public string CalculateLoanPercent(double loanPeriod, double loanAmount)
        {
            return (Math.Round(loanPeriod / monthsInYear * yearPercent * loanAmount).ToString());
        }
        public bool CheckUserHistory()
        {
            return new Random().Next(0,2) == 1 ? true : false;
        }
    }
}
