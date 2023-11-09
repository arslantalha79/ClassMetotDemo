using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " maaş hesabı eklendi!");
            Console.WriteLine("Müşterinin yaşı : " + customer.CustomerAge);
            Console.WriteLine("---------------------------");
        }

        public void DeleteCustomer(Customer customer) 
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + "'nın maaş hesabı kapatıldı!!!");
            Console.WriteLine("---------------------------");
        }
    }
}
