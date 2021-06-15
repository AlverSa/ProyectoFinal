using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("estacion")]
    public class Estacion
    {
        [Key]

        public Int32 idEstacion
        {
            get; set;
        }
        public string salida
        {
            get; set;
        }
        public string llegada
        {
            get; set;
        }
        public string telefono
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
        public Int32 idEmpresa
        {
            get; set;
        }
        
    }
}