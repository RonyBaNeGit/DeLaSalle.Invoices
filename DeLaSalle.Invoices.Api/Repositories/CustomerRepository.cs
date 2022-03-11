using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Repositories.Interfaces;

namespace DeLaSalle.Invoices.Api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
          public async Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}