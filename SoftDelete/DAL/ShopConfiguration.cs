using SoftDelete.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDelete.DAL
{
    public class ShopConfiguration : DbConfiguration
    {
        public ShopConfiguration()
        {
            AddInterceptor(new SoftDeleteInterceptor());
        }
    }
}
