using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        [DataType(DataType.Date)]
        [Display(Name ="Data do Evento")]
        public DateTime DataEvento { get; set; }


    }
}
