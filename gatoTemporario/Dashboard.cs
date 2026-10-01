using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace gatoTemporario
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {


            InitializeComponent();

        }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btncalcados_Click(object sender, EventArgs e)
        {
            Calcados proximaPagina = new Calcados();
           proximaPagina.Show();
            this.Close();
        }

        private void Btncadastro_Click(object sender, EventArgs e)
        {
            Cadastro proximaPagina = new Cadastro();
            proximaPagina.Show();
            this.Close();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void LinkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
