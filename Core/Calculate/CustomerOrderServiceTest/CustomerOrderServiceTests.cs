using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CustomerOrderService;

namespace CustomerOrderServiceTest
{
    [TestFixture]
    class CustomerOrderServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase]
        public void When_PremiumCustomer_Expect_10PercentDiscount()
        {
            Customer premiumCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "Sanket",
                CustomerType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderId = 1,
                ProductId = 212,
                ProducQuantity = 1,
                Amount = 150
            };

            CustomerOrderService.CustomerOrderService customerOrderService = new CustomerOrderService.CustomerOrderService();

            customerOrderService.ApplyDiscount(premiumCustomer, order);
            Assert.AreEqual(order.Amount, 135);
        }

        [TestCase]
        public void When_SpecialCustomer_Expect_20PercentDiscount()
        {
            Customer specialCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "Sanket",
                CustomerType = CustomerType.SpecialCustomer
            };

            Order order = new Order
            {
                OrderId = 1,
                ProductId = 212,
                ProducQuantity = 1,
                Amount = 0
            };

            CustomerOrderService.CustomerOrderService customerOrderService = new CustomerOrderService.CustomerOrderService();

            customerOrderService.ApplyDiscount(specialCustomer, order);
            Assert.AreEqual(order.Amount, 0);
        }
    }
}
