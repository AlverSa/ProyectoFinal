using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("compraarticulo")]
    public class CompraArticulo
    {
        [Key]

        public Int32 idCompraArticulo
        {
            get; set;
        }
        public Int32 idCompra
        {
            get; set;
        }
        public Int32 idArticulo
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
    }
}