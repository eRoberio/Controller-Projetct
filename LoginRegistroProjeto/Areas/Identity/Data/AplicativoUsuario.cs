using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LoginRegistroProjeto.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AplicativoUsuario class
    public class AplicativoUsuario : IdentityUser
    {

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string nome { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(10)")]
        public string sexo { get; set; }

    }
}
