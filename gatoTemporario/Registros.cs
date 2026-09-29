using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gatoTemporario
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void Btncadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = txtBuscar;
            pictureBox2.Location = new Point(50, 50);
            pictureBox2.BackColor = Color.Transparent;
        }

        private void LinkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
