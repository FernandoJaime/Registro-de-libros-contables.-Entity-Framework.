using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<LibroContable> LibrosContables { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Concepto> Conceptos { get; set; }

        // Conexion a la base de datos.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB;initial catalog=Parcial2;integrated security = true;").EnableSensitiveDataLogging();
        }

        // Configuracion de las tablas.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuracion de la tabla Asientos.
            modelBuilder.Entity<Asiento>().ToTable("Asientos");
            modelBuilder.Entity<Asiento>().HasKey(a => a.AsientoId);
            modelBuilder.Entity<Asiento>().HasIndex(a => a.Codigo).IsUnique();
            modelBuilder.Entity<Asiento>().Property(a => a.Fecha).IsRequired();
            modelBuilder.Entity<Asiento>().Property(a => a.Monto).IsRequired();
            modelBuilder.Entity<Asiento>().Property(a => a.TipoAsiento).IsRequired();

            // Configuracion de la tabla LibrosContables.
            modelBuilder.Entity<LibroContable>().ToTable("LibrosContables");
            modelBuilder.Entity<LibroContable>().HasKey(l => l.LibroContableId);
            modelBuilder.Entity<LibroContable>().HasIndex(l => l.MesYear).IsUnique();
            modelBuilder.Entity<LibroContable>().Property(l => l.CapitalActual).IsRequired();

            // Configuracion de la tabla Conceptos.
            modelBuilder.Entity<Concepto>().ToTable("Conceptos");
            modelBuilder.Entity<Concepto>().HasKey(c => c.ConceptoId);
            modelBuilder.Entity<Concepto>().HasIndex(c => c.Nombre).IsUnique();
            modelBuilder.Entity<Concepto>().Property(c => c.Descripcion).IsRequired();

            // Incerto datos en la tabla Concepto.
            var Concepto1 = new Concepto { ConceptoId = 1, Nombre = "Compra de insumos", Descripcion = "Compra de insumos para la elaboracion de los platos" };
            var Concepto2 = new Concepto { ConceptoId = 2, Nombre = "Venta de insumos", Descripcion = "Venta de insumos para la elaboracion de los platos" };
            var Concepto3 = new Concepto { ConceptoId = 3, Nombre = "Depreciación de activos fijos", Descripcion = "" };
            var Concepto4 = new Concepto { ConceptoId = 4, Nombre = "Pago de intereses", Descripcion = "" };
            var Concepto5 = new Concepto { ConceptoId = 5, Nombre = "Venta de productos terminados", Descripcion = ""};
            modelBuilder.Entity<Concepto>().HasData(Concepto1, Concepto2, Concepto3, Concepto4, Concepto5);

            // Incerto datos en la tabla LibrosContables.
            var LibroContable1 = new LibroContable { LibroContableId = 1, MesYear = new System.DateTime(2021, 9, 11), CapitalActual = 10000 };
            modelBuilder.Entity<LibroContable>().HasData(LibroContable1);

            // Incerto datos en la tabla Asientos.
            var Asiento1 = new Asiento { AsientoId = 1, Codigo = 0001, Fecha = new System.DateTime(2021, 9, 11), ConceptoId = 1, Monto = 1000, TipoAsiento = Asiento.Tipo.Debe, LibroContableId = 1 };
            var Asiento2 = new Asiento { AsientoId = 2, Codigo = 0002, Fecha = new System.DateTime(2021, 9, 11), ConceptoId = 2, Monto = 2000, TipoAsiento = Asiento.Tipo.Haber, LibroContableId = 1 };
            modelBuilder.Entity<Asiento>().HasData(Asiento1, Asiento2);

            // Establece la relación entre Asientos y LibroContable después de insertar los datos.
            modelBuilder.Entity<Asiento>().HasOne(a => a.LibroContable).WithMany(l => l.Asientos).HasForeignKey(a => a.LibroContableId);
        }
    }
}