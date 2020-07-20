using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models.Entidades
{

    [Table("AGD")]
    public class Agendas
    {

        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Título")]
        public string title { get; set; }
        [Display(Name = "Descricao")]
        public string descricao { get; set; }
        [Display(Name = "Tipo")]
        public string tipo { get; set; }

    }
}
