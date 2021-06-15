using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("empleado")]
    public class Empleado
    {
        [Key]

        public Int32 idEmpleado
        {
            get; set;
        }
        public string nombre
        {
            get; set;
        }
        public string apellidoPaterno
        {
            get; set;
        }
        public string apellidoMaterno
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
        public Int32 idPuesto
        {
            get; set;
        }
        public Int32 idEmpresa
        {
            get; set;
        }
    }
}