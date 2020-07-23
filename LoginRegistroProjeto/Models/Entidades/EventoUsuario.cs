using Agenda.Models.Entidades;
using LoginRegistroProjeto.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegistroProjeto.Models.Entidades
{
    public class EventoUsuario
    {

        public int EventoUsuarioId { get; set; }

        public int EventoId { get; set; }

        public Eventos Evento { get; set; }


        public string UserId { get; set; }

        public AplicativoUsuario Usuario { get; set; }





    }
}
