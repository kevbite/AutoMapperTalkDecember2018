using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo09
{
    public class FlatteningExample
    {
        public void Go()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderViewModel>();
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
        public List<OrderLineItem> OrderLineItems { get; set; }
    
        public Customer Customer { get; set; }

        public decimal GetTotal()
        {
            return OrderLineItems.Sum(li => li.GetTotal());
        }
    }


    public class Customer
    {
        public string Name { get; set; }
    }

    public class OrderLineItem
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal GetTotal()
        {
            return Quantity * Product.Price;
        }
    }

    public class Product
    {
        public decimal Price { get; set; }

        public string Name { get; set; }
    }

    public class OrderViewModel
    {
        public string CustomerName { get; set; }
        
        public decimal Total { get; set; }
    }
}
