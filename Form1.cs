using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_simples
{
    public partial class Form1 : Form
    { 
        // lista de opções
        enum Operacoes
        {
            Soma,
            Subtrai,
            Multiplica,
            Divide,
            Nenhuma
        }

        static Operacoes ultimaOperacao = Operacoes.Nenhuma;    


    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1,1);
                if(textBoxDisplay.Text.EndsWith(","))
                {
                    qtdVirgula = 0;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private int qtdVirgula;

        private void button12_Click(object sender, EventArgs e)
        {
            if (qtdVirgula > 0)
            {
                return;
            }
            else
            {
                textBoxDisplay.Text += ",";
                // zerar a qtd de virgulas
                qtdVirgula = 1;
            }
        }

        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "0";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            ultimaOperacao = Operacoes.Nenhuma;
        }

        private void buttonLess_Click(object sender, EventArgs e)
        {
         

            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }

            textBoxDisplay.Text += (sender as Button).Text;
            qtdVirgula = 0;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            

            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }

            textBoxDisplay.Text += (sender as Button).Text;
            qtdVirgula = 0;
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }

            textBoxDisplay.Text += (sender as Button).Text;
            qtdVirgula = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }

            textBoxDisplay.Text += (sender as Button).Text;
            qtdVirgula = 0;
        }

        private void FazerCalculo(Operacoes ultimaOperacao)
        {
            // double é número real
            List<double> listaDeNumeros = new List<double>();
            
            switch (ultimaOperacao)
            {
                case Operacoes.Soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Subtrai:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Divide:
                    try
                    {
                        listaDeNumeros = textBoxDisplay.Text.Split('÷').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        textBoxDisplay.Text = "Divisão por zero";
                    }
                    break;
                case Operacoes.Nenhuma:
                    break;
                default:
                    break;


            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            // Se a ultima operação for diferente de nenhuma.
            if (ultimaOperacao != Operacoes.Nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacoes.Nenhuma;
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            
            textBoxDisplay.Text += "8";
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void buttonCopy_click_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool parentesesDeNovo = false;

        private void buttonParenteses_Click(object sender, EventArgs e)
        {
            
            // aperece o primeiro parenteses 

            // A pessoa digitou algo dentro dos parênteses

            // Se clicado no botão novamente, fechar os parênteses
            if (parentesesDeNovo == true)
            {
                textBoxDisplay.Text += ")";
                parentesesDeNovo = false;
            }
            else
            {
                textBoxDisplay.Text += "(";
                parentesesDeNovo = true;
            }
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
