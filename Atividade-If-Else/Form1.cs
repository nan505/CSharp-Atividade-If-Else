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

        // Atividade 1: Um script que verifica se um número fornecido pelo usuário é positivo, negativo ou zero.

        private void btnVerificarNumero_Click(object sender, EventArgs e)
        {
            int numeroUsuario = 0; 

            // Validando se o texto da TextBox pode ser convertido em um valor numérico inteiro com int.TryParse()
            // Caso seja possível, atribuir esse valor para a variável "numeroUsuario" com o "out":

            if (int.TryParse(tBoxNumero.Text, out numeroUsuario))
            {

                // Validando se o número informado pelo usuário é maior que 0, ou se é menor que 0:

                if(numeroUsuario > 0)
                {
                    MessageBox.Show("O número " + numeroUsuario + " é positivo!", "Mensagem de Aviso");
                }
                else if(numeroUsuario < 0)
                {
                    MessageBox.Show("O número " + numeroUsuario + " é negativo!", "Mensagem de Aviso");
                }

                // Senão, o número informado pelo usuário é exatamente 0:

                else
                {
                    MessageBox.Show("O número inserido é 0!", "Mensagem de Aviso");
                }
            }

            // Senão, exibir uma mensagem pedindo para o usuário informar um número válido:

            else
            {
                MessageBox.Show("Insira um número válido.", "Mensagem de Aviso");
            }
        }

        // Atividade 2: Um script que faz a leitura de três números distintos e determina qual é o maior.

        private void btnTresNumeros_Click(object sender, EventArgs e)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            int terceiroNumero = 0;

            // Validando se o os três textos das TextBoxes podem ser convertidos em valores numéricos inteiros com int.TryParse()
            // Caso seja possível, atribuir esses valores para as respectivas variáveis inteiras com o "out":

            if (int.TryParse(tBoxPrimeiroNumero.Text, out primeiroNumero) && int.TryParse(tBoxSegundoNumero.Text, out segundoNumero) 
                && int.TryParse(tBoxTerceiroNumero.Text, out terceiroNumero)
                )
            {

                // Validando qual dos três números é o maior e se todos possuem valores diferentes entre si.

                if(primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero && segundoNumero != terceiroNumero)
                {
                    MessageBox.Show("O maior dos três números informados é: " + primeiroNumero + ".", "Mensagem de Aviso");
                }
                else if(segundoNumero > primeiroNumero && segundoNumero > terceiroNumero && primeiroNumero != terceiroNumero)
                {
                    MessageBox.Show("O maior dos três números informados é: " + segundoNumero + ".", "Mensagem de Aviso");
                }
                else if(terceiroNumero >  primeiroNumero && terceiroNumero > segundoNumero && primeiroNumero != segundoNumero)
                {
                    MessageBox.Show("O maior dos três números informados é: " + terceiroNumero + ".", "Mensagem de Aviso");
                }

                // Senão, exibir uma mensagem pedindo para o usuário informar três números de valores distintos:

                else
                {
                    MessageBox.Show("Os três números informados precisam ser de diferentes valores.", "Mensagem de Aviso");
                }
            }

            // Senão, exibir uma mensagem pedindo para o usuário informar três números válidos e de valores distintos:

            else
            {
                MessageBox.Show("Insira três números válidos e de diferentes valores.");
            }
        }

        // Atividade 3: Um programa que verifica se a letra fornecida pelo usuário é uma vogal ou uma consoante.

        private void btnVerificarLetra_Click(object sender, EventArgs e)
        {

            // Booleano para verificar se o caractere informado pelo usuário é uma letra com char.IsLetter()
            // Convertendo o texto da TextBox em um caractere com char.Parse()

            bool inseriuCaractere = char.IsLetter(char.Parse(tBoxLetra.Text));

            // Validando se o usuário inseriu um caractere, e se a TextBox não está vazia:

            if(inseriuCaractere == true && tBoxLetra.Text != string.Empty)
            {

                // Convertendo o caractere informado para maiúsculo com char.ToUpper()

                char caractereInserido = char.ToUpper(char.Parse(tBoxLetra.Text));

                // Validando se o caractere maiúsculo corresponde a pelo menos uma das cinco vogais maiúsculas:

                if(caractereInserido == 'A' || caractereInserido == 'E' || caractereInserido == 'I' || caractereInserido == 'O'
                    || caractereInserido == 'U')
                {
                    MessageBox.Show("A letra informada: " + caractereInserido + " é uma vogal!", "Mensagem de Aviso");
                }

                // Senão, o caractere informado é uma consoante.

                else
                {
                    MessageBox.Show("A letra informada: " + caractereInserido + " é uma consoante!", "Mensagem de Aviso");
                }
            }

            // Senão, exibir uma mensagem pedindo para o usuário informar um caractere de letra válido:

            else
            {
                MessageBox.Show("Informe uma letra válida.", "Mensagem de Aviso");
            }
        }

        // Atividade 4: Um script que lê um mês (Escrito pelo número ou nome extenso) do ano e informa quantos dias ele tem.

        private void btnVerificarDiasMes_Click(object sender, EventArgs e)
        {
            string mesNomeado = tBoxMes.Text;

            // Booleano para validar se a TextBox está vazia ou contém um valor nulo:

            bool campoEstaVazio = string.IsNullOrEmpty(mesNomeado);
            int mesNumerico = 0;

            // Array do tipo string para armazenar o nome de todos os meses do ano:

            string[] infoNomeMes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro",
                "Novembro", "Dezembro"};

            // Array do tipo string para armazenar a quantidade de dias que cada mês possui:

            string[] infoDiasMes = { "31", "28 ou 29", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31" };

            // Booleano para validar se o mês informado pelo usuário corresponde a um dos meses armazenados no array "infoNomeMes":

            // Utilizando o StringComparer.OrdinalIgnoreCase dentro da função infoNomeMes.Contains() para ignorar a diferença entre
            // caracteres maiúsculos e minúsculos:

            bool campoPossuiMesValido = infoNomeMes.Contains(mesNomeado, StringComparer.OrdinalIgnoreCase);

            // Validando se a variável "mesNomeado" está vazia ou contém um valor nulo 
            // Se o texto da TextBox pode ser convertido em um valor numérico inteiro com int.TryParse()
            // Caso seja possível, atribuir esse valor para a variável "mesNumerico" com o "out"
            // E se a variável "mesNumerico" é maior que 0 e menor ou igual a 12:

            if (campoEstaVazio == false && int.TryParse(tBoxMes.Text, out mesNumerico) && mesNumerico > 0 && mesNumerico <= 12)
            {

                // Exibindo o nome do mês e sua quantidade de dias armazenadas nos arrays "infoNomeMes" e "infoDiasMes", respectivamente
                // Utilizando a variável "mesNumerico" como base para localizar a posição das informações desejadas
                // Subtraindo 1 do valor total da variável "mesNumerico", já que arrays começam a contagem de posições a partir de 0:

                MessageBox.Show("O mês de " + infoNomeMes[mesNumerico - 1] + " possui " + infoDiasMes[mesNumerico - 1] + " dias!", 
                    "Mensagem de Aviso");
            }

            // Senão, validando se a TextBox não está vazia
            // E se o mês informado pelo usuário corresponde a um dos meses armazenados no array "infoNomeMes":

            else if (campoEstaVazio == false && campoPossuiMesValido == true)
            {

                // Utilizando um array do tipo string para armazenar as informações presentes no array "infoNomeMes"
                // Criando a função "funcaoMinuscula" dentro de infoNomeMes.Select()
                // Utilizando a função "funçãoMinuscula" para converter todas as letras do array "infoNomeMes" em minúsculas
                // Utilizando .ToArray() para converter as novas informações em um array:

                string[] infoNomeMesMinusculo = infoNomeMes.Select(funcaoMinuscula => funcaoMinuscula.ToLower()).ToArray();

                // Convertendo as letras do nome do mês informado pelo usuário em minúsculas com .ToLower()
                // Armazenando o valor convertido na variável "mesNomeadoMinusculo"

                string mesNomeadoMinusculo = mesNomeado.ToLower();

                // Declarando a variável inteira "posicaoMes" para armazenar a posição desejada no array "infoNomeMesMinusculo"
                // Utilizando Array.IndexOf() para identificar a posição numérica de "mesNomeadoMinusculo"
                // dentro do array "infoNomeMesMinusculo":

                int posicaoMes = Array.IndexOf(infoNomeMesMinusculo, mesNomeadoMinusculo);

                // Exibindo o nome do mês e sua quantidade de dias armazenadas nos arrays "infoNomeMes" e "infoDiasMes", respectivamente
                // Utilizando a variável "posicaoMes" como base para localizar a posição das informações desejadas:

                MessageBox.Show("O mês de " + infoNomeMes[posicaoMes] + " possui " + infoDiasMes[posicaoMes] + " dias!",
                    "Mensagem de Aviso");
            }
            else
            {
                MessageBox.Show("Insira um mês válido.", "Mensagem de Aviso");
            }
        }

        // Desafio opcional proposto pelo professor:

        private void btnFibo_Click(object sender, EventArgs e)
        {
            int numeroCasaFibo;
            if(int.TryParse(tBoxFibo.Text, out numeroCasaFibo) && numeroCasaFibo > 0)
            {
                int primeiroNumeroSoma = 0;
                int segundoNumeroSoma = 1;
                int resultado = 0;
                int resultadoMensagem = 0;
                string mensagemResultado = "";
                for(int contador = 1; contador != numeroCasaFibo + 1; contador++)
                {
                    resultadoMensagem = resultado;
                    mensagemResultado += contador + ": " + resultado + "\n";
                    resultado = primeiroNumeroSoma + segundoNumeroSoma;
                    segundoNumeroSoma = primeiroNumeroSoma;
                    primeiroNumeroSoma = resultado;
                }
                MessageBox.Show(resultadoMensagem + "\n\n" + mensagemResultado);
            }
            else
            {
                MessageBox.Show("Insira um número válido positivo", "Mensagem de Aviso");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Atividade 5: Um script que lê o nome de um aluno e suas três notas, calcula a média e informa se ele está aprovado ou reprovado.
        // OBS: Média maior ou igual a 7 para ser aprovado.

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            string nomeAluno = tBoxNomeAluno.Text;
            double primeiraNota = 0;
            double segundaNota = 0;
            double terceiraNota = 0;

            // Validando se a variável "nomeAluno" não está vazia
            // E se os três textos das TextBoxes de notas podem ser convertidos em valores numéricos "double" com double.TryParse()
            // Caso seja possível, atribuir esses valores para as respectivas variáveis "double" com o "out":

            if (nomeAluno != string.Empty && double.TryParse(tBoxPrimeiraNota.Text, out primeiraNota) 
                && double.TryParse(tBoxSegundaNota.Text, out segundaNota) && double.TryParse(tBoxTerceiraNota.Text, out terceiraNota))
            {

                // Utilizando a variável "mediaFinal" para armazenar a média do aluno
                // Operação com parênteses para que as somas sempre sejam realizadas primeiro e apenas o resultado seja dividido por 3:

                double mediaFinal = (primeiraNota + segundaNota + terceiraNota) / 3;

                // Validando se a variável "mediaFinal" é maior ou igual a 7 para exibir a mensagem de aprovado:

                if(mediaFinal >= 7)
                {

                    // Convertendo a variável "mediaFinal" para o tipo string com .ToString()
                    // Utilizando o formato "F2" para exibir apenas o valor inteiro e as duas primeiras casas decimais da variável:

                    MessageBox.Show("O aluno " + nomeAluno + " está aprovado!\nA média final foi: " + mediaFinal.ToString("F2"), "Mensagem de Aviso");
                }

                // Senão, exibir a mensagem de reprovado:

                else
                {
                    MessageBox.Show("O aluno " + nomeAluno + " está reprovado.\nA média final foi: " + mediaFinal.ToString("F2"), "Mensagem de Aviso");
                }
            }

            // Senão, exibir uma mensagem pedindo para o usuário preencher todos os campos corretamente:

            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
            }
        }

        // Atividade 6: Um script que lê o salário de um funcionário e aplica um aumento de acordo com as seguintes regras:
        // - Salários menores que R$1000 recebem 20% de aumento;
        // - Salários entre R$1000 e R$2000 recebem 15% de aumento;
        // - Salários acima de R$2000 recebem 10% de aumento.

        private void btnCalcularAumentoSalarial_Click(object sender, EventArgs e)
        {
            double salarioInicial = 0;

            // Validando se o texto da TextBox não está vazio
            // Se o texto da TextBox pode ser convertido em um valor numérico "double" com double.TryParse()
            // Caso seja possível, atribuir esse valor para a variável "salarioInicial" com o "out"
            // E se a variável "salarioInicial" possui um valor maior que 0:

            if (tBoxSalario.Text != string.Empty && double.TryParse(tBoxSalario.Text, out salarioInicial) && salarioInicial > 0){

                // Declarando a variável "salarioPosAumento" para armazenar o valor do salário informado pelo usuário após o aumento
                // e a variável "valorAumento" para armazenar o apenas o valor do aumento separadamente:

                double salarioPosAumento = 0;
                double valorAumento = 0;

                // Validando se "salarioInicial" é menor que 1000 para receber 20% de aumento:

                if(salarioInicial < 1000)
                {

                    // Calculando 20% (0,2) do valor da variável "salarioInicial"
                    // e depois somando "salarioInicial" com os 20%, resultando no valor de "salarioPosAumento"

                    // Calculando o valor de "valorAumento", subtraindo o "salarioInicial" de "salarioPosAumento"

                    salarioPosAumento = salarioInicial + (salarioInicial * 0.20);
                    valorAumento = salarioPosAumento - salarioInicial;

                    // Convertendo as variáveis "valorAumento" e "salarioPosAumento" para o tipo string com .ToString()
                    // Utilizando o formato "F2" para exibir apenas o valor inteiro e as duas primeiras casas decimais das variáveis:

                    MessageBox.Show("O salário recebeu um aumento de 20% (R$" + valorAumento.ToString("F2") + ")." +
                        "\nSeu novo valor é R$" + salarioPosAumento.ToString("F2"), "Mensagem de Aviso");
                }

                // Senão, validando se "salarioInicial" é maior ou igual a 1000, e menor ou igual a 2000 para receber 15% de aumento:

                else if (salarioInicial >= 1000 && salarioInicial <= 2000)
                {

                    // Calculando 15% (0,15) do valor da variável "salarioInicial"
                    // e depois somando "salarioInicial" com os 15%, resultando no valor de "salarioPosAumento"

                    salarioPosAumento = salarioInicial + (salarioInicial * 0.15);
                    valorAumento = salarioPosAumento - salarioInicial;
                    MessageBox.Show("O salário recebeu um aumento de 15% (R$" + valorAumento.ToString("F2") + ")." +
                        "\nSeu novo valor é R$" + salarioPosAumento.ToString("F2"), "Mensagem de Aviso");
                }
                else

                // Senão, o salário irá receber 10% de aumento:

                {

                    // Calculando 10% (0,1) do valor da variável "salarioInicial"
                    // e depois somando "salarioInicial" com os 10%, resultando no valor de "salarioPosAumento"

                    salarioPosAumento = salarioInicial + (salarioInicial * 0.1);
                    valorAumento = salarioPosAumento - salarioInicial;
                    MessageBox.Show("O salário recebeu um aumento de 10% (R$" + valorAumento.ToString("F2") + ")." +
                        "\nSeu novo valor é R$" + salarioPosAumento.ToString("F2"), "Mensagem de Aviso");
                }
            }

            // Senão, exibir uma mensagem pedindo para o usuário inserir um salário válido:

            else
            {
                MessageBox.Show("Insira um salário válido.", "Mensagem de Aviso");
            }
        }
    }
}
