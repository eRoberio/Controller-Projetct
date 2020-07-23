using LoginRegistroProjeto.Areas.Identity.Data;
using LoginRegistroProjeto.Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models.Entidades
{

    [Table("TabEventos")]
    public class Eventos
    {

        public int Id { get; set; }
        public string tipo { get; set; } 
        public string nome { get; set; }
        public string descricao { get; set; }
        public string local { get; set; }
        public string status { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataEvento { get; set; }

        public string UserCreateId { get; set; }

        public AplicativoUsuario UserCreate { get; set; }

        public ICollection<EventoUsuario> EventoUsuarios { get; set; }



    }






}
