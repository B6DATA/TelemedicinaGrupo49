using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using AcciTransito.App.Dominio.Entidades;

namespace AcciTransito.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Accidente> Accidente {get;set;}
        public DbSet<AgenteTransito> AgenteTransito {get;set;}
        public DbSet<Personas> Personas {get;set;}
        public DbSet<Genero> Genero {get;set;}
        public DbSet<Coordenadas> Coordenadas {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)    
    {
        if (!optionsBuilder.IsConfigured)
         {
            
         optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AccidentesTransito");
         }
    }
    }
   
}