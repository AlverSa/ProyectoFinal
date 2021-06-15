using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("estado")]
    public class Estado
    {
        [Key]

        public Int32 idEstado
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
        public Int32 idCiudad
        {
            get; set;
        }
    }
}