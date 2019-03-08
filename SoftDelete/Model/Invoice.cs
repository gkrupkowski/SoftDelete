using SoftDelete.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.Model
{
    [SoftDelete("IsDeleted")]
    public class Invoice
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime InvoiceDate { get; set; }

        public DateTime SaleDate { get; set; }

        public bool IsDeleted { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
