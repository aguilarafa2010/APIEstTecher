﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingModel
{

    [Table("Carros")]
    public class Carro
    {
        [Key]
        [Column("Carro_Id")]
        public int CaroId { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Conferencia { get; set; }
        public Usuario Usuario { get; set; }
    }
}
