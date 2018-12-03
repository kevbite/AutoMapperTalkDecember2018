using AutoFixture;
using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo06
{
    public class SnakeCaseExample
    {
        public void Go()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Metrics, MetricsViewModel>();

                cfg.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
                cfg.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
            });

            var mapper = mapperConfiguration.CreateMapper();

            GoMap(mapper);

        }

        public void GoMap(IMapper mapper)
        {
            var user = new Fixture().Create<Metrics>();

            user.DumpToConsole();

            var viewModel = mapper.Map<MetricsViewModel>(user);

            viewModel.DumpToConsole();
        }
    }

    public class Metrics
    {
        public decimal speed_at_the_start { get; set; }

        public decimal speed_at_the_end { get; set; }

    }

    public class MetricsViewModel
    {
        public decimal SpeedAtTheStart { get; set; }

        public decimal SpeedAtTheEnd { get; set; }
    }

}
