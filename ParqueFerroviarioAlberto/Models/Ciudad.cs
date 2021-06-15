using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("ciudad")]
    public class Ciudad
    {
        [Key]

        public Int32 idCiudad
        {
            get; set;
        }
        public string ubicacion
        {
            get; set;
        }
        public string codigoPostal
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