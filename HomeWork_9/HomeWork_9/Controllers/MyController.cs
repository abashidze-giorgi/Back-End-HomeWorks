using HomeWork_9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace HomeWork_9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private string filePath = @"C:\Users\Giorgi\source\repos\HomeWork_9\HomeWork_9\Files\Persons.json";
        [HttpGet("user")]
        public IActionResult GetPersons()
        {
            var personList = GetPersonList();
            if (personList.Count == 0)
            {
                return Ok("No Users In Base.");
            }
            return Ok(personList);
        }


        [HttpPost("user")]
        public IActionResult AddNewPerson([FromForm] Person obj)
        {
            string errorMessage = "";
            if (!PersonClassValidator.IsValid(obj, out errorMessage))
            {
                return BadRequest(errorMessage);
            }
            

            var personList = GetPersonList();

            int personCount;
            if (personList == null || personList.Count == 0)
            {
                personCount = 1;
            }
            else
            {
                personCount = personList.Count + 1;
            }

            Person person = new Person()
            {
                Id = personCount,
                CreateDate = obj.CreateDate,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                JobPosition = obj.JobPosition,
                Salary = obj.Salary,
                WorkExperince = obj.WorkExperince,
                PersonAddress = GetPersonAddress(obj)
            };

            personList.Add(person);
            var result = JsonConvert.SerializeObject(personList);
            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(result);
            writer.Close();
            return Ok(personList);
        }

        private AddressModel GetPersonAddress(Person obj)
        {
            AddressModel address = new AddressModel()
            {
                Country = obj.PersonAddress.Country,
                City = obj.PersonAddress.City,
                HomeNumber = obj.PersonAddress.HomeNumber
            };
            return address;
        }

        private List<Person> GetPersonList()
        {
            var result = new List<Person>();


            StreamReader reader = new StreamReader(filePath);
            var resultString = reader.ReadToEnd();
            reader.Close();
            if (!string.IsNullOrEmpty(resultString))
            {
                result = JsonConvert.DeserializeObject<List<Person>>(resultString);
            }
            return result;
        }

        [HttpGet("user/{id}")]
        public IActionResult GetPersonById(int id)
        {
            var personList = GetPersonList();
            List<Person> person = personList?.Where(x => x.Id == id).ToList();
            if (person.Count > 0)
            {
                return Accepted(person);
            }
            else
            {
                return BadRequest($"No user by id {id}.");
            }

        }

        [HttpGet("userFilter")]
        public IActionResult GetPersonFilter([FromQuery] Person person)
        {
            
            var personList = GetPersonList();
            List <Person> persons = personList?.Where(x => x.Id == person.Id || x.FirstName == person.FirstName ||
                                    x.FirstName == person.FirstName && x.LastName == person.LastName ||
                                    x.LastName == person.LastName || x.WorkExperince == person.WorkExperince ||
                                    x.WorkExperince == person.WorkExperince && x.Salary <= person.Salary ||
                                    x.Salary <= person.Salary).ToList();
            if(persons.Count > 0)
            {
                return Accepted(persons);
            }
            else
            {
                return BadRequest("No persons find");
            }
        }

        [HttpDelete("user/{id}")]
        public IActionResult RemovePersonById(int id)
        {
            var listPerson = GetPersonList();
            var itemToRemove = listPerson.Single(x => x.Id == id);
            listPerson.Remove(itemToRemove);
            if (SavePersonListToFile(listPerson))
            {
                return Ok(listPerson);
            }
            else
            {
                return BadRequest("Cant remove person");
            }
        }

        private bool SavePersonListToFile(List<Person> list)
        {
            bool saved = false;
            try
            {
                var result = JsonConvert.SerializeObject(list);
                StreamWriter writer = new(filePath);
                writer.Write(result);
                writer.Close();
                saved = true;
            }
            catch (Exception)
            {
                return saved;
            }
            
            return saved;
        }

        [HttpPut("user")]
        public IActionResult ReplacePerson([FromQuery] Person person)
        {
            var personList = GetPersonList();
            int index = personList.FindIndex(x => x.Id == person.Id);
            if (index != -1)
            {
                personList[index] = person;
                SavePersonListToFile(personList);
                return Accepted(personList);
            }
            return BadRequest("Can't raplace person");
        }
    }
}
