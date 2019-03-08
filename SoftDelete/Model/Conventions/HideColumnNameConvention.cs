using SoftDelete.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.Model.Conventions
{
    public class HideColumnNameConvention : Convention
    {
        public HideColumnNameConvention()
        {
            Properties<string>().Having(p =>
            p.GetCustomAttributes(false).OfType
               <HideColumnNameAttribute>()).Configure((c, a) =>
               {
                   if (a.Any())
                   {
                       c.HasColumnName("Hidden");
                   }
               });
        }
    }
}
