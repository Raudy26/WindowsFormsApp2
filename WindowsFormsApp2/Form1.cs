using System;
using System.Windows.Forms;

namespace MultiplicacionSinAsterisco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            
            int num1 = int.Parse(txtNumero1.Text);
            int num2 = int.Parse(txtNumero2.Text);

          
            int resultado = MultiplicarSinAsterisco(num1, num2);

            
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        
        private int MultiplicarSinAsterisco(int a, int b)
        {
            int resultado = 0;

            
            bool negativo = false;
            if (b < 0)
            {
                b = -b;
                negativo = true;
            }

           
            for (int i = 0; i < b; i++)
            {
                resultado += a;
            }

           
            if (negativo)
            {
                resultado = -resultado;
            }

            return resultado;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
