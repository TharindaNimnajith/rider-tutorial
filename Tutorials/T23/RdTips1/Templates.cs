using System;
using System.Collections.Generic;

namespace RdTips1
{
    public class Person
    {
        private readonly string _firstName;
        private readonly string _lastName;
        public string LastName => _lastName;
        public string FirstName => _firstName;

        public Person(string firstName, string lastName)
        {
            _lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            _firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        }
    }

    public partial class Address
    {
        public string City { get; set; }

        public Address(string city)
        {
            city
        }
    }
    
    public static class Utils
    {
        public static void ProcessPeople(IEnumerable<Person> people)
        {
            people
        }

        public static void ShowPeople(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                var firstName = person.FirstName;
                var lastName = person.LastName;
                Console.WriteLine($"{firstName} {lastName}");
            }
        }
    }
}