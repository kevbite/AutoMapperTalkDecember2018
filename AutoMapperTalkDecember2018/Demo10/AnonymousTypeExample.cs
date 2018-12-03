using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo10
{
    public class AnonymousTypeExample
    {
        public void Go()
        {
            var mapperConfiguration = new MapperConfiguration(_ => { });

            var mapper = mapperConfiguration.CreateMapper();

            GoMap(mapper);

        }

        public void GoMap(IMapper mapper)
        {
            var person = new {Name = "Bob", Age = 21};
            person.DumpToConsole();

            var viewModel = mapper.Map<PersonViewModel>(person);

            viewModel.DumpToConsole();
        }
    }

    public class PersonViewModel
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
