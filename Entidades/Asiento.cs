namespace Entidades
{
    public class Asiento
    {
        public int AsientoId { get; set; }
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public Concepto Concepto { get; set; }
        public int ConceptoId { get; set; }
        public int Monto { get; set; }
        public enum Tipo
        {
            Debe,
            Haber
        };
        public Tipo TipoAsiento { get; set; }

        public LibroContable LibroContable { get; set; }
        public int LibroContableId { get; set; }

        public override string ToString()
        {
            return $"{TipoAsiento}, date: {Fecha}";
        }
    }
}