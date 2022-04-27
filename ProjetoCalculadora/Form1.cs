using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Calculadora
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        
        public Form1()
        {
            InitializeComponent();

            model = new ModelCalculadora();

        }//fim do costrutor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Soma_Click(object sender, EventArgs e)
        {
            try
            {

                double num1 = Convert.ToDouble(textBox1.Text);//Coletado o Primeiro numero
                double num2 = Convert.ToDouble(textBox1.Text);//Coletado o segundo numero
                double resultado = model.Somar(num1, num2);//gerando o resultado
                Resultado.Text = "" + resultado;//Escrever o resultado na tela
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os Números não foram digitados!\n\n" + erro);
            }
        }//Fim do Botao Soma

        private void Subtrair_Click(object sender, EventArgs e)
        {
            try
            {

            double num1 = Convert.ToDouble(textBox1.Text);//Coletado o Primeiro numero
            double num2 = Convert.ToDouble(textBox1.Text);//Coletado o segundo numero
            double resultado = model.Subitrair(num1, num2);//gerando o resultado
            Resultado.Text = "" + resultado;//Escrever o resultado na tela
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os Números não foram digitados!\n\n" + erro);
            }
        }//Fim do Botao Subitrair

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
            double num1 = Convert.ToDouble(textBox1.Text);//Coletado o Primeiro numero
            double num2 = Convert.ToDouble(textBox1.Text);//Coletado o segundo numero
            double resultado = model.Multiplicar(num1, num2);//gerando o resultado
            Resultado.Text = "" + resultado;//Escrever o resultado na tela
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os Números não foram digitados!\n\n" + erro);
            }
        }//Fim do Botao Multiplicação

        private void Divisao_Click(object sender, EventArgs e)
        {
            try
            {
            double num1 = Convert.ToDouble(textBox1.Text);//Coletado o Primeiro numero
            double num2 = Convert.ToDouble(textBox1.Text);//Coletado o segundo numero
            double resultado = model.Dividir(num1, num2);//gerando o resultado
            if (resultado == -1)
            {
                Resultado.Text = "Impossivel Dividir por zero!";
            }
            else
            {
                    Resultado.Text = "" + resultado;

            }
            Resultado.Text = "" + resultado;//Escrever o resultado na tela
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os Números não foram digitados!\n\n" + erro);
            }
        }//Fim do Botao Divisão

        private void Potencia_Click(object sender, EventArgs e)
        {
            try
            {
            double num1 = Convert.ToDouble(textBox1.Text);//Coletado o Primeiro numero
            double num2 = Convert.ToDouble(textBox1.Text);//Coletado o segundo numero
            double resultado = model.Potencia(num1, num2);//gerando o resultado
            Resultado.Text = "" + resultado;//Escrever o resultado na tela
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os Números não foram digitados!\n\n" + erro);
            }
        }//Fim do Botao Potencia

        private void Raiz_Click(object sender, EventArgs e)
        {
            try
            {
            double num1 = Convert.ToDouble(textBox1.Text);//Coletado o Primeiro numero
            double num2 = Convert.ToDouble(textBox1.Text);//Coletado o segundo numero
            double resultado = model.Raiz(num1);//gerando o resultado
            if(resultado == -1)
            {
                Resultado.Text = "Impossivel calcular a raiz!";
            }
            else
            {
                Resultado.Text = "" + resultado;
            }
            Resultado.Text = "" + resultado;//Escrever o resultado na tela
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os Números não foram digitados!\n\n" + erro);
            }
        }//Fim do Botao Raiz

        private void label3_Click(object sender, EventArgs e)
        {

        }//Fim do Botao Resultado

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim da Caixa de texto patra o Primeiro Número

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim da Caixa de texto patra o Segundo Número
    }//Fim da Classe
}//Fim do Projeto
