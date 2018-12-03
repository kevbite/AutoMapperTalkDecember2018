using System;
using AutoFixture;

namespace AutoMapperTalkDecember2018.Demo01
{
    public class WithoutAutoMapperExample1
    {
        public void Go()
        {
            var person = new Fixture().Create<Person>();

            person.DumpToConsole();
            Console.ReadLine();

            var viewModel = new PersonViewModel()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Age = person.Age
            };

            person.DumpToConsole();
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }

    }

    public class PersonViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }
    }
}
