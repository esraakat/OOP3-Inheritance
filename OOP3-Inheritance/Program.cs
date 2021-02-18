using System;

namespace OOP3_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Esra";
            customer1.CustomerSurname = "Akat";
            customer1.TcNo = "12345678910";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            customer3.Id = 3;
            customer3.CustomerNumber = "23456";
                      
            Customer customer4 = new CorporateCustomer(); //If you see "new" keyword, read it as reference number.
            customer4.Id = 4;
            customer4.CustomerNumber = "65432";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
                
        }
    }
}
