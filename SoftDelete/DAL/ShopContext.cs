using SoftDelete.Model;
using SoftDelete.Model.Conventions;
using SoftDelete.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.DAL
{
    public class ShopContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<TableWithoutId> Tables { get; set; }

        public ShopContext()
        {
            Database.SetInitializer<ShopContext>(new ShopInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<MaxLengthAttributeConvention>();
            modelBuilder.Properties<string>().
                    Configure(s => s.HasMaxLength(50));
            modelBuilder.Conventions.Add<PrimaryKeyConvention>();
            modelBuilder.Conventions.Add<HideColumnNameConvention>();


            var conv = new AttributeToTableAnnotationConvention<SoftDeleteAttribute, string>(
               "SoftDeleteColumnName",
               (type, attributes) => attributes.Single().ColumnName);

            modelBuilder.Conventions.Add(conv);
        }
    }
}
