using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gatoTemporario
{
    public partial class Form1 : Form
    {
        string usuario = "";
        string senha = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Usuário: " + usuario);
            //MessageBox.Show("Usuário: " + senha);
             Dashboard proximaPagina = new Dashboard();
             proximaPagina.Show();
             this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            {
                
                TxtSenha.PasswordChar = '*';
                //senha ta pegando certinho
               senha = TxtSenha.Text;
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            //até aqui ta pegando o valor certinho do usuario
            usuario = TxtUsuario.Text;
            
            
          

        }

        private void LblEsqueciSenha_Click(object sender, EventArgs e)
        {
            RedefinirSenha redefinirSenha = new RedefinirSenha();
            redefinirSenha.Show();
            this.Hide();
        }
    }
    }

