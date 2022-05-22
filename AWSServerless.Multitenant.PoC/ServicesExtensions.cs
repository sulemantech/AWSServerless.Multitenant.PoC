using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSServerless.Multitenant.PoC
{
    public static class ServicesExtensions
    {
        public static void AddMyLibraryServices(this IServiceCollection services, IConfiguration config)
        {
            // register your services here
        }
    }
}
