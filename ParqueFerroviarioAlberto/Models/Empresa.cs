using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("empresa")]
    public class Empresa
    {
        [Key]

        public Int32 idEmpresa
        {
            get; set;
        }
        public string nombre
        {
            get; set;
        }
        public string codigoPostal
        {
            get; set;
        }
        public string telefono
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