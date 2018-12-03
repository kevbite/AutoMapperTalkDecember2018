using System;
using AutoFixture;
using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo04
{
    public class AssertConfigurationExample
    {
        public void Go()
        {
            var user = new Fixture().Create<User>();

            user.DumpToConsole();

            Mapper.Initialize(cfg => cfg.CreateMap<User, UserViewModel>());

            try
            {
                Mapper.AssertConfigurationIsValid();
            }
            catch (AutoMapperConfigurationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            var viewModel = Mapper.Map<UserViewModel>(user);

            viewModel.DumpToConsole();
        }

    }

    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }

    public class UserViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        // public bool Locked { get; set; }
    }
}