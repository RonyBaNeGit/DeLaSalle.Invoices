using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using DeLaSalle.Invoices.Api.Services;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Repositories.Interfaces;
using Moq;



namespace DeLaSalle.Invoices.Test.ApiServices;

    public class CustomerServiceTest
    {

        [Fact]
        public async Task GetAllAsync_WhenGetList_ReturnList()
        {
            //arrange
                var expected = new List<Customer>
                {
                    new Customer{Id = 1, Name = "Customer 1"},
                     new Customer{Id = 2, Name = "Customer 2"},
                };

                var mock = new Mock<ICustomerRepository>();

                mock.Setup(m => m.GetAllAsync()).Returns(Task.FromResult(expected));

                 var sut = new CustomerService(mock.Object);

              //  var repo = new CustomerRepository();
               // var sut = new CustomerService(repo);
                
            //act

                var result = await sut.GetAllAsync();
                  



            //asset

                Assert.Equal(expected, result);
        }
    }
