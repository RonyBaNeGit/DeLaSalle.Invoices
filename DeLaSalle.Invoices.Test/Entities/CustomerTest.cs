using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Entities;
using Xunit;

namespace DeLaSalle.Invoices.Test.Entities;

    public class CustomerTest
    {
        


     [Fact]
        public void Name_WhenSetNameValue_ReturnSameValue()
        {
            // arrange
            var expected = "Delasalle Oaxaca";
            var sut = new Customer();

            //act
            sut.Name = expected;

            var result = sut.Name;

            //assert

            Assert.Equal(expected, result);


        }
    }
