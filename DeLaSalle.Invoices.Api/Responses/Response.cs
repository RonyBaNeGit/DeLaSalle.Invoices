using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DeLaSalle.Invoices.Api.Responses;

    public class Response<T>
    {
        public T Data {get;set;}
        public List<string> Errors {get;set;} = new List<string>();

        public string Message{get;set;}
    }
