using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParkingModel
{
    public class Conferencia
    {
        [Key]
        public int Inf { get; set; }
        public string Informacoes { get; set; }
        [ForeignKey(nameof(Carro))]
        public Guid CarroId { get; set; }
        public Carro Carro { get; set; }
    }
}
