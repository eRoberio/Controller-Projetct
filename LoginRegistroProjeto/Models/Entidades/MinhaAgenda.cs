using LoginRegistroProjeto.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistroProjeto.Models.Entidades
{


    [Table("TabMinhaAgenda")]
    public class MinhaAgenda
    {


        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public string Status { get; set; }


        public Log Log { get; set; }
        public AplicativoUsuario DadosUsuario { get; set; }
        [Display(Name ="Data do Evento")]
        public DateTime DataEvento { get; set; }



    }
}
