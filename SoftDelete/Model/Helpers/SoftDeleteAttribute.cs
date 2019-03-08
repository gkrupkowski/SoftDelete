using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.Model.Helpers
{
    public class SoftDeleteAttribute : Attribute
    {
        public SoftDeleteAttribute(string column)
        {
            ColumnName = column;
        }

        public string ColumnName { get; set; }

        public static string GetSoftDeleteColumnName(EdmType type)
        {
            MetadataProperty annotation = type.MetadataProperties
                .Where(p => p.Name.EndsWith("customannotation:SoftDeleteColumnName"))
                .SingleOrDefault();

            return annotation == null ? null : (string)annotation.Value;
        }
    }
}
