using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdded(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName + " adlı, operatörü " + customer.Operator + " olan müşteri sisteme eklenmiştir.");
            Console.WriteLine("----------------------------------------------------");
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName + " isimli müşterimiz sistemden silinmiştir.");
        }

        public void CustomerList(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("\nMüşteri Id: " + customer.Id + "\nMüşteri Adı: " + customer.Name + "\nMüşteri Soyadı: " + customer.LastName + "\nMüşteri Operatörü: " + customer.Operator);
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
