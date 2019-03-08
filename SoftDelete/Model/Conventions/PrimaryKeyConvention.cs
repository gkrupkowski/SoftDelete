using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.Model.Conventions
{

        public class PrimaryKeyConvention : Convention
        {
            public PrimaryKeyConvention()
            {
                Properties<int>()
                .Where(prop => prop.Name.EndsWith("Identification"))
                .Configure(config => config.IsKey());
            }
        }
    
}
