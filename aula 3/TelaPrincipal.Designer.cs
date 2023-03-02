namespace aula_3
{
    partial class TelaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnForn = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.plPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnProd);
            this.panel1.Controls.Add(this.btnForn);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Location = new System.Drawing.Point(9, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 349);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(9, 131);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(186, 54);
            this.btnProd.TabIndex = 2;
            this.btnProd.Text = "Produto";
            this.btnProd.UseVisualStyleBackColor = true;
            // 
            // btnForn
            // 
            this.btnForn.Location = new System.Drawing.Point(10, 71);
            this.btnForn.Name = "btnForn";
            this.btnForn.Size = new System.Drawing.Size(186, 54);
            this.btnForn.TabIndex = 1;
            this.btnForn.Text = "Fornecedor";
            this.btnForn.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(9, 11);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(186, 54);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // plPrincipal
            // 
            this.plPrincipal.Location = new System.Drawing.Point(232, 8);
            this.plPrincipal.Name = "plPrincipal";
            this.plPrincipal.Size = new System.Drawing.Size(559, 347);
            this.plPrincipal.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnForn;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.FlowLayoutPanel plPrincipal;
    }
}

