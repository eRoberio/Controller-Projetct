﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models.Entidades.Contexto
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> option)
            : base(option)
        {

            Database.EnsureCreated();

        }

        public DbSet<Agendas> Agendamento { get; set; }

    }
}
