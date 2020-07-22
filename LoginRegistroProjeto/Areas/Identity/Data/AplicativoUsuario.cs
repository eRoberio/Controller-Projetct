using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Agenda.Models.Entidades;
using LoginRegistroProjeto.Models.Entidades;
using Microsoft.AspNetCore.Identity;

namespace LoginRegistroProjeto.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AplicativoUsuario class

    [Table("TabUsuarios")]
    public class AplicativoUsuario : IdentityUser
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public DateTime dataNascimento { get; set; }

        [ForeignKey("TabEventos")]
        public int ID_EVENTO { get; set; }

        public virtual Eventos Eventos { get; set; }




    }
}
