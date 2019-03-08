using SoftDelete;
using SoftDelete.DAL;
using SoftDelete.Model;
using SoftDelete.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DbInterception.Add(new LoggingInterceptor());

            //Features.CommandLogger();
            Features.SoftDelete();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
