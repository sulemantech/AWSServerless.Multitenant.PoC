using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitenant.Infrastructure
{
    public static class ServicesExtensions
    {
        public static void AddMyLibraryServices(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration config)
        {
            // register your services here
        }
    }
}
