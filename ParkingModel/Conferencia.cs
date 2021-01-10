using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParkingModel
{
    public class Conferencia
    {
        public int Inf_Id { get; set; }
        public string Informacoes { get; set; }
        public int Patio_Id { get; set; }
        public Patio Patio { get; set; }
    }
}
