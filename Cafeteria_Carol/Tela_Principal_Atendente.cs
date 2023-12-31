﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Cafeteria_Carol
{
    public partial class Tela_Principal_Atendente : Form
    {

        string nomeUsuario = Tela_Cadastro.NomeUsuarioCadastrado;

        public Tela_Principal_Atendente(string nomeUsuario)
        {
            InitializeComponent();
        lb_User.Text = "Bem-vindo, " + nomeUsuario;
            InicializarBordasArredondadas();


        }
        public Tela_Principal_Atendente()
        {
            InitializeComponent();
          


        }

        public void InicializarBordasArredondadas()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 30;
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Top, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }

        private void Tela_Principal_Atendente_Load(object sender, EventArgs e)
        {

        }

        private void bt_Comanda_Click(object sender, EventArgs e)
        {

        }

        private void bt_Pedidos_Click(object sender, EventArgs e)
        {
            Tela_Pedido_Atendente novo = new Tela_Pedido_Atendente();
            novo.Show();
        }

        private void lb_User_Click(object sender, EventArgs e)
        {

        }
        private void Tela_Principal_Usuario_Load(object sender, EventArgs e)
        {
        }

        private void bt_User_Atendente_Click(object sender, EventArgs e)
        {

        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            Tela_Menu_Atendente novo = new Tela_Menu_Atendente();
            novo.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
