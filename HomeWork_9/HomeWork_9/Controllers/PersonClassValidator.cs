using HomeWork_9.Models;
using System.IO;

namespace HomeWork_9.Controllers
{
    public class PersonClassValidator
    {
        public static bool IsValid(Person person, out string errorMessage)
        {
            bool isValid = true;
            errorMessage = string.Empty;

            if (!MyValidator.StringIsValid(person.FirstName))
            {
                isValid = false;
                errorMessage = "Firstname cannot be null, empty, or contain more than 50 characters";
            }else if (!MyValidator.StringIsValid(person.LastName))
            {
                isValid = false;
                errorMessage = "Lastname cannot be null, empty, or contain more than 50 characters";
            }
            else if (!MyValidator.DateIsValid(person.CreateDate))
            {
                isValid = false;
                errorMessage = "Create date is invalid. ";
            }
            else if (!MyValidator.StringIsValid(person.JobPosition))
            {
                isValid = false;
                errorMessage = "Job position cannot be null, empty, or contain more than 50 characters";
            }
            else if (person.Salary < 0 || person.Salary > 10000)
            {
                isValid = false;
                errorMessage = "salary must be between 0 and 10000";
            }
            else if (string.IsNullOrEmpty(person.WorkExperince.ToString()))
            {
                isValid = false;
                errorMessage = "Work experience cannot be null";
            }

            return isValid;
        }
    }
}
