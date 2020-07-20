using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserConnection.Models
{
    public class AplicativoUser: IdentityUser
    {
        public string nome { get; set; }
        public string endereco_completo { get; set; }
        public string sexo{ get; set; }
        public string data_nascimento{ get; set; }
    }
}
