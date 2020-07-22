using LoginRegistroProjeto.Areas.Identity.Data;
using LoginRegistroProjeto.Models.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models.Entidades.Contexto
{
    public class Contexto : IdentityDbContext<AplicativoUsuario>
    {

        public Contexto(DbContextOptions<Contexto> option)
            : base(option)
        {

            Database.EnsureCreated();

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }

        public DbSet<Eventos> Agendamento { get; set; }

        public DbSet<AplicativoUsuario> Register{ get; set; }

        public DbSet<Log> Log { get; set; }

        public DbSet<MinhaAgenda> MinhaAgenda { get; set; }




    }
}

