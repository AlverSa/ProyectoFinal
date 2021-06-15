using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFerroviarioAlberto.Models
{
    [Table("vagon")]
    public class Vagon
    {
        [Key]

        public Int32 idVagon
        {
            get; set;
        }
        public string carga
        {
            get; set;
        }
        public bool estatus
        {
            get; set;
        }
        public Int32 idPatio
        {
            get; set;
        }
        public Int32 idTaller
        {
            get; set;
        }
        public Int32 idTren
        {
            get; set;
        }
    }
}