using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Repositories.Interfaces;

namespace DeLaSalle.Invoices.Api.Repositories
{
    public class CustomerInMemoryRepository : ICustomerRepository
    {
         public async Task<List<Customer>> GetAllAsync() 
        {
            var lst = new List<Customer>();
            lst.Add(new Customer{ Id = 1, Name = "Customer"});

            return await Task.FromResult(lst);
        }
    }
}