using Entidades;
using System;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {

        public FormCalculadora()
        {
            InitializeComponent();

            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            this.lblResultado.Text = string.Empty;
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero1.Text == String.Empty || this.txtNumero2.Text == String.Empty)
            {
                MessageBox.Show("Faltan campos para realizar la operación");
            }
            else
            {
                if (this.cmbOperador.Text == String.Empty)
                {
                    this.cmbOperador.Text = "+";
                }
                if (this.cmbOperador.Text == "/")
                {
                    double auxResultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                    this.lblResultado.Text = auxResultado.ToString("N2");

                }

                //double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                //this.lblResultado.Text = resultado.ToString();

            }

        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);
            if (operador == String.Empty)
            {
                operador = "+";
            }
            char op = Convert.ToChar(operador);

            double resultado = Calculadora.Operar(n1, n2, op);

            return resultado;

        }
    }
}
