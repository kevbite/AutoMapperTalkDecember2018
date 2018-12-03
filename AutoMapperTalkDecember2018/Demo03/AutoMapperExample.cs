using System;
using System.Collections.Generic;
using AutoFixture;
using AutoMapper;

namespace AutoMapperTalkDecember2018.Demo03
{
    public class AutoMapperExample
    {
        public void Go()
        {
            var order = new Fixture().Create<Order>();

            order.DumpToConsole();

            Mapper.Initialize(_ => { });
            var viewModel = Mapper.Map<OrderViewModel>(order);

            viewModel.DumpToConsole();
        }

        public class Order
        {
            public string Id { get; set; }

            public BillingAddress BillingAddress { get; set; }

            public ShippingAddress ShippingAddress { get; set; }

            public PaymentDetails PaymentDetails { get; set; }

            public List<Item> Items { get; set; }

        }


        public class PaymentDetails
        {
            public string CardHolder { get; set; }

            public string CardNumber { get; set; }

            public string Csv { get; set; }

            public DateTime ExpiryDate { get; set; }
        }

        public class ShippingAddress
        {
            public int? HouseNumber { get; set; }

            public int? FlatNumber { get; set; }

            public string HouseName { get; set; }

            public string Street1 { get; set; }

            public string Postcode { get; set; }
        }

        public class BillingAddress
        {
            public int? HouseNumber { get; set; }

            public int? FlatNumber { get; set; }

            public string HouseName { get; set; }

            public string Street1 { get; set; }

            public string Street2 { get; set; }

            public string CityTown { get; set; }

            public string Postcode { get; set; }
        }

        public class Item
        {
            public string Id { get; set; }

            public string Description { get; set; }

            public decimal Price { get; set; }
        }



        public class OrderViewModel
        {
            public string Id { get; set; }

            public AddressViewModel BillingAddress { get; set; }

            public AddressViewModel ShippingAddress { get; set; }

            public PaymentDetailsViewModel PaymentDetails { get; set; }

            public List<ItemViewModel> Items { get; set; }

        }


        public class PaymentDetailsViewModel
        {
            public string CardHolder { get; set; }

            public string CardNumber { get; set; }

            public string Csv { get; set; }

            public DateTime ExpiryDate { get; set; }
        }

        public class AddressViewModel
        {
            public int? HouseNumber { get; set; }

            public int? FlatNumber { get; set; }

            public string HouseName { get; set; }
            
            public string Postcode { get; set; }
        }

        public class ItemViewModel
        {
            public string Id { get; set; }

            public string Description { get; set; }

            public decimal Price { get; set; }
        }
    }

}