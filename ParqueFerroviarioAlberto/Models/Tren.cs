using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("tren")]
    public class Tren
    {
        [Key]

        public Int32 idTren
        {
            get; set;
        }
        public string numero
        {
            get; set;
        }
        public string destino
        {
            get; set;
        }
        public string diesel
        {
            get; set;
        }
        public string fabricado
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
        public Int32 idEstacion
        {
            get; set;
        }
    }
}