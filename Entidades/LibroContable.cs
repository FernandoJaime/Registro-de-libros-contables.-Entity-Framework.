using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroContable
    {
        public int LibroContableId { get; set; }
        public DateTime MesYear { get; set; }
        public int CapitalActual { get; set; }

        public List<Asiento> Asientos { get; set; } = new List<Asiento>();

        public override string ToString()
        {
            return $"date: {MesYear}, capital: {CapitalActual}";
        }
        public void AgregarAsiento(Asiento asiento)
        {
            try
            {
                if (asiento.TipoAsiento == Asiento.Tipo.Debe)
                {
                    asiento.LibroContable.CapitalActual += asiento.Monto;
                }
                else if (asiento.TipoAsiento == Asiento.Tipo.Haber)
                {
                    asiento.LibroContable.CapitalActual -= asiento.Monto;
                }
                Asientos.Add(asiento);
            }
            catch (Exception e)
            {
                throw new Exception("Error al agregar asiento", e);
            }
        }

        public void EliminarAsiento(Asiento asiento)
        {
            try
            {
                if (asiento.TipoAsiento == Asiento.Tipo.Debe)
                {
                    asiento.LibroContable.CapitalActual -= asiento.Monto;
                }
                else if (asiento.TipoAsiento == Asiento.Tipo.Haber)
                {
                    asiento.LibroContable.CapitalActual += asiento.Monto;
                }
                Asientos.Remove(asiento);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar asiento", e);
            }
        }
    }
}