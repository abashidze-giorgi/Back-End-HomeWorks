using System;

namespace HomeWork_9.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string CreateDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobPosition { get; set; }
        public int Salary { get; set; }
        public int WorkExperince { get; set; }
        public AddressModel PersonAddress { get; set; }
    }
}
