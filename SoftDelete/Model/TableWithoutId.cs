using SoftDelete.Model.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.Model
{
    public class TableWithoutId
    {
        public int TableIdentification { get; set; }

        [MaxLength(100)]
        public string TestString { get; set; }

        [HideColumnName]
        public string SuperDuperColumnName { get; set; }
    }
}
