using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Sistemapago
{
    class SubClaseAdmin : ClaseEmpleado
    {
        private string cargo;
        public string Cargo { get; set; }
        public SubClaseAdmin(string NomAdmin, string TipoEmplAdmin, string CedAdmin, double SalarioAdmin,
                                    int ExtrasAdmin, int AntigAdmin, string CargoAdmin)
            : base(NomAdmin, TipoEmplAdmin, CedAdmin, SalarioAdmin, ExtrasAdmin, AntigAdmin)
        {
            Cargo = CargoAdmin;
        }

        // MÉTODOS PARA APLICAR POLIMORFISMO ESTÁTICO

        // La subclase Admin sobrescribe el método RecibirMateriales de la clase Empleado
        // Para indicar que el método es sobrescrito se utiliza la palabra reservada new
        public new string RecibirMateriales()
        {
            return "Lapiceros, Resma de papel";
        }

        // La palabra override indica que este método es sobrescrito (POLIMORFISMO)
        // Recordar que para poder utilizar override en la clase padre el método debe
        // tener la palabra virtual/
        public override string GenerarCodigo()
        {
            Codigo = "ADMIN" + Nombre.Substring(0, 3);
            return Codigo;
        }
    }
}
