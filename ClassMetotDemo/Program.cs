using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args) 
        {
            Customer customer1 = new Customer(); 
            customer1.CustomerId = 1;
            customer1.CustomerName = "Ömer";
            customer1.CustomerSurname = "Arslan";
            customer1.CustomerAge = 18;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Arif";
            customer2.CustomerSurname = "Kayhan";
            customer2.CustomerAge = 20;

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Yiğit";
            customer3.CustomerSurname = "Akbulut";
            customer3.CustomerAge = 25;

            Customer[] customers = new Customer[] {customer1,customer2,customer3};

            Console.WriteLine("Halkbank'ta maaş hesabı olanlar : ");
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.CustomerName + " " + c.CustomerSurname);
            }
            

            CustomerManager customer = new CustomerManager();
            customer.AddCustomer(customer1);
            customer.DeleteCustomer(customer2);

        }
    }
}