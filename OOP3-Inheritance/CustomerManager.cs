using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Inheritance
{
    class CustomerManager
    {
        public void Add(Customer customer)//polimorfizm  çok biçimlilik
        {
            Console.WriteLine(customer.Id + " was added!");
        }
    }
}
