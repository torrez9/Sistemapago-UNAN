using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Sistemapago
{
    class SubClaseProfesor : ClaseEmpleado
    {
        private string titulo;
        private string tipocontrato;
        private string departamento;

        public string Titulo { get; set; }
        public string TipoContrato { get; set; }
        public string Departamento { get; set; }

        // Método constructor para la subclase profesor
        public SubClaseProfesor(string NomProf, string TipoEmplProf, string CedProf, double SalarioProf,
                                int ExtrasProf, int AntigProf, string TituloProf, string TipoContProf, string DepartProf)
            : base(NomProf, TipoEmplProf, CedProf, SalarioProf, ExtrasProf, AntigProf)
        {
            Titulo = TituloProf; // Se asigna los parámetros a los atributos correspondientes
            TipoContrato = TipoContProf;
            Departamento = DepartProf;
        }

        // MÉTODOS PARA APLICAR POLIMORFISMO ESTÁTICO

        // Método 1: sobrescrito utilizando new de la super clase Empleado
        public new string RecibirMateriales()
        {
            return "Marcadores, Borrador, Lapices, Cuaderno";
        }

        // Método 2: utilizando la palabra override para indicar que este método es sobrescrito (POLIMORFISMO)
        // * Recordar que para poder utilizar override en la clase padre el método debe
        // * tener la palabra virtual/
        public override string GenerarCodigo()
        {
            Codigo = "PROF" + Titulo.Substring(0, 3) + Nombre.Substring(0, 3);
            return Codigo;
        }
    }
}
