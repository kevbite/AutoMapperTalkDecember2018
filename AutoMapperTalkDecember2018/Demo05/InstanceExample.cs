using AutoFixture;
using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo05
{
    public class InstanceExample
    {
        public void Go()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => cfg.CreateMap<User, UserViewModel>());

            var mapper = mapperConfiguration.CreateMapper();

            GoMap(mapper);

        }

        public void GoMap(IMapper mapper)
        {
            var user = new Fixture().Create<User>();

            user.DumpToConsole();

            var viewModel = mapper.Map<UserViewModel>(user);

            viewModel.DumpToConsole();
        }
    }

    public class User
    {
        public string Username { get; set; }
    }

    public class UserViewModel
    {
        public string Username { get; set; }
    }

}
