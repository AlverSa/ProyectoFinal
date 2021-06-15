using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("viaje")]
    public class Viaje
    {
        [Key]

        public Int32 idViaje
        {
            get; set;
        }
        public string origen
        {
            get; set;
        }
        public string destino
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
        public Int32 idTren
        {
            get; set;
        }
    }
}