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
    public partial class Cadastro : Form
    {
        int Codigodebarras = 0;
        string lado = "";
        string marca = "";
        string modelo = "";
        string numero = "";
        string cor = "";
        string categoria = "";
        string origem = "";
        string observacoes = "";

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            Dashboard proximaPagina = new Dashboard();
            proximaPagina.Show();
            this.Close();
        }

        private void Btncalcados_Click(object sender, EventArgs e)
        {
            Calcados proximaPagina = new Calcados();
            proximaPagina.Show();
            this.Close();
        }

        public void Btnenviar_Click(object sender, EventArgs e)
        {
            Codigodebarras = int.Parse(TxtCodigoBarras.Text);
            if (RbEsquerdo.Checked)
            {
                lado = "esquerdo";

            }
            else {
                lado = "direito";
            }
            marca = CmbMarca.Text;
            modelo = TxtModelo.Text;
            numero = CmbNumero.Text;  
            cor = CmbCor.Text;
            categoria = CmbCategoria.Text;
            origem = CmbOrigem.Text;
            observacoes = Txtobservacoes.Text;
        }

        private void LinkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
