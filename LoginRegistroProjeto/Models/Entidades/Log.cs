using LoginRegistroProjeto.Areas.Identity.Data;
using LoginRegistroProjeto.Areas.Identity.Pages.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegistroProjeto.Models.Entidades
{

    [Table("TabLog")]
    public class Log
    {
        public int Id { get; set; }
        public string DetalhesLog { get; set; }
        public AplicativoUsuario DadosUsuario { get; set; }
        public string EmailUsuario{ get; set; }
    }
}
