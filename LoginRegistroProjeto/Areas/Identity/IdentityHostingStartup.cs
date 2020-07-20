using System;
using Agenda.Models.Entidades.Contexto;
using LoginRegistroProjeto.Areas.Identity.Data;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LoginRegistroProjeto.Areas.Identity.IdentityHostingStartup))]
namespace LoginRegistroProjeto.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Contexto>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LoginRegistroContextConnection")));

                services.AddDefaultIdentity<AplicativoUsuario>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<Contexto>();
            });
        }
    }
}