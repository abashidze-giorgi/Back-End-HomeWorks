namespace BeckEndLessons.Lecture7
{
    public class Bank : IFinanceOperations
    {
        public string CalculateLoanPercent(double month, double AmountPerMonth)
        {
            return (Math.Round(month * AmountPerMonth * 0.05).ToString());
        }
        public bool CheckUserHistory()
        {
            return new Random().Next(0,2) == 1 ? true : false;
        }
    }
}
