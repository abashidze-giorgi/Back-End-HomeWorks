using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeckEndLessons.Lecture7
{
    public interface IFinanceOperations
    {
        public string CalculateLoanPercent(double month, double AmountPerMonth);

        public bool CheckUserHistory();
    }
}
