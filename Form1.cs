using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aux = 0; //Vari�vel auxiliar para c�lculo do cubo - necess�rio neste
            //momento para deixar o c�digo mais legivel.
            try
            // Controle para verificar se o usu�rio n�o vai digitar nenhum dado dotipo errado(n�o inteiro);
            {
                aux = Convert.ToInt32(textBox1.Text);
                // atribui��o do n�mero digitado pelo usu�rio � vari�vel aux.
            }
            catch
            // Desvio que ocorrer� caso o usu�rio digite um dado inv�lido para c�lculo do cubo.
            {
                MessageBox.Show("O valor inserido n�o � valido");
            }
            textBox2.Text = Convert.ToString(aux * aux * aux);
            // C�lculo do cubo com a devida convers�o para string e atribui��o ao controle
            //textBox2 que ir� mostrar o resultado para o usu�rio.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    }