
namespace Calculadora
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
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btSomar = new System.Windows.Forms.Button();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.btMultiplica = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumero1
            // 
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.Location = new System.Drawing.Point(29, 32);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(95, 13);
            this.lbNumero1.TabIndex = 0;
            this.lbNumero1.Text = "Digite o 1 Número:";
            // 
            // lbNumero2
            // 
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.Location = new System.Drawing.Point(29, 63);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(95, 13);
            this.lbNumero2.TabIndex = 1;
            this.lbNumero2.Text = "Digite o 2 Número:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(149, 32);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(149, 63);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(29, 171);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(58, 13);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(93, 168);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(156, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // btSomar
            // 
            this.btSomar.Location = new System.Drawing.Point(32, 111);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(38, 30);
            this.btSomar.TabIndex = 6;
            this.btSomar.Text = "+";
            this.btSomar.UseVisualStyleBackColor = true;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // btSubtrair
            // 
            this.btSubtrair.Location = new System.Drawing.Point(93, 111);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(38, 30);
            this.btSubtrair.TabIndex = 7;
            this.btSubtrair.Text = "-";
            this.btSubtrair.UseVisualStyleBackColor = true;
            this.btSubtrair.Click += new System.EventHandler(this.btSubtrair_Click);
            // 
            // btMultiplica
            // 
            this.btMultiplica.Location = new System.Drawing.Point(159, 111);
            this.btMultiplica.Name = "btMultiplica";
            this.btMultiplica.Size = new System.Drawing.Size(38, 30);
            this.btMultiplica.TabIndex = 8;
            this.btMultiplica.Text = "*";
            this.btMultiplica.UseVisualStyleBackColor = true;
            this.btMultiplica.Click += new System.EventHandler(this.btMultiplica_Click);
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(220, 111);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(38, 30);
            this.btDividir.TabIndex = 9;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(32, 222);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(149, 222);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 272);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btMultiplica);
            this.Controls.Add(this.btSubtrair);
            this.Controls.Add(this.btSomar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.lbNumero1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Button btSubtrair;
        private System.Windows.Forms.Button btMultiplica;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
    }
}

