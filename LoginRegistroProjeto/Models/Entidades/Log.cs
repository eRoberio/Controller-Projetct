using LoginRegistroProjeto.Areas.Identity.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistroProjeto.Models.Entidades
{

    [Table("TabLog")]
    public class Log
    {
        public int Id { get; set; }
        public string DetalhesLog { get; set; }
        public string EmailUsuario { get; set; }

        public IEnumerable<AplicativoUsuario> DadosUsuario { get; set; }
    }
}
