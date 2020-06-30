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
        public int Inf_Id { get; set; }
        public string Informacoes { get; set; }
        [ForeignKey(nameof(Patio))]
        public int Patio_Id { get; set; }
        public Patio Patio { get; set; }
    }
}
