namespace P2_gabriel
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.usuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.acesse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(146, 135);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(112, 13);
            this.usuario.TabIndex = 0;
            this.usuario.Text = " INSIRA O USUÁRIO:";
            this.usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 1;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(146, 188);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(99, 13);
            this.senha.TabIndex = 2;
            this.senha.Text = "INSIRA A SENHA :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 3;
            // 
            // acesse
            // 
            this.acesse.Location = new System.Drawing.Point(170, 252);
            this.acesse.Name = "acesse";
            this.acesse.Size = new System.Drawing.Size(88, 23);
            this.acesse.TabIndex = 4;
            this.acesse.Text = "ACESSE";
            this.acesse.UseVisualStyleBackColor = true;
            this.acesse.Click += new System.EventHandler(this.acesse_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 370);
            this.Controls.Add(this.acesse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button acesse;
    }
}

