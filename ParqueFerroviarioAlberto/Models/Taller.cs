using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("taller")]
    public class Taller
    {
        [Key]

        public Int32 idTaller
        {
            get; set;
        }
        public string ubicacion
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
    }
}