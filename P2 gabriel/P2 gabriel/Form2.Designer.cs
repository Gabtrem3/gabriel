﻿namespace P2_gabriel
{
    partial class form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastro de Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastro de Produto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cadastro de Pedido";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 97);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cadastro de Usuário";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha uma das opções abaixo";
            // 
            // btnconfirma
            // 
            this.btnconfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnconfirma.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirma.Location = new System.Drawing.Point(337, 362);
            this.btnconfirma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnconfirma.Name = "btnconfirma";
            this.btnconfirma.Size = new System.Drawing.Size(88, 28);
            this.btnconfirma.TabIndex = 5;
            this.btnconfirma.Text = "CONFIRMAR ";
            this.btnconfirma.UseVisualStyleBackColor = false;
            this.btnconfirma.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.btnconfirma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.Formulário_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconfirma;
    }
}