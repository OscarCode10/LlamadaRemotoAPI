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
    public partial class Prestamo : Form
    {

        String nombre_cliente;
        int[] cuotas_disponibles = { 3, 6, 12, 24, 36, 60, 120, 180, 240 };
        Dictionary<int, double> intereses_base;

        public Prestamo(String TfNombre)
        {
            InitializeComponent();
            nombre_cliente = TfNombre;

            intereses_base = new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes = 2.0; i < cuotas_disponibles.Length; i++, interes += 0.5)
            {
                intereses_base[cuotas_disponibles[i]] = interes;
            }

            TfSueldo.KeyPress += SoloNumeros;
            TfGastos.KeyPress += SoloNumeros;
            TfMonto.KeyPress += SoloNumeros;

        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            // Permitir números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            // Permitir tecla borrar
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // Permitir un solo punto decimal
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquea todo lo demás
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres(out double tasaInteres)
        {
            double sueldo = Convert.ToDouble(TfSueldo.Text);
            double gastos = Convert.ToDouble(TfGastos.Text);
            double monto = Convert.ToDouble(TfMonto.Text);

            double capacidad = sueldo - gastos;
            tasaInteres = 0;

            int cuotas = Convert.ToInt32(CbCuotas.SelectedItem);

            // Interés según cuotas
            if (cuotas <= 6)
                tasaInteres = 0.05;
            else if (cuotas <= 12)
                tasaInteres = 0.08;
            else if (cuotas <= 24)
                tasaInteres = 0.12;
            else
                tasaInteres = 0.15;

            // Interés extra si capacidad baja
            if (capacidad < sueldo * 0.20)
                tasaInteres += 0.05;

            double totalPagar = monto + (monto * tasaInteres);

            return totalPagar;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            popularCuotas();
            saludo.Text += nombre_cliente;
        }

        void popularCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                CbCuotas.Items.Add(cuotas_disponibles[i]);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // 🔎 Validar campos vacíos
            if (string.IsNullOrWhiteSpace(TfSueldo.Text) ||
                string.IsNullOrWhiteSpace(TfGastos.Text) ||
                string.IsNullOrWhiteSpace(TfMonto.Text))
            {
                MessageBox.Show(
                    "Debe completar los campos de Sueldo, Gastos y Monto antes de continuar.",
                    "Calculo de interes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar que sean números válidos
            if (!double.TryParse(TfSueldo.Text, out double sueldo) ||
                !double.TryParse(TfGastos.Text, out double gastos) ||
                !double.TryParse(TfMonto.Text, out double monto))
            {
                MessageBox.Show(
                    "Ingrese valores numéricos válidos.",
                    "Calculo de interes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int cuotas = Convert.ToInt32(CbCuotas.SelectedItem);

            // Rechazo automático
            if (monto > 100000000)
            {
                MessageBox.Show(
                    "Su préstamo por $" + monto.ToString("N0") +
                    " en " + cuotas +
                    " cuotas ha sido RECHAZADO.\n\nEl monto solicitado supera el límite permitido.",
                    "Calculo de interes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Aprobado
            double tasa;
            double totalFinal = calcularInteres(out tasa);

            string mensaje =
                "Su préstamo por $" + monto.ToString("N0") +
                " en " + cuotas +
                " cuotas se concederá con un interés mensual del " +
                (tasa * 100).ToString("F2") + "%.\n\n" +
                "El monto final asciende a $" + totalFinal.ToString("N0");

            MessageBox.Show(
                mensaje,
                "Calculo de interes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
