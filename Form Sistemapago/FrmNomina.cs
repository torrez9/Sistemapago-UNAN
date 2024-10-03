using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Sistemapago
{
    public partial class FrmNomina : Form
    {
        ClaseNomina mynomina = new ClaseNomina();

        string cedula, nombre, tipoempleado, titulo;
        string tipocontrato, tipolicecia, departamento, cargo;
        double salario;
        int extras, antig;
        double totalplanilla = 0, totalprofesor = 0, totalconductor = 0, totaladmin = 0;

        public FrmNomina()
        {
            InitializeComponent();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelcedula_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbProfesor_CheckedChanged_1(object sender, EventArgs e)
        {
          
        }

        private void CmbPorcentajeAntiguedad_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtSalarioBase.Clear();
            txtHorasExtras.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbTitulo.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
            cmbTipoLicencia.SelectedIndex = -1;
            cmbTipoContrato.SelectedIndex = -1;
            cmbPorcentajeAntiguedad.SelectedIndex = -1;
            rbProfesor.Checked = false;
            rbConductor.Checked = false;
            rbAdmin.Checked = false;
        }

        private void rbProfesor_CheckedChanged(object sender, EventArgs e)
        {
            cmbTitulo.Enabled = true;
            cmbDepartamento.Enabled = true;
            cmbTipoContrato.Enabled = true;
            cmbTipoLicencia.Enabled = false;
            cmbCargo.Enabled = false;

            errorProvider1.SetError(cmbTipoLicencia, "");
            errorProvider1.SetError(cmbCargo, "");
            errorProvider1.SetError(rbProfesor, "");
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            cmbCargo.Enabled = true;
            cmbTitulo.Enabled = false;
            cmbDepartamento.Enabled = false;
            cmbTipoContrato.Enabled = false;
            cmbTipoLicencia.Enabled = false;

            errorProvider1.SetError(cmbTitulo, "");
            errorProvider1.SetError(cmbDepartamento, "");
            errorProvider1.SetError(cmbTipoContrato, "");
            errorProvider1.SetError(cmbTipoLicencia, "");
            errorProvider1.SetError(rbProfesor, "");
        }

        private void rbConductor_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoLicencia.Enabled = true;
            cmbTitulo.Enabled = false;
            cmbDepartamento.Enabled = false;
            cmbTipoContrato.Enabled = false;
            cmbCargo.Enabled = false;

            errorProvider1.SetError(cmbTitulo, "");
            errorProvider1.SetError(cmbDepartamento, "");
            errorProvider1.SetError(cmbTipoContrato, "");
            errorProvider1.SetError(cmbCargo, "");
            errorProvider1.SetError(rbProfesor, "");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")//Valida que el nombre no este vacio
            {
                errorProvider1.SetError(txtNombre, "Debe Ingresar un Nombre");
                txtNombre.Focus();
                return;
            }
            else
                errorProvider1.SetError(txtNombre, "");

            if (txtCedula.Text == "")//Valida que la cédula no este vacio
            {
                errorProvider1.SetError(txtCedula, "Debe Ingresar un Numero de Cédula");
                txtCedula.Focus();
                return;
            }
            else
                errorProvider1.SetError(txtCedula, "");

            if (!double.TryParse(txtSalarioBase.Text, out salario))//Valida que solo se ingresen datos numéricos en salario
            {
                errorProvider1.SetError(txtSalarioBase, "Debe Ingresar Valores Numéricos");
                txtSalarioBase.Focus();
                return;
            }
            else
                errorProvider1.SetError(txtSalarioBase, "");

            if (!int.TryParse(txtHorasExtras.Text, out extras))//Valida que solo se ingresen datos numéricos en extras
            {
                errorProvider1.SetError(txtHorasExtras, "Debe Asignar Valores Numéricos");
                txtHorasExtras.Focus();
                return;
             }
             else
                errorProvider1.SetError(txtHorasExtras, "");

            if (cmbPorcentajeAntiguedad.Text == "")//Valida que ingrese datos en antiguedad
            {
                errorProvider1.SetError(cmbPorcentajeAntiguedad, "Debe Ingresar Antiguedad");
                cmbPorcentajeAntiguedad.Focus();
                return;
            }
            else
                errorProvider1.SetError(cmbPorcentajeAntiguedad, "");

            if (rbProfesor.Checked == false && rbConductor.Checked == false && rbAdmin.Checked == false)//Valida que seleccione un tipo de empleado
            {
                errorProvider1.SetError(rbProfesor, "Debe Seleccionar el Tipo de Empleado");
                return;
            }
            else
            {
                errorProvider1.SetError(rbProfesor, "");
            }

            //Valida datos profesor
            if (rbProfesor.Checked == true)
            {
                if (cmbTitulo.Text == "")
                {
                    errorProvider1.SetError(cmbTitulo, "Debe ingresar el título");
                    cmbTitulo.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(cmbTitulo, "");
                }

                if (cmbTipoContrato.Text == "")
                {
                    errorProvider1.SetError(cmbTipoContrato, "Debe ingresar el tipo de contrato");
                    cmbTipoContrato.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(cmbTipoContrato, "");
                }

                if (cmbDepartamento.Text == "")
                {
                    errorProvider1.SetError(cmbDepartamento, "Debe ingresar el departamento");
                    cmbDepartamento.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(cmbDepartamento, "");
                }
            }

            //valida los datos del conductor
            if (rbConductor.Checked == true)
            {
                if (cmbTipoLicencia.Text == "")
                {
                    errorProvider1.SetError(cmbTipoLicencia, "Debe ingresar el tipo de licencia");
                    cmbTipoLicencia.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(cmbTipoLicencia, "");
                }
            }

            // Validar que se ingresen los datos del administrador

            if (rbAdmin.Checked == true)
            {
                if (cmbCargo.Text == "")
                {
                    errorProvider1.SetError(cmbCargo, "Debe ingresar el cargo del administrador");
                    cmbCargo.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(cmbCargo, "");
                }
            }

            //Captura de datos de los textbox
            nombre = txtNombre.Text;
            cedula = txtCedula.Text;
            salario = double.Parse(txtSalarioBase.Text);
            extras = int.Parse(txtHorasExtras.Text);
            antig = int.Parse(cmbPorcentajeAntiguedad.Text);

            //Llamado a los métodos de la clase nomina
            mynomina.Calcularextra(salario, extras);
            mynomina.Calcularantig(salario, antig);
            mynomina.Calcularinss(salario);


            if (rbProfesor.Checked == true)
            {
                // Captura de atributos para la subclase profesor
                titulo = cmbTitulo.Text;
                tipocontrato = cmbTipoContrato.Text;
                departamento = cmbDepartamento.Text;
                tipoempleado = rbProfesor.Text;

                // Llamado al constructor de la subclase profesor
                SubClaseProfesor myprofesor = new SubClaseProfesor(nombre, tipoempleado, cedula, salario, extras, antig, titulo, tipocontrato, departamento);

                // Mostrar información en el DataGrid para la subclase profesor
                dgReportesprofesor.Rows.Add(myprofesor.GenerarCodigo(), myprofesor.Nombre, myprofesor.Titulo, myprofesor.TipoContrato, myprofesor.Departamento, myprofesor.RecibirMateriales(), mynomina.Calcularnomina());

                // Calcular y mostrar el total de la planilla para profesor
                totalprofesor += mynomina.Calcularnomina();
                txtPlanillaProfesor.Text = Convert.ToString(totalprofesor);
            }

            if (rbConductor.Checked == true)
            {
                tipolicecia = cmbTipoLicencia.Text;
                tipoempleado = rbConductor.Text;

                SubClaseConductor myconductor = new SubClaseConductor(nombre, tipoempleado, cedula, salario, extras, antig, tipolicecia);

                dgReportConductores.Rows.Add(myconductor.GenerarCodigo(), myconductor.Nombre, myconductor.TipoLicencia, myconductor.RecibirMateriales(), mynomina.Calcularnomina());

                totalconductor += mynomina.Calcularnomina();
                txtPlanillaConductor.Text = Convert.ToString(totalconductor);
            }

            if (rbAdmin.Checked == true)
            {
                cargo = cmbCargo.Text;
                tipoempleado = rbAdmin.Text;

                SubClaseAdmin myadmin = new SubClaseAdmin(nombre, tipoempleado, cedula, salario, extras, antig, cargo);

                dgReportAdministracion.Rows.Add(myadmin.GenerarCodigo(), myadmin.Nombre, myadmin.Cargo, myadmin.RecibirMateriales(), mynomina.Calcularnomina());

                totaladmin += mynomina.Calcularnomina();
                txtTotalPLanillaAdmin.Text = Convert.ToString(totaladmin);
            }

            ClaseEmpleado myEmpleado = new ClaseEmpleado(nombre, tipoempleado, cedula, salario, extras, antig);

            dgNominaEmpleado.Rows.Add(myEmpleado.Nombre, myEmpleado.Tipoempleado, myEmpleado.Salario,
                mynomina.Calcularextra(myEmpleado.Salario, myEmpleado.Extras),
                mynomina.Calcularantig(myEmpleado.Salario, myEmpleado.Antig),
                mynomina.Calcularinss(myEmpleado.Salario),
                mynomina.Calcularnomina());

            MessageBox.Show("Los datos se han guardado correctamente");

            totalplanilla = totalplanilla + mynomina.Calcularnomina();
            txtTotalPlanilla.Text = Convert.ToString(totalplanilla);
        }
    }
}
