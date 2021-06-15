using System;
using System.Data.Entity;

namespace ParqueFerroviarioAlberto.Models
{
    public class ParqueFerroviario:DbContext
    {

        public DbSet<Taller> taller
        {
            get; set;
        }
        public DbSet<Empresa> empresa
        {
            get; set;
        }
        public DbSet<Ciudad> ciudad
        {
            get; set;
        }
        public DbSet<Estado> estado
        {
            get; set;
        }
        public DbSet<Puesto> puesto
        {
            get; set;
        }
        public DbSet<Empleado> empleado
        {
            get; set;
        }
        public DbSet<Proveedor> proveedor
        {
            get; set;
        }
        public DbSet<Compra> compra
        {
            get; set;
        }
        public DbSet<Estacion> estacion
        {
            get; set;
        }
        public DbSet<Tren> tren
        {
            get; set;
        }
        public DbSet<Viaje> viaje
        {
            get; set;
        }
        public DbSet<Ruta> ruta
        {
            get; set;
        }
        public DbSet<Patio> patio
        {
            get; set;
        }
        public DbSet<Vagon> vagon
        {
            get; set;
        }
        public DbSet<Articulo> articulo
        {
            get; set;
        }
        public DbSet<CompraArticulo> compraarticulo
        {
            get; set;
        }
        public DbSet<TrenEmpleado> trenempleado
        {
            get; set;
        }
        


    }
}