using BancoVelhaCredi.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoVelhaCredi
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.Show();


            Login_cliente login = new Login_cliente(this);
            login.ShowDialog();










        }






        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelUsuario.Text = "Usuário";
            labelNomeLogado.Text = "Faça seu login";
            pictureBoxAcesso.Image = Properties.Resources.logout;
            Globais.Logado = false;
            Globais.NivelAcesso = "Cliente";
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.Logado == true)
            {
                MessageBox.Show("Voçê já está logado");
            }
            else
            {

                Login_cliente login = new Login_cliente(this);
                login.ShowDialog();
            }
        }



        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.Logado == true)
            {
                if (labelUsuario.Text == "Gerente" || labelUsuario.Text == "Administrador")
                {

                    FormCadastro formCadastro = new FormCadastro();
                    formCadastro.ShowDialog();

                }               
                else
                {
                    MessageBox.Show("Acesso restrito");

                }
                
            }
        }

        private void gerenciamentoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.Logado == true)
            {
                if (labelUsuario.Text == "Administrador")
                {
                    GerenciamentoDados gclientes = new GerenciamentoDados(this);
                    gclientes.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Acesso restrito");


                }


            }
        }
    }
}
