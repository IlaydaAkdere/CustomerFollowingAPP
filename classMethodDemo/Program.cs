using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new customer1();
            Customer Id1 = 14875968342;
            Customer Name1 = "Ilayda";
            Customer Surname1 = "Akdere";
            Customer Age1 = 30;
            Customer AccountNo1 = 8579;
            Customer SpendingMoney1 = 200;
            Customer RemaindMoney1 = 800;

            Customer customer2 = new customer2();
            Customer Id2 = 114859673258;
            Customer Name2 = "Emine";
            Customer Surname2 = "Mete";
            Customer Age2 = 32;
            Customer AccountNo2 = 7859;
            Customer SpendingMoney2 = 1526;
            Customer RemaindMoney2 = 456;

            Customer customer3 = new customer3();
            Customer Id = 25968374168;
            Customer Name3 = "Ozan";
            Customer Surnsme3 = "Yıldırım";
            Customer Age3 = 26;
            Customer AccountNo3 = 5963;
            Customer SpendingMoney = 14.265;
            Customer RemaindMoney = 10.200;
        }
        Customer[] customers = new Customer[] { customer1, customer2, customer3, };

        foreach (var customer in customers)
        {
            Console.WriteLine(Customer.Name + " " + Customer.Surname+ " " +Customer.AccountNo);
        }
    Console.WriteLine(" ");

        CustomerManager customerManager = new CustomerManager();

    CustomerManager.Add(customer1);
        Console.WriteLine(" ");
        CustomerManager.Add(customer2);
        Console.WriteLine(" ");
        CustomerManager.Add(customer3);
        Console.WriteLine(" ");
        CustomerManager.Add(customer4);
        Console.WriteLine("----------------------------");
        CustomerManager.Delete(customer1);
        Console.WriteLine(" ");
        CustomerManager.Delete(customer2);
        Console.WriteLine(" ");
        CustomerManager.Delete(customer3);
        Console.WriteLine(" ");
        CustomerManager.Delete(customer4);
        CustomerManager.Show();
    }
}
