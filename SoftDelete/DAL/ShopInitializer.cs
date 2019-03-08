using SoftDelete.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var customer = new Customer
            {
                Name = "Klient1"
            };



            var customer1Invoices = new List<Invoice>
            {
                new Invoice
                {
                    InvoiceDate = DateTime.Now,
                    Number = "1",
                    SaleDate = DateTime.Now
                },
                new Invoice
                {
                    InvoiceDate = DateTime.Now,
                    Number = "2",
                    SaleDate = DateTime.Now
                },
                new Invoice
                {
                    InvoiceDate = DateTime.Now,
                    Number = "3",
                    SaleDate = DateTime.Now
                },
                new Invoice
                {
                    InvoiceDate = DateTime.Now,
                    Number = "4",
                    SaleDate = DateTime.Now
                },
                new Invoice
                {
                    InvoiceDate = DateTime.Now,
                    Number = "5",
                    SaleDate = DateTime.Now
                },
            };

            customer.Invoices = customer1Invoices;

            context.Customers.Add(customer);

            var customer2 = new Customer
            {
                Name = "Klient2"
            };



            var customer2Invoices = new List<Invoice>
            {
                new Invoice
                {
                    InvoiceDate = DateTime.Now,
                    Number = "6",
                    SaleDate = DateTime.Now
                },
                new Invoice
                {
                    InvoiceDate = DateTime.Now,
                    Number = "7",
                    SaleDate = DateTime.Now
                }
            };

            customer2.Invoices = customer2Invoices;

            context.Customers.Add(customer2);


            context.SaveChanges();

           

        }
    }
}
