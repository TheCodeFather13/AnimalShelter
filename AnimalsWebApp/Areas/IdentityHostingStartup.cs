using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AnimalsWebApp.Data;

[assembly: HostingStartup(typeof(AnimalsWebApp.Areas.Identity.IdentityHostingStartup))]
namespace AnimalsWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AnimalsWebAppContext>(options =>
                options.UseSqlServer(context.Configuration.GetConnectionString("AccountDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AnimalsWebAppContext>();
            });
        }
    }
}