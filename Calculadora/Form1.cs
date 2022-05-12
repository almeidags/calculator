namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0, resultado;
        string operacao = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "+";
            if (string.IsNullOrEmpty(txtResultado.Text))
            {
                MessageBox.Show("Digite um valor para realizar a operação!");
            }
            else
            {
                valor1 = double.Parse(txtResultado.Text);
                operacao = "SOMA";
                
                txtResultado.Text = "";
            }

            if (string.IsNullOrEmpty(txtOperacao.Text))
            {

            }
            else
            {
                
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "-";
            if (string.IsNullOrEmpty(txtResultado.Text))
            {
                MessageBox.Show("Digite um valor para realizar a operação!");
            }
            else
            {
                valor1 = double.Parse(txtResultado.Text);
                operacao = "SUB";
                
                txtResultado.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
            {
                MessageBox.Show("Digite um valor para realizar a operação!");
            }
            else
            {
                valor1 = double.Parse(txtResultado.Text);
                operacao = "DIV";
                txtOperacao.Text = "/";
                txtResultado.Text = "";
            }
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
            {
                MessageBox.Show("Digite um valor para realizar a operação!");
            }
            else
            {
                valor1 = double.Parse(txtResultado.Text);
                operacao = "MULT";
                txtOperacao.Text = "X";
                txtResultado.Text = "";
            } 
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //Botão C
            txtResultado.Text = "";
            txtOperacao.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botão CE
            txtResultado.Text = "";
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            //Botão =
            txtOperacao.Text = "";
            valor2 = double.Parse(txtResultado.Text);
            switch (operacao)
            {
                case "SOMA":
                    resultado = valor1 + valor2;
                    txtResultado.Text = Convert.ToString(resultado);
                    break;
                case "SUB":
                    resultado = valor1 - valor2;
                    txtResultado.Text = Convert.ToString(resultado);
                    break;
                case "MULT":
                    resultado = valor1 * valor2;
                    txtResultado.Text = Convert.ToString(resultado);
                    break;
                case "DIV":
                    resultado = valor1 / valor2;
                    txtResultado.Text = Convert.ToString(resultado);
                    break;
            }
        }

        
    }
}