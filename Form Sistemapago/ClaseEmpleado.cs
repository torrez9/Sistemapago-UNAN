using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Sistemapago
{
    public class ClaseEmpleado
    {
        // Encapsulamiento de tipo protected, los atributos nombre, cedula, tipoempleado
        // solo pueden ser accedidos desde la propia clase o clases que hereden de esta
        protected string nombre, cedula, tipoempleado;

        private int antig, extras;
        private double salario;
        private string codigo;

        // Propiedades para cada atributo
        public string Nombre { get; set; }
        public string Tipoempleado { get; set; }
        public string Cedula { get; set; }
        public int Antig { get; set; }
        public int Extras { get; set; }
        public double Salario { get; set; }
        public string Codigo { get; set; }

        // Método constructor
        public ClaseEmpleado(string NomEmpl, string TipoEmpl, string CedEmpl, double SalarioEmpl, int ExtrasEmpl, int AntigEmpl)
        {
            Nombre = NomEmpl;
            Tipoempleado = TipoEmpl;
            Cedula = CedEmpl;
            Antig = AntigEmpl;
            Extras = ExtrasEmpl;
            Salario = SalarioEmpl;
        }

        // MÉTODOS PARA APLICAR POLIMORFISMO
        // La palabra virtual indica que este método de la clase padre
        // será sobrescrito en las clases hijas (POLIMORFISMO)
        public virtual string GenerarCodigo()
        {
            string Codigo = "EMP" + this.nombre.Substring(0, 3) + this.cedula.Substring(0, 3);
            return Codigo;
        }

        // Este método puede sobrescribirse en las clases hijas, pero utilizando New
        public string RecibirMateriales()
        {
            return "Lapiceros, Resma de papel, Limpiador de interiores, cepillo, esponja, toalla, Marcadores, Borrador, Cuaderno";
        }
    }
}
