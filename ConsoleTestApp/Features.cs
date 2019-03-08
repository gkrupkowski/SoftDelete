using SoftDelete.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public static class Features
    {
        public static void CommandLogger()
        {
            using (var db = new ShopContext())
            {
                var customerCount = db.Customers.Count();
            }
        }
        public static void SoftDelete()
        {
            using (var db = new ShopContext())
            {
                var customersCount = db.Customers.Count();

                Console.WriteLine($"Customers count: {customersCount}");

                var customer = db.Customers.First();

                Console.WriteLine($"Removing {customer.Name}");

                db.Customers.Remove(customer);

                db.SaveChanges();

                customersCount = db.Customers.Count();

                Console.WriteLine($"Customers count: {customersCount}");

                customer = db.Customers.First();
                var customerInvoicesCount = customer
                                            .Invoices
                                            .Count;

                Console.WriteLine($"Customer {customer.Name} invoices count: {customerInvoicesCount}");

                var invoice = customer
                                .Invoices
                                .First();

                Console.WriteLine($"Removing customer {customer.Name} invoice nr {invoice.Number}");

                db.Invoices.Remove(invoice);

                db.SaveChanges();

                customerInvoicesCount = customer
                                            .Invoices
                                            .Count;

                Console.WriteLine($"Customer {customer.Name} invoices count: {customerInvoicesCount}");



                Console.WriteLine($"Getting deleted invoice.");
                var deletedInvoice = db
                                        .Invoices
                                        .FirstOrDefault(i => i.IsDeleted);

                Console.WriteLine($"Deleted invoice: {deletedInvoice.Number}");



            }
        }
    }
}
