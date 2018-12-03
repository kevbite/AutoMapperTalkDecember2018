using AutoFixture;
using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo07
{
    public class PrefixExample
    {
        public void Go()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Address, AddressModel>();

                cfg.RecognizePrefixes("Address");
            });

            var mapper = mapperConfiguration.CreateMapper();

            GoMap(mapper);

        }

        public void GoMap(IMapper mapper)
        {
            var user = new Fixture().Create<Address>();

            user.DumpToConsole();

            var viewModel = mapper.Map<AddressModel>(user);

            viewModel.DumpToConsole();
        }
    }

    public class Address
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressTownCity { get; set; }

        public string AddressPostcode { get; set; }

    }

    public class AddressModel
    {
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string TownCity { get; set; }

        public string Postcode { get; set; }
    }
}
