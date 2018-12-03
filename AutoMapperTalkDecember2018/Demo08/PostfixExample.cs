using AutoFixture;
using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo08
{
    public class PostfixExample
    {
        public void Go()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderViewModel>();

                cfg.RecognizePostfixes("String", "Boolean", "Number");
            });

            var mapper = mapperConfiguration.CreateMapper();

            GoMap(mapper);

        }

        public void GoMap(IMapper mapper)
        {
            var user = new Fixture().Create<Order>();

            user.DumpToConsole();

            var viewModel = mapper.Map<OrderViewModel>(user);

            viewModel.DumpToConsole();
        }
    }

    public class Order
    {
        public string IdString { get; set; }

        public int ItemCountNumber { get; set; }

        public bool HasCompleteBoolean { get; set; }

    }

    public class OrderViewModel
    {
        public string Id { get; set; }

        public int ItemCount { get; set; }

        public bool HasComplete { get; set; }
    }
}
