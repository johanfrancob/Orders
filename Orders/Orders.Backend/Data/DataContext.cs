using Orders.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace Orders.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        //Entidades de la base de datos

        public DbSet<Country> Countries { get; set; } //Lo que está entre  <> es el nombre de la tabla en la base de datos, Countries es el apodo de Country
        public DbSet<Category> Categories { get; set; }


        //---------------------------------


        //Condiciones adicionales para las tablas -----------------------
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique(); //Hace que el campo Name sea unico en la tabla Countries
            modelBuilder.Entity<Category>().HasIndex(x => x.Name).IsUnique();

        }

        //----------------------------------------------------------------
    }
}
