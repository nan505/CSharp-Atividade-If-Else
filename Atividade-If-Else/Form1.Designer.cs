namespace Atividade_If_Else
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNumero = new System.Windows.Forms.Label();
            this.tBoxNumero = new System.Windows.Forms.TextBox();
            this.btnVerificarNumero = new System.Windows.Forms.Button();
            this.lbTresNumeros = new System.Windows.Forms.Label();
            this.tBoxPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.tBoxSegundoNumero = new System.Windows.Forms.TextBox();
            this.tBoxTerceiroNumero = new System.Windows.Forms.TextBox();
            this.btnTresNumeros = new System.Windows.Forms.Button();
            this.lbLetra = new System.Windows.Forms.Label();
            this.btnVerificarLetra = new System.Windows.Forms.Button();
            this.tBoxLetra = new System.Windows.Forms.TextBox();
            this.lbMes = new System.Windows.Forms.Label();
            this.tBoxMes = new System.Windows.Forms.TextBox();
            this.btnVerificarDiasMes = new System.Windows.Forms.Button();
            this.btnFibo = new System.Windows.Forms.Button();
            this.tBoxFibo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(11, 16);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(136, 20);
            this.lbNumero.TabIndex = 0;
            this.lbNumero.Text = "Insira um número:";
            // 
            // tBoxNumero
            // 
            this.tBoxNumero.Location = new System.Drawing.Point(15, 39);
            this.tBoxNumero.Name = "tBoxNumero";
            this.tBoxNumero.Size = new System.Drawing.Size(172, 20);
            this.tBoxNumero.TabIndex = 1;
            // 
            // btnVerificarNumero
            // 
            this.btnVerificarNumero.Location = new System.Drawing.Point(193, 35);
            this.btnVerificarNumero.Name = "btnVerificarNumero";
            this.btnVerificarNumero.Size = new System.Drawing.Size(188, 26);
            this.btnVerificarNumero.TabIndex = 2;
            this.btnVerificarNumero.Text = "Verificar se é positivo, negativo ou 0";
            this.btnVerificarNumero.UseVisualStyleBackColor = true;
            this.btnVerificarNumero.Click += new System.EventHandler(this.btnVerificarNumero_Click);
            // 
            // lbTresNumeros
            // 
            this.lbTresNumeros.AutoSize = true;
            this.lbTresNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTresNumeros.Location = new System.Drawing.Point(13, 73);
            this.lbTresNumeros.Name = "lbTresNumeros";
            this.lbTresNumeros.Size = new System.Drawing.Size(299, 20);
            this.lbTresNumeros.TabIndex = 3;
            this.lbTresNumeros.Text = "Insira um número único nos três campos:";
            // 
            // tBoxPrimeiroNumero
            // 
            this.tBoxPrimeiroNumero.Location = new System.Drawing.Point(17, 97);
            this.tBoxPrimeiroNumero.Name = "tBoxPrimeiroNumero";
            this.tBoxPrimeiroNumero.Size = new System.Drawing.Size(100, 20);
            this.tBoxPrimeiroNumero.TabIndex = 4;
            // 
            // tBoxSegundoNumero
            // 
            this.tBoxSegundoNumero.Location = new System.Drawing.Point(123, 97);
            this.tBoxSegundoNumero.Name = "tBoxSegundoNumero";
            this.tBoxSegundoNumero.Size = new System.Drawing.Size(100, 20);
            this.tBoxSegundoNumero.TabIndex = 5;
            // 
            // tBoxTerceiroNumero
            // 
            this.tBoxTerceiroNumero.Location = new System.Drawing.Point(230, 96);
            this.tBoxTerceiroNumero.Name = "tBoxTerceiroNumero";
            this.tBoxTerceiroNumero.Size = new System.Drawing.Size(100, 20);
            this.tBoxTerceiroNumero.TabIndex = 6;
            // 
            // btnTresNumeros
            // 
            this.btnTresNumeros.Location = new System.Drawing.Point(336, 94);
            this.btnTresNumeros.Name = "btnTresNumeros";
            this.btnTresNumeros.Size = new System.Drawing.Size(123, 23);
            this.btnTresNumeros.TabIndex = 7;
            this.btnTresNumeros.Text = "Verificar qual é o maior";
            this.btnTresNumeros.UseVisualStyleBackColor = true;
            this.btnTresNumeros.Click += new System.EventHandler(this.btnTresNumeros_Click);
            // 
            // lbLetra
            // 
            this.lbLetra.AutoSize = true;
            this.lbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetra.Location = new System.Drawing.Point(13, 130);
            this.lbLetra.Name = "lbLetra";
            this.lbLetra.Size = new System.Drawing.Size(138, 20);
            this.lbLetra.TabIndex = 8;
            this.lbLetra.Text = "Informe uma letra:";
            // 
            // btnVerificarLetra
            // 
            this.btnVerificarLetra.Location = new System.Drawing.Point(170, 152);
            this.btnVerificarLetra.Name = "btnVerificarLetra";
            this.btnVerificarLetra.Size = new System.Drawing.Size(182, 23);
            this.btnVerificarLetra.TabIndex = 9;
            this.btnVerificarLetra.Text = "Verificar se é vogal ou consoante";
            this.btnVerificarLetra.UseVisualStyleBackColor = true;
            this.btnVerificarLetra.Click += new System.EventHandler(this.btnVerificarLetra_Click);
            // 
            // tBoxLetra
            // 
            this.tBoxLetra.Location = new System.Drawing.Point(17, 154);
            this.tBoxLetra.MaxLength = 1;
            this.tBoxLetra.Name = "tBoxLetra";
            this.tBoxLetra.Size = new System.Drawing.Size(147, 20);
            this.tBoxLetra.TabIndex = 10;
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(13, 189);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(247, 20);
            this.lbMes.TabIndex = 11;
            this.lbMes.Text = "Informe o mês (Nome ou número)";
            // 
            // tBoxMes
            // 
            this.tBoxMes.Location = new System.Drawing.Point(17, 212);
            this.tBoxMes.Name = "tBoxMes";
            this.tBoxMes.Size = new System.Drawing.Size(162, 20);
            this.tBoxMes.TabIndex = 12;
            // 
            // btnVerificarDiasMes
            // 
            this.btnVerificarDiasMes.Location = new System.Drawing.Point(185, 210);
            this.btnVerificarDiasMes.Name = "btnVerificarDiasMes";
            this.btnVerificarDiasMes.Size = new System.Drawing.Size(167, 23);
            this.btnVerificarDiasMes.TabIndex = 13;
            this.btnVerificarDiasMes.Text = "Verificar quantos dias ele possui";
            this.btnVerificarDiasMes.UseVisualStyleBackColor = true;
            this.btnVerificarDiasMes.Click += new System.EventHandler(this.btnVerificarDiasMes_Click);
            // 
            // btnFibo
            // 
            this.btnFibo.Location = new System.Drawing.Point(170, 320);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(246, 23);
            this.btnFibo.TabIndex = 14;
            this.btnFibo.Text = "Calcular a casa na sequência de Fibonnaci";
            this.btnFibo.UseVisualStyleBackColor = true;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // tBoxFibo
            // 
            this.tBoxFibo.Location = new System.Drawing.Point(49, 323);
            this.tBoxFibo.Name = "tBoxFibo";
            this.tBoxFibo.Size = new System.Drawing.Size(115, 20);
            this.tBoxFibo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBoxFibo);
            this.Controls.Add(this.btnFibo);
            this.Controls.Add(this.btnVerificarDiasMes);
            this.Controls.Add(this.tBoxMes);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.tBoxLetra);
            this.Controls.Add(this.btnVerificarLetra);
            this.Controls.Add(this.lbLetra);
            this.Controls.Add(this.btnTresNumeros);
            this.Controls.Add(this.tBoxTerceiroNumero);
            this.Controls.Add(this.tBoxSegundoNumero);
            this.Controls.Add(this.tBoxPrimeiroNumero);
            this.Controls.Add(this.lbTresNumeros);
            this.Controls.Add(this.btnVerificarNumero);
            this.Controls.Add(this.tBoxNumero);
            this.Controls.Add(this.lbNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tBoxNumero;
        private System.Windows.Forms.Button btnVerificarNumero;
        private System.Windows.Forms.Label lbTresNumeros;
        private System.Windows.Forms.TextBox tBoxPrimeiroNumero;
        private System.Windows.Forms.TextBox tBoxSegundoNumero;
        private System.Windows.Forms.TextBox tBoxTerceiroNumero;
        private System.Windows.Forms.Button btnTresNumeros;
        private System.Windows.Forms.Label lbLetra;
        private System.Windows.Forms.Button btnVerificarLetra;
        private System.Windows.Forms.TextBox tBoxLetra;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.TextBox tBoxMes;
        private System.Windows.Forms.Button btnVerificarDiasMes;
        private System.Windows.Forms.Button btnFibo;
        private System.Windows.Forms.TextBox tBoxFibo;
    }
}

