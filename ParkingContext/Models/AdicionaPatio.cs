using System;
using System.Collections.Generic;
using System.Text;
using static ParkingModel.PatioEstacionamento;

namespace ParkingContext.Models
{
    public class AdicionaPatio
    {
        public string Placa { get; set; }
        public int Vaga { get; set; }
        public bool Mensalista { get; set; }
        //public List<Informacoes> Informacoes { get; set; }

    }
}
