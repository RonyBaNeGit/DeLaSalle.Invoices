using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeLaSalle.Invoices.Entities;
using DeLaSalle.Invoices.Api.Responses;
using Microsoft.AspNetCore.Mvc;
using DeLaSalle.Invoices.Api.Services.Interfaces;
using DeLaSalle.Invoices.Api.Repositories.Interfaces;


namespace DeLaSalle.Invoices.Api.Controllers;


    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
         
        public async Task<ActionResult<Response<IEnumerable<DeLaSalle.Invoices.Entities.Customer>>>> GetAll()
        {
              var response = new Response<IEnumerable<Customer>>();
              var customers = await _customerService.GetAllAsync();
              response.Data = customers;

              return response; //Ok(response)


          /*  var response = new Response<IEnumerable<Customer>>();
            var lst = new List<DeLaSalle.Invoices.Entities.Customer>();
            var customer = new DeLaSalle.Invoices.Entities.Customer{Id = 1};

            lst.Add(customer);
            response.Data = lst;
            return response;*/

          //  return NotFound();
          //  return lst;

        }
        
    }
