namespace BeckEndLessons.Lecture7
{
    public class MicroFinance: IFinanceOperations
    {
        private double yearPercent = 0.1;
        private double monthComission = 4;
        private int monthsInYear = 12;
        public string CalculateLoanPercent(double months, double fullAmont)
        {
            return (Math.Round(months / monthsInYear * yearPercent * fullAmont + months * monthComission).ToString());
        }

        public bool CheckUserHistory()
        {
            return true;
        }
    }
}
