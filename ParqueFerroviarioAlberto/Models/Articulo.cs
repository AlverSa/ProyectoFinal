using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("articulo")]
    public class Articulo
    {
        [Key]

        public Int32 idArticulo
        {
            get; set;
        }
        public string nombre
        {
            get; set;
        }
        public string codigo
        {
            get; set;
        }
        public decimal precio
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
        
    }
}