using Microsoft.EntityFrameworkCore;
using S5_DPA_EFCore.DatabaseFirst.Models;
using System;
using System.Linq;

namespace S5_DPA_EFCore.DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var data = new SalesDBContext();
            //var customer1 = new Customer()
            //{
            //    FirstName = "Carlos",
            //    LastName = "Tevez",
            //    Country = "ARGENTINA",
            //    City ="Buenos Aires",
            //    Phone = "99828872762"
            //};

            //data.Customer.Add(customer1);
            //data.SaveChanges();
            //data.Customer.AddRange(List<Customer>);
            //data.SaveChanges();

            //Query by LINQ

            //var search = (from c in data.Customer
            //              where c.Country == "USA"
            //              select c).ToList();

            //Query Lambda Expressions

            //var search = data.Customer.Where(options => options.Country == "USA").ToList();

            //Console.WriteLine("# Customers: " + search.Count());
            //foreach (var item in search)
            //{
            //    Console.WriteLine("Full Name: " + item.FirstName + " " + item.LastName + " City: " + item.City);
            //}

            //var search = (from c in data.Customer
            //              where c.Id == 70
            //              select c).FirstOrDefault();

            //var search = data.Customer.Include(z=>z.Order).Where(x => x.Id == 70).FirstOrDefault();

            //Console.WriteLine("Customer is: " + search.LastName + " Country: " + search.Country+ " #Orders: " + search.Order.Count());
            //Update
            var search = data.Customer.Where(x => x.Id == 96).FirstOrDefault();
            //search.FirstName = "Carlitos";
            //data.SaveChanges();

            //Delete
            data.Customer.Remove(search);
            data.SaveChanges();


        }
    }
}
