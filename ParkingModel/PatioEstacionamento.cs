using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParkingModel
{
    public class PatioEstacionamento
    {
        [Key]
        [Column("EntradaId")]
        public Guid Entrada { get; set; }
        public string Placa { get; set; }
        public int Vaga { get; set; }
        public bool Excluido { get; set; }
        public double ValorFinal { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public DateTime Duracao { get; set; }
        public bool Mensalista { get; set; }

        //public string InformacoesJson
        //{
        //    get
        //    {
        //        if (this.Info == null)
        //            return null;

        //        return JsonConvert.SerializeObject(Info);
        //    }
        //    set
        //    {
        //        this.Info.Clear();

        //        if (value != null)
        //        {
        //            var tmp = JsonConvert.DeserializeObject<List<Informacoes>>(value);
        //            this.Info.AddRange(tmp);
        //        }
        //    }
        //}

        //public List<Informacoes> Info { get; set; }


        //public class Informacoes
        //{
        //    [Key]
        //    public int DanosId { get; set; }
        //    public string Danos { get; set; }
        //}
    }
        

    
}
