using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingModel
{
    public class Carro
    {
        [Key]
        public Guid CarroId { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public Usuario Usuario { get; set; }
        public Conferencia Conferencia { get; set; }
    }
}
