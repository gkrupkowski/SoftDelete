using SoftDelete.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.Model
{
    [SoftDelete("IsDeleted")]
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
