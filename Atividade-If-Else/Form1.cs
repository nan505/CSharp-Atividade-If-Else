using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_If_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarNumero_Click(object sender, EventArgs e)
        {
            if(tBoxNumero.Text != string.Empty)
            {
                int numeroUsuario = int.Parse(tBoxNumero.Text);
                if(numeroUsuario > 0)
                {
                    MessageBox.Show("O número " + numeroUsuario + " é positivo!", "Mensagem de Aviso");
                }
                else if(numeroUsuario < 0)
                {
                    MessageBox.Show("O número " + numeroUsuario + " é negativo!", "Mensagem de Aviso");
                }
                else
                {
                    MessageBox.Show("O número inserido é 0!", "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("Insira um número válido.", "Mensagem de Aviso");
            }
        }

        private void btnTresNumeros_Click(object sender, EventArgs e)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            int terceiroNumero = 0;
            if(int.TryParse(tBoxPrimeiroNumero.Text, out primeiroNumero) && int.TryParse(tBoxSegundoNumero.Text, out segundoNumero) 
                && int.TryParse(tBoxTerceiroNumero.Text, out terceiroNumero)
                )
            {
                if(primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero)
                {
                    MessageBox.Show("O maior dos três números informados é: " + primeiroNumero + ".", "Mensagem de Aviso");
                }
                else if(segundoNumero > primeiroNumero && segundoNumero > terceiroNumero)
                {
                    MessageBox.Show("O maior dos três números informados é: " + segundoNumero + ".", "Mensagem de Aviso");
                }
                else if(terceiroNumero >  primeiroNumero && terceiroNumero > segundoNumero)
                {
                    MessageBox.Show("O maior dos três números informados é: " + terceiroNumero + ".", "Mensagem de Aviso");
                }
                else
                {
                    MessageBox.Show("Os três números informados precisam ser de diferentes valores.", "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("Insira três números válidos e de diferentes valores.");
            }
        }

        private void btnVerificarLetra_Click(object sender, EventArgs e)
        {
            bool inseriuCaractere = char.IsLetter(char.Parse(tBoxLetra.Text));
            if(inseriuCaractere == true && tBoxLetra.Text != string.Empty)
            {
                char caractereInserido = char.ToLower(char.Parse(tBoxLetra.Text));
                if(caractereInserido == 'a' || caractereInserido == 'e' || caractereInserido == 'i' || caractereInserido == 'o' || caractereInserido == 'u')
                {
                    MessageBox.Show("A letra informada: " + char.ToUpper(caractereInserido) + " é uma vogal!", "Mensagem de Aviso");
                }
                else
                {
                    MessageBox.Show("A letra informada: " + char.ToUpper(caractereInserido) + " é uma consoante!", "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("Informe uma letra válida.", "Mensagem de Aviso");
            }
        }

        private void btnVerificarDiasMes_Click(object sender, EventArgs e)
        {
            bool campoEstaVazio = string.IsNullOrEmpty(tBoxMes.Text);
            int mesNumerico = 0;
            string[] infoNomeMes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
            string[] infoDiasMes = { "31", "28 ou 29", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31" };
            if (campoEstaVazio == false && int.TryParse(tBoxMes.Text, out mesNumerico) && mesNumerico > 0 && mesNumerico <= 12)
            {
                MessageBox.Show("O mês de " + infoNomeMes[mesNumerico - 1] + " possui " + infoDiasMes[mesNumerico - 1] + " dias!", "Mensagem de Aviso");
            }
        }

        private void btnFibo_Click(object sender, EventArgs e)
        {
            int numeroCasaFibo;
            if(int.TryParse(tBoxFibo.Text, out numeroCasaFibo) && numeroCasaFibo > 0)
            {
                int primeiroNumeroSoma = 0;
                int segundoNumeroSoma = 1;
                int resultado = 0;
                for(int contador = 1; contador != numeroCasaFibo; contador++)
                {
                    resultado = primeiroNumeroSoma + segundoNumeroSoma;
                    segundoNumeroSoma = primeiroNumeroSoma;
                    primeiroNumeroSoma = resultado;
                }
                MessageBox.Show(resultado + "");
            }
        }
    }
}
