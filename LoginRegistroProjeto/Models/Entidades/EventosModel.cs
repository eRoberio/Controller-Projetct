using System;
using System.ComponentModel.DataAnnotations;

namespace LoginRegistroProjeto.Models.Entidades
{
    public class EventosModel
    {

        public int Id { get; set; }
        public string tipo { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string local { get; set; }
        public string status { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataEvento { get; set; }
        public string Email { get; set; }
        public int QtdInscritos { get; set; }
        public bool PermitirInscricao { get; set; }

    }
}
