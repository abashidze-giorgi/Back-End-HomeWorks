namespace BeckEndLessons.Lecture7
{
    public interface IFinanceOperations
    {
        public string CalculateLoanPercent(double month, double AmountPerMonth);

        public bool CheckUserHistory();
    }
}
