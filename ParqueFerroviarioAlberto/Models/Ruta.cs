using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("ruta")]
    public class Ruta
    {
        [Key]

        public Int32 idRuta
        {
            get; set;
        }
        public string rutaTren
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