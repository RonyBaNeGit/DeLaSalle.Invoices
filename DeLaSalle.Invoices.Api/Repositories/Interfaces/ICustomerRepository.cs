using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
    }
}