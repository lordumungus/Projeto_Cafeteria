﻿
namespace Cafeteria_Carol
{
    partial class Logar
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
            this.bt_entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_logemail = new System.Windows.Forms.TextBox();
            this.label_logemail = new System.Windows.Forms.Label();
            this.label_logsenha = new System.Windows.Forms.Label();
            this.textBox_logsenha = new System.Windows.Forms.TextBox();
            this.label_semcadastro = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_entrar
            // 
            this.bt_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_entrar.Location = new System.Drawing.Point(400, 300);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(75, 38);
            this.bt_entrar.TabIndex = 0;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.Bt_entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olá,entre com a sua conta para acessar nosso aplicativo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textbox_logemail
            // 
            this.textbox_logemail.Location = new System.Drawing.Point(303, 160);
            this.textbox_logemail.Name = "textbox_logemail";
            this.textbox_logemail.Size = new System.Drawing.Size(271, 26);
            this.textbox_logemail.TabIndex = 2;
            this.textbox_logemail.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label_logemail
            // 
            this.label_logemail.AutoSize = true;
            this.label_logemail.Location = new System.Drawing.Point(244, 160);
            this.label_logemail.Name = "label_logemail";
            this.label_logemail.Size = new System.Drawing.Size(57, 20);
            this.label_logemail.TabIndex = 3;
            this.label_logemail.Text = "E-mail:";
            this.label_logemail.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label_logsenha
            // 
            this.label_logsenha.AutoSize = true;
            this.label_logsenha.Location = new System.Drawing.Point(241, 230);
            this.label_logsenha.Name = "label_logsenha";
            this.label_logsenha.Size = new System.Drawing.Size(60, 20);
            this.label_logsenha.TabIndex = 4;
            this.label_logsenha.Text = "Senha:";
            this.label_logsenha.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox_logsenha
            // 
            this.textBox_logsenha.Location = new System.Drawing.Point(303, 227);
            this.textBox_logsenha.Name = "textBox_logsenha";
            this.textBox_logsenha.Size = new System.Drawing.Size(275, 26);
            this.textBox_logsenha.TabIndex = 5;
            // 
            // label_semcadastro
            // 
            this.label_semcadastro.AutoSize = true;
            this.label_semcadastro.Location = new System.Drawing.Point(299, 371);
            this.label_semcadastro.Name = "label_semcadastro";
            this.label_semcadastro.Size = new System.Drawing.Size(148, 20);
            this.label_semcadastro.TabIndex = 6;
            this.label_semcadastro.Text = "Não tem cadastro ?\r\n";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar.Location = new System.Drawing.Point(453, 364);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(125, 27);
            this.bt_cadastrar.TabIndex = 7;
            this.bt_cadastrar.Text = "Cadastra-se";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // Logar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 456);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label_semcadastro);
            this.Controls.Add(this.textBox_logsenha);
            this.Controls.Add(this.label_logsenha);
            this.Controls.Add(this.label_logemail);
            this.Controls.Add(this.textbox_logemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_entrar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Logar";
            this.Text = "Logar";
            this.Load += new System.EventHandler(this.Logar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_logemail;
        private System.Windows.Forms.Label label_logemail;
        private System.Windows.Forms.Label label_logsenha;
        private System.Windows.Forms.TextBox textBox_logsenha;
        private System.Windows.Forms.Label label_semcadastro;
        private System.Windows.Forms.Button bt_cadastrar;
    }
}