using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("compra")]
    public class Compra
    {
        [Key]

        public Int32 idCompra
        {
            get; set;
        }
        public string nombreDeCompra
        {
            get; set;
        }
        public string codigo
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
        public Int32 idProveedor
        {
            get; set;
        }
    }
}