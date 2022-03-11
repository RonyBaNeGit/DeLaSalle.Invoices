using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Repositories.Interfaces;
using DeLaSalle.Invoices.Api.Services.Interfaces;

namespace DeLaSalle.Invoices.Api.Services;

    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

        }
        public async Task<List<Customer>> GetAllAsync()
        {
           return await _customerRepository.GetAllAsync();
        }
        
            
    }
    