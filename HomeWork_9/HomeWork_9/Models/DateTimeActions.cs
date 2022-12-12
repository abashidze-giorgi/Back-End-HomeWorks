using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace HomeWork_9.Models
{
    public class DateTimeActions
    {
        public static bool GetDateFromString(string dateString)
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
    }
}
