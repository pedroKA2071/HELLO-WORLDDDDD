using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLO_WORLD
{
    public partial class JANELA : Form
    {
        public JANELA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = txbnumero2.Text;


            float total = float.Parse(numero1) + float.Parse(numero2);

            lbresultado.Text = total.ToString();
        }

        private void lbresultado_Click(object sender, EventArgs e)
        {

        }

        private void txbnumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = txbnumero2.Text;


            float total = float.Parse(numero1) * float.Parse(numero2);

            lbresultado.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = txbnumero2.Text;


            float total = float.Parse(numero1) - float.Parse(numero2);

            lbresultado.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = txbnumero2.Text;

        


            float total = float.Parse(numero1) / float.Parse(numero2);

            lbresultado.Text = total.ToString();


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txbnumero3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbnumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnimparoupar_Click(object sender, EventArgs e)
        {
            int numero4 = int.Parse(txbnumero3.Text);
           
            if (numero4 % 2 == 0)
            {
                lbresultado.Text = "O Numero digitado é par";
            }
            else
            {
                lbresultado.Text = "O Numero digitado é impar";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
int numero3 = int.Parse(txbnumero3.Text);

            if (numero3 <0) 
            {
                lbresultado.Text = "O Numero digitado é menor que 0";
            }
            else
            {
                lbresultado.Text = "O Numero digitado é maior que 0";
            }
        }
    }
}

    
    
    
