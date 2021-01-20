using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.Id = 12345;
            customer1.Name = "Dilara";
            customer1.LastName = "Yıldırım";
            customer1.Operator = "Avea";
            customerManager.CustomerAdded(customer1);

            Customer customer2 = new Customer();
            customer2.Id = 23456;
            customer2.Name = "Ali";
            customer2.LastName = "Şimşek";
            customer2.Operator = "Vodafone";
            customerManager.CustomerAdded(customer2);

            Customer customer3 = new Customer();
            customer3.Id = 34567;
            customer3.Name = "Serkan";
            customer3.LastName = "Doğu";
            customer3.Operator = "Turkcell";
            customerManager.CustomerAdded(customer3);

            Customer customer4 = new Customer();
            customer4.Id = 456789;
            customer4.Name = "Aslı";
            customer4.LastName = "Kara";
            customer4.Operator = "BİM CELL";
            customerManager.CustomerAdded(customer4);

            Console.WriteLine("------------------------Tüm Müşteriler----------------------------");
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            customerManager.CustomerList(customers);
            Console.WriteLine("----------------------------------------------------");

            customerManager.CustomerDelete(customer2);
        }
    }
}
