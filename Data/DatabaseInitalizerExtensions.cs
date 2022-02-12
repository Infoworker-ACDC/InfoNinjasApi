using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace InfoNinjasApi.Data
{
    public static class DatabaseInitalizerExtensions
    {
        public static void EnsureStandardDatabaseInitialized(this IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                var service = serviceScope.ServiceProvider;

                try
                {
                    var context = service.GetRequiredService<ApiContext>();
                    DbInitializer.InitializeStandard(context);
                }
                catch (Exception ex)
                {

                }
            }

        }
    }
}
