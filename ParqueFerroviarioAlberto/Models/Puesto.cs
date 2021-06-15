using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("puesto")]
    public class Puesto
    {
        [Key]

        public Int32 idPuesto
        {
            get; set;
        }
        public string nombreDePuesto
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
        
    }
}