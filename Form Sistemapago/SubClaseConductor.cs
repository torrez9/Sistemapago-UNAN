using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Sistemapago
{
    public class SubClaseConductor : ClaseEmpleado
    {
        private string tipoLicencia;

        public string TipoLicencia { get; set; }

        public SubClaseConductor(string NomCond, string TipoEmplCond, string CedCond, double SalarioCond,
                                int ExtrasCond, int AntigCond, string LicenciaConductor)
            : base(NomCond, TipoEmplCond, CedCond, SalarioCond, ExtrasCond, AntigCond)
        {
            TipoLicencia = LicenciaConductor;
        }

        // MÉTODOS PARA APLICAR POLIMORFISMO ESTÁTICO

        // Método 1: sobrescrito utilizando new de la super clase Empleado
        public new string RecibirMateriales()
        {
            return "Limpiador de interiores, cepillo, esponja, toalla";
        }

        // Método 2: utilizando la palabra override para indicar que este método es sobrescrito (POLIMORFISMO)
        // * Recordar que para poder utilizar override en la clase padre el método debe
        // * tener la palabra virtual/
        public override string GenerarCodigo()
        {
            Codigo = "COND" + Nombre.Substring(0, 3) + tipoLicencia;
            return Codigo;
        }
    }
}
