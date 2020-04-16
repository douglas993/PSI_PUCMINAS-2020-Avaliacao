using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PUC.LDSI.Identity.Context;
using PUC.LDSI.Identity.Entities;

[assembly: HostingStartup(typeof(PUC.LDSI.MVC.Areas.Identity.IdentityHostingStartup))]
namespace PUC.LDSI.MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

                services.AddDbContext<SecurityContext>(
                    opc => opc.UseSqlServer(context.Configuration.GetConnectionString("ConexaoIdentity"),
                    pjr => pjr.MigrationsAssembly("PUC.LDSI.Identity")));

                services.AddDefaultIdentity<Usuario>().AddEntityFrameworkStores<SecurityContext>();

                services.Configure<IdentityOptions>(opitions =>
               {
                   opitions.Password.RequireDigit = false;
                   opitions.Password.RequireLowercase = false;
                   opitions.Password.RequireNonAlphanumeric = false;
                   opitions.Password.RequireUppercase = false;
                   opitions.Password.RequiredLength = 6;
                   opitions.Password.RequiredUniqueChars = 0;
               });

            });
        }
    }
}