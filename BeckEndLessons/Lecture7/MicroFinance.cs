namespace BeckEndLessons.Lecture7
{
    public class MicroFinance: IFinanceOperations
    {
        public string CalculateLoanPercent(double month, double AmountPerMonth)
        {
            return (Math.Round(month * AmountPerMonth * 0.1 + month * 4).ToString());
        }

        public bool CheckUserHistory()
        {
            return true;
        }
    }
}
