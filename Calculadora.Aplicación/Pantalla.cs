using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculadora.Aplicación
{
    public partial class Pantalla : Form
    {
        double PrimerNumero;
        double SegundoNumero;
        string OperacionAritmetica;

        public Pantalla()
        {
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        #region "Metodos"
        void Validar(string Texto)
        {
            string UltimaLetra = txtResultado.Text.Length > 0 ? txtResultado.Text.Substring(txtResultado.Text.Length - 1, 1) : "";
            txtResultado.Text += UltimaLetra == "." ? (Texto == "." ? "" : Texto) : txtResultado.Text.ToArray().Where(p => p.Equals('.')).Count() == 1 ? (Texto == "." ? "" : Texto) : (Texto == "." ? (txtResultado.Text.Length > 0 ? Texto : "") : Texto);
        }

        void Limpiar()
        {
            PrimerNumero = 0;
            SegundoNumero = 0;
            OperacionAritmetica = "";
            txtResultado.Clear();
            txtResultado.Focus();
        }

        void LimpiarResultado()
        {
            txtResultado.Clear();
            txtResultado.Focus();
        }

        void CalcularPrimerNumero(string Texto)
        {
            if (txtResultado.Text.Length > 0)
            {
                PrimerNumero = Convert.ToDouble(txtResultado.Text);
                OperacionAritmetica = Texto;
                LimpiarResultado();
            }
        }

        void CalcularSegundoValor()
        {
            if (txtResultado.Text.Length > 0)
            {
                SegundoNumero = Convert.ToDouble(txtResultado.Text);
                switch (OperacionAritmetica)
                {
                    case "%": txtResultado.Text = Convert.ToString(PrimerNumero % SegundoNumero); break;
                    case "/": txtResultado.Text = Convert.ToString(PrimerNumero / SegundoNumero); break;
                    case "*": txtResultado.Text = Convert.ToString(PrimerNumero * SegundoNumero); break;
                    case "-": txtResultado.Text = Convert.ToString(PrimerNumero - SegundoNumero); break;
                    case "+": txtResultado.Text = Convert.ToString(PrimerNumero + SegundoNumero); break;
                }
            }
        }

        string QuitarUltimaLetra(string Texto)
        {
            return Texto.Length > 0 ? Texto.Substring(0, Texto.Length - 1) : "";
        }
        #endregion

        #region "Números"
        private void btnCero_Click(object sender, System.EventArgs e)
        {
            Validar("0");
        }

        private void btnUno_Click(object sender, System.EventArgs e)
        {
            Validar("1");
        }

        private void btnDos_Click(object sender, System.EventArgs e)
        {
            Validar("2");
        }

        private void btnTres_Click(object sender, System.EventArgs e)
        {
            Validar("3");
        }

        private void btnCuatro_Click(object sender, System.EventArgs e)
        {
            Validar("4");
        }

        private void btnCinco_Click(object sender, System.EventArgs e)
        {
            Validar("5");
        }

        private void btnSeis_Click(object sender, System.EventArgs e)
        {
            Validar("6");
        }

        private void btnSiete_Click(object sender, System.EventArgs e)
        {
            Validar("7");
        }

        private void btnOcho_Click(object sender, System.EventArgs e)
        {
            Validar("8");
        }

        private void btnNueve_Click(object sender, System.EventArgs e)
        {
            Validar("9");
        }
        #endregion "Números"

        #region "Signos"
        private void btnPunto_Click(object sender, System.EventArgs e)
        {
            Validar(".");
        }
        #endregion "Signos"
        
        #region "Operaciones Aritméticas"
        private void btnResiduo_Click(object sender, System.EventArgs e)
        {
            CalcularPrimerNumero("%");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            CalcularPrimerNumero("/");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            CalcularPrimerNumero("*");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            CalcularPrimerNumero("-");
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            CalcularPrimerNumero("+");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            CalcularSegundoValor();
        }
        #endregion "Operaciones Aritméticas"

        #region "Acciones"
        private void btnLimpiar_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            txtResultado.Text = QuitarUltimaLetra(txtResultado.Text);
        }
        #endregion "Acciones"

        #region "Eventos"
        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) ? false : true;
        }
        #endregion "Eventos"

        private void tsmAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Paucas Navarro, Victor Hugo \nCorreo: vhpaucas@gmail.com \nRepositorio: www.github.com/victorpaucas", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
