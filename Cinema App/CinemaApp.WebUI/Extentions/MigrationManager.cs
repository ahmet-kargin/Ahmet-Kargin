using CinemaApp.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.WebUI.Extentions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var miniShopContext = scope.ServiceProvider.GetRequiredService<FilmAppContext>())
                {
                    try
                    {
                        miniShopContext.Database.Migrate();
                    }
                    catch (Exception)
                    {

                        throw;
                    };
                }
            }
            return host;
        }
    }
    
}
