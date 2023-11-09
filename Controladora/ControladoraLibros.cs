using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Controladora
{
    public class ControladoraLibros
    {
        private Contexto contexto;
        private static ControladoraLibros instancia;

        private ControladoraLibros()
        {
            contexto = new Contexto();
        }

        public static ControladoraLibros Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraLibros();
                }
                return instancia;
            }
        }

        // ------------------------------------------------------- LISTAR --------------------------------------------------------------
        public IReadOnlyCollection<LibroContable> ListarLibros()
        {
            try
            {
                contexto.Asientos.ToList().ToString();  
                return contexto.LibrosContables.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Asiento> ListarAsientos()
        {
            try
            {
                contexto.Conceptos.ToList().ToString();
                contexto.LibrosContables.ToList().ToString();
                return contexto.Asientos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Concepto> ListarConceptos()
        {
            try
            {
                return contexto.Conceptos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ------------------------------------------------------- AGREGAR/ELIMINAR/MODIFICAR --------------------------------------------------------------
        public string AgregarLibro(LibroContable libro)
        {
            try
            {
                var mismo = contexto.LibrosContables.FirstOrDefault(t => t.MesYear.Month == libro.MesYear.Month && t.MesYear.Year == libro.MesYear.Year);
                if ( mismo != null)
                {
                    return "Error! Ya existe un libro en este mes y año";
                }
                else
                {
                    contexto.LibrosContables.Add(libro);
                    contexto.SaveChanges();
                    return "Agregado correctamente.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido al intentar agregar.";
            }
        }

        public string EliminarLibro(LibroContable libro)
        {
            try
            {
                contexto.LibrosContables.Remove(libro);
                contexto.SaveChanges();
                return $"Eliminado correctamente.";
            }
            catch (Exception)
            {
                return "Error desconocido al intentar eliminar.";
            }
        }

        public string ModificarLibro(LibroContable libro)
        {
            try
            {
                contexto.LibrosContables.Update(libro);
                contexto.SaveChanges();
                return "Modificado correctamente.";
            }
            catch (Exception)
            {
                return $"Error desconocido al intentar modificar.";
            }
        }

        public string AgregarAsiento(Asiento asiento)
        {
            try
            {
                var mismo = contexto.Asientos.FirstOrDefault(t => t.Codigo == asiento.Codigo);
                if (mismo != null)
                {
                    return "Error! Ya existe existe este asiento!";
                }
                else
                {
                    contexto.Asientos.Add(asiento);
                    contexto.SaveChanges();
                    return "Agregado correctamente.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido al intentar agregar.";
            }
        }

        public string EliminarAsiento(Asiento asiento)
        {
            try
            {
                contexto.Asientos.Remove(asiento);
                contexto.SaveChanges();
                return $"Eliminado correctamente.";
            }
            catch (Exception)
            {
                return "Error desconocido al intentar eliminar.";
            }
        }
    }
}