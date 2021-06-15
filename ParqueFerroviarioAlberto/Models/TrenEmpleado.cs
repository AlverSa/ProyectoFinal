using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("trenempleado")]
    public class TrenEmpleado
    {
        [Key]

        public Int32 idTrenEmpleado
        {
            get; set;
        }
        public Int32 idTren
        {
            get; set;
        }
        public Int32 idEmpleado
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
    }
}