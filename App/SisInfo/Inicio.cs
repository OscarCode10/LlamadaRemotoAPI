using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisInfo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSoli_Click(object sender, EventArgs e)
        {
            using (Prestamo ventanaPrestamo = new Prestamo(TfNombre.Text))
                ventanaPrestamo.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            BtnCerrar.Enabled = false;
        }

        private void ControlBotones()
        {
            bool nombreValido = TfNombre.Text.Trim() != string.Empty && TfNombre.Text.All(Char.IsLetter);
            bool apellidoValido = TfApellido.Text.Trim() != string.Empty && TfApellido.Text.All(Char.IsLetter);
            bool correoValido = TfCorreo.Text.EndsWith("@gmail.com") && TfCorreo.Text.Length > 10;
            bool celValido = TfCel.Text.Length == 10 && TfCel.Text.All(Char.IsDigit);
            bool direccionValida = TfDir.Text.Trim() != string.Empty;

            // ================= VALIDACIONES =================

            // Nombre
            if (!nombreValido)
                errorProvider1.SetError(TfNombre, "Ingrese un nombre válido (solo letras)");
            else
                errorProvider1.SetError(TfNombre, "");

            // Apellido
            if (!apellidoValido)
                errorProvider1.SetError(TfApellido, "Ingrese un apellido válido (solo letras)");
            else
                errorProvider1.SetError(TfApellido, "");

            // Correo
            if (!correoValido)
                errorProvider1.SetError(TfCorreo, "El correo debe terminar en @gmail.com");
            else
                errorProvider1.SetError(TfCorreo, "");

            // Celular
            if (!celValido)
                errorProvider1.SetError(TfCel, "Debe contener exactamente 10 números");
            else
                errorProvider1.SetError(TfCel, "");

            // Dirección
            if (!direccionValida)
                errorProvider1.SetError(TfDir, "Debe ingresar una dirección");
            else
                errorProvider1.SetError(TfDir, "");

            // ================= BOTÓN =================

            BtnSoli.Enabled = nombreValido && apellidoValido && correoValido && celValido && direccionValida;
        }

        private void TfNombre_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void TfApellido_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void TfCel_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void TfCorreo_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void TfDir_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }
    }
}
