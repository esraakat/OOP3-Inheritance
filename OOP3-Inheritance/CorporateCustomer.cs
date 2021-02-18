using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Inheritance
{
    class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
//A corporate customer is also a customer
//features for only a corporate customer
//legal entity