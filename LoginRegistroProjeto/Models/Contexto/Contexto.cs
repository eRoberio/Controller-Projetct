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


        public DbSet<Eventos> Eventos { get; set; }

        public DbSet<AplicativoUsuario> AplicativoUsuarios { get; set; }

        public DbSet<EventoUsuario> EventoUsuarios { get; set; }


        public DbSet<Log> Log { get; set; }

        public DbSet<MinhaAgenda> MinhaAgendas { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EventoUsuario>().HasKey(ea => new { ea.EventoUsuarioId });


            builder.Entity<Eventos>(entidade =>
            {
                entidade.Property(e => e.nome)
                      .IsRequired()
                     .HasMaxLength(400);


            });
        }





    }
}

