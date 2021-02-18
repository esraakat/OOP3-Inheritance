using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Inheritance
{
    class IndividualCustomer : Customer
    {
        public string TcNo  { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
//An individual customer is also a customer
//for featuress only an individual customer
