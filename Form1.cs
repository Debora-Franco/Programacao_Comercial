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
            int aux = 0; //Variável auxiliar para cálculo do cubo - necessário neste
            //momento para deixar o código mais legivel.
            try
            // Controle para verificar se o usuário não vai digitar nenhum dado dotipo errado(não inteiro);
            {
                aux = Convert.ToInt32(textBox1.Text);
                // atribuição do número digitado pelo usuário à variável aux.
            }
            catch
            // Desvio que ocorrerá caso o usuário digite um dado inválido para cálculo do cubo.
            {
                MessageBox.Show("O valor inserido não é valido");
            }
            textBox2.Text = Convert.ToString(aux * aux * aux);
            // Cálculo do cubo com a devida conversão para string e atribuição ao controle
            //textBox2 que irá mostrar o resultado para o usuário.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    }