using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoVelhaCredi.formularios
{
    public partial class Login_cliente : Form
    {
        FormPrincipal form;
        DataTable dt = new DataTable();
        public Login_cliente(FormPrincipal f)
        {
            InitializeComponent();
            form = f;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string conta = textBoxContaLoginCliente.Text;
            string senha = textBoxSenhaLoginCliente.Text;

            if (string.IsNullOrWhiteSpace(conta))
            {
                textBoxContaLoginCliente.Focus();
                MessageBox.Show("Conta não informada");
            }
            else if (string.IsNullOrWhiteSpace(senha))
            {
                textBoxSenhaLoginCliente.Focus();
                MessageBox.Show("Senha não informada");
                return;
            }
            string sql = "SELECT * FROM T_PF_CADASTRO WHERE T_PF_CONTA='" + conta + "'AND T_PF_SENHA='" + senha + "'";
            dt= BANCO.consultar(sql);
            if (dt.Rows.Count==1)
            {
                form.labelNomeLogado.Text = dt.Rows[0].ItemArray[2].ToString();
                form.labelUsuario.Text= dt.Rows[0].ItemArray[15].ToString();
                form.pictureBoxAcesso.Image = Properties.Resources.login;
                
                Globais.Logado = true;
                Globais.NivelAcesso = "Cliente";
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscaconta busca=new buscaconta(form);
            busca.Show();
            
            
        }
    }
}
