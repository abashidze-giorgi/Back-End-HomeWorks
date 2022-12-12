using System.Globalization;
using System;
using System.Net.Mail;

namespace HomeWork_9.Models
{
    public class MyValidator
    {
        public static bool EmailIsValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }

        public static bool DateIsValid(string dateString)
        {
            try
            {
                //DateTime date = DateTime.Parse(dateString);
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (typeof(DateTime).IsAssignableFrom(date.GetType()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool StringIsValid(string str)
        {
            bool isValid = true;

            if(string.IsNullOrEmpty(str) || str.Length > 50)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
