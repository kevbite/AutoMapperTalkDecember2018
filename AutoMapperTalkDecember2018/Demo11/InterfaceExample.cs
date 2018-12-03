using AutoFixture;
using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo11
{
    public class InterfaceExample
    {
        public void Go()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => cfg.CreateMap<Person, IPersonViewModel>());

            var mapper = mapperConfiguration.CreateMapper();

            GoMap(mapper);

        }

        public void GoMap(IMapper mapper)
        {
            var person = new Fixture().Create<Person>();
            person.DumpToConsole();

            var viewModel = mapper.Map<IPersonViewModel>(person);

            viewModel.DumpToConsole();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public interface IPersonViewModel
    {
        string Name { get; set; }

        int Age { get; set; }
    }
}
