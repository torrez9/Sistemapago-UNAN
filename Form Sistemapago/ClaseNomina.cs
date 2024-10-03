using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Sistemapago
{
    public class ClaseNomina
    {
        // Encapsulamiento de tipo privado, los atributos solo pueden acceder desde la propia clase
        protected double totalextra, totalantig, totalnomina, devengado, inss;

        // Encapsulamiento de tipo público, puede ser accedida desde cualquier parte de la aplicación
        public double Totalextra { get; set; }
        public double Totalantig { get; set; }
        public double Totalnomina { get; set; }
        public double Devengado { get; set; }
        public double Inss { get; set; }

        // Métodos para calcular nomina
        public double Calcularextra(double salario, int extras) // Método con encapsulamiento de tipo público
        {
            totalextra = salario / 30 / 8 * extras * 2;
            return Math.Round(totalextra, 2);
        }

        public double Calcularantig(double salario, int antig)
        {
            totalantig = salario * antig / 100;
            return Math.Round(totalantig, 2);
        }

        public double Calcularinss(double salario)
        {
            devengado = salario + totalextra + totalantig;
            inss = devengado * 0.07;
            return Math.Round(inss, 2);
        }

        public double Calcularnomina()
        {
            totalnomina = devengado - inss;
            return Math.Round(totalnomina, 2);
        }
    }
}
