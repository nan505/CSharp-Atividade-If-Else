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
                if(caractereInserido == 'a' || caractereInserido == 'e' || caractereInserido == 'i' || caractereInserido == 'o'
                    || caractereInserido == 'u')
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
            string mesNomeado = tBoxMes.Text;
            bool campoEstaVazio = string.IsNullOrEmpty(mesNomeado);
            int mesNumerico = 0;
            string[] infoNomeMes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro",
                "Novembro", "Dezembro"};
            string[] infoDiasMes = { "31", "28 ou 29", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31" };
            bool campoPossuiMesValido = infoNomeMes.Contains(mesNomeado, StringComparer.OrdinalIgnoreCase);
            if (campoEstaVazio == false && int.TryParse(tBoxMes.Text, out mesNumerico) && mesNumerico > 0 && mesNumerico <= 12)
            {
                MessageBox.Show("O mês de " + infoNomeMes[mesNumerico - 1] + " possui " + infoDiasMes[mesNumerico - 1] + " dias!", 
                    "Mensagem de Aviso");
            }
            else if(campoEstaVazio == false && campoPossuiMesValido == true)
            {
                string[] infoNomeMesMinusculo = infoNomeMes.Select(funcaoMinuscula => funcaoMinuscula.ToLower()).ToArray();
                string mesNomeadoMinusculo = mesNomeado.ToLower();
                int posicaoMes = Array.IndexOf(infoNomeMesMinusculo, mesNomeadoMinusculo);
                MessageBox.Show("O mês de " + infoNomeMes[posicaoMes] + " possui " + infoDiasMes[posicaoMes] + " dias!",
                    "Mensagem de Aviso");
            }
            else
            {
                MessageBox.Show("Insira um mês válido.", "Mensagem de Aviso");
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
                string mensagemResultado = "";
                for(int contador = 1; contador != numeroCasaFibo + 1; contador++)
                {
                    mensagemResultado += contador + ": " + resultado + "\n";
                    resultado = primeiroNumeroSoma + segundoNumeroSoma;
                    segundoNumeroSoma = primeiroNumeroSoma;
                    primeiroNumeroSoma = resultado;
                }
                MessageBox.Show(resultado + "\n\n" + mensagemResultado);
            }
            else
            {
                MessageBox.Show("Insira um número válido positivo", "Mensagem de Aviso");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            string nomeAluno = tBoxNomeAluno.Text;
            double primeiraNota = 0;
            double segundaNota = 0;
            double terceiraNota = 0;
            if(nomeAluno != string.Empty && double.TryParse(tBoxPrimeiraNota.Text, out primeiraNota) 
                && double.TryParse(tBoxSegundaNota.Text, out segundaNota) && double.TryParse(tBoxTerceiraNota.Text, out terceiraNota))
            {
                double mediaFinal = (primeiraNota + segundaNota + terceiraNota) / 3;
                if(mediaFinal >= 7)
                {
                    MessageBox.Show("O aluno " + nomeAluno + " está aprovado!\nA média final foi: " + mediaFinal.ToString("F2"), "Mensagem de Aviso");
                }
                else
                {
                    MessageBox.Show("O aluno " + nomeAluno + " está reprovado.\nA média final foi: " + mediaFinal.ToString("F2"), "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
            }
        }

        private void btnCalcularAumentoSalarial_Click(object sender, EventArgs e)
        {
            double salarioInicial = 0;
            if(tBoxSalario.Text != string.Empty && double.TryParse(tBoxSalario.Text, out salarioInicial) && salarioInicial > 0){
                double salarioPosAumento = 0;
                double valorAumento = 0;
                if(salarioInicial < 1000)
                {
                    salarioPosAumento = salarioInicial + (salarioInicial * 0.20);
                    valorAumento = salarioPosAumento - salarioInicial;
                    MessageBox.Show("O salário recebeu um aumento de 20% (R$" + valorAumento.ToString("F2") + ")." +
                        "\nSeu novo valor é R$" + salarioPosAumento.ToString("F2"), "Mensagem de Aviso");
                }
                else if(salarioInicial >= 1000 && salarioInicial <= 2000)
                {
                    salarioPosAumento = salarioInicial + (salarioInicial * 0.15);
                    valorAumento = salarioPosAumento - salarioInicial;
                    MessageBox.Show("O salário recebeu um aumento de 15% (R$" + valorAumento.ToString("F2") + ")." +
                        "\nSeu novo valor é R$" + salarioPosAumento.ToString("F2"), "Mensagem de Aviso");
                }
                else
                {
                    salarioPosAumento = salarioInicial + (salarioInicial * 0.10);
                    valorAumento = salarioPosAumento - salarioInicial;
                    MessageBox.Show("O salário recebeu um aumento de 10% (R$" + valorAumento.ToString("F2") + ")." +
                        "\nSeu novo valor é R$" + salarioPosAumento.ToString("F2"), "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("Insira um número positivo válido.", "Mensagem de Aviso");
            }
        }
    }
}
