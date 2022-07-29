using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoVelhaCredi.classes;


namespace BancoVelhaCredi.formularios
{
    public partial class Chaveacesso : Form
    {
        FormPrincipal form;
        DataTable dt = new DataTable();
        public Chaveacesso(FormPrincipal f)
        {
            InitializeComponent();
            form = f;
            labelid.Text = form.labelUsuario.Text;
        }

            

        private void buttonLimpar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
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
                dt = BANCO.consultar(sql);
                if (dt.Rows.Count == 1)
                {
                Globais.ChaveDeAcesso = true;

                this.Close();

            }
            else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }

        private void buttonOk_MouseHover(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.Red;
        }

        private void buttonOk_MouseLeave(object sender, EventArgs e)
        {
            buttonOk.BackColor = DefaultBackColor;
        }
    }
    }


