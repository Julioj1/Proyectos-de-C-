namespace Calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0, numero2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }
        private void clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '*')
            {
                numero1 = Math.Sqrt(numero1);
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);

            if (operador == '+')
            {
                txtResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '-')
            {
                txtResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == 'x')
            {
                txtResultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '/')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre cero");
                }
            }
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btncambiodesigno_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            numero1 *= -1;
            txtResultado.Text = numero1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}