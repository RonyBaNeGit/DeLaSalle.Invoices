using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Entities;

namespace DeLaSalle.Invoices.Api.Services.Interfaces;

    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();

    }
