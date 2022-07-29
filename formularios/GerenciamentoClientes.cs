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
    public partial class GerenciamentoDados : Form
    {
        FormPrincipal form;
        public GerenciamentoDados(FormPrincipal f)
        {
            InitializeComponent();
            form = f;
            
        }

        private void GerenciamentoDados_Load(object sender, EventArgs e)
        {
            dataGridViewClientepf.DataSource = BANCO.ObterClientes_conta_cpf();

            dataGridViewClientepf.Columns[0].Width = 50;
            dataGridViewClientepf.Columns[1].Width = 174;
            dataGridViewClientepf.Columns[2].Width = 80;

            labelUsuariog.Text = form.labelUsuario.Text;
            labelNomeLogadog.Text = form.labelNomeLogado.Text;
            if (Globais.Logado == true)
            {
                pictureBoxAcessog.Image = Properties.Resources.login;

            }
            else
            {
                pictureBoxAcessog.Image = Properties.Resources.logout;

            }

        }

        private void dataGridViewClientepf_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            int conlinhas = dvg.SelectedRows.Count;
            if (conlinhas > 0)
            {
                string vconta = dvg.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                dt = BANCO.ObterDadosClientes(vconta);
                labelnconta.Text = dt.Rows[0].Field<string>("T_PF_CONTA").ToString();
                tNome.Text = dt.Rows[0].Field<string>("T_PF_NOME").ToString();
                tCpf.Text = dt.Rows[0].Field<string>("T_PF_CPF").ToString();
                tTelefone.Text = dt.Rows[0].Field<string>("T_PF_TELEFONE").ToString();
                tData.Text = dt.Rows[0].Field<string>("T_PF_DATA_NACIMENTO").ToString();
                tMail.Text = dt.Rows[0].Field<string>("T_PF_EMAIL").ToString();
                tRua.Text = dt.Rows[0].Field<string>("T_PF_RUA").ToString();
                tNumero.Text = dt.Rows[0].Field<string>("T_PF_NUMERO").ToString();
                tBairro.Text = dt.Rows[0].Field<string>("T_PF_BAIRRO").ToString();
                tCidade.Text = dt.Rows[0].Field<string>("T_PF_CIDADE").ToString();
                tCep.Text = dt.Rows[0].Field<string>("T_PF_CEP").ToString();
                tEst.Text = dt.Rows[0].Field<string>("T_PF_ESTADO").ToString();
                tStatus.Text = dt.Rows[0].Field<string>("T_PF_STATUS").ToString();
                tNivel.Text = dt.Rows[0].Field<string>("T_PF_NIVEL_ACESSO").ToString();
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            int linhasel = dataGridViewClientepf.SelectedRows[0].Index;

            ClientePF c = new ClientePF();
            c.conta = labelnconta.Text;
            c.nome = tNome.Text;
            c.cpf = tCpf.Text;
            c.telefone = tTelefone.Text;
            c.datanacimento = tData.Text;
            c.email = tMail.Text;
            c.rua = tRua.Text;
            c.numero = tNumero.Text;
            c.bairro = tBairro.Text;
            c.cidade = tCidade.Text;
            c.cep = tCep.Text;
            c.estado = tEst.Text;
            c.status = tStatus.Text;
            c.nivel = tNivel.Text;


            BANCO.AtualizarDados(c);
            dataGridViewClientepf[1, linhasel].Value =tNome.Text;
            dataGridViewClientepf[2, linhasel].Value =tCpf.Text;
            MessageBox.Show("Dados Alterados");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chaveacesso chave = new Chaveacesso(form);
            chave.ShowDialog();
           
            
           
            if (Globais.ChaveDeAcesso )
            {
                BANCO.ExcluirDados(labelnconta.Text);
                   dataGridViewClientepf.Rows.Remove(dataGridViewClientepf.CurrentRow);
                   MessageBox.Show("Cadastro excluido");
            }
            else
            {
                MessageBox.Show("cadastro não excluido");
            }








            //DialogResult res = MessageBox.Show("CONFIRMA A EXCLUSÃO DO CADASTRO?","Excluir?",MessageBoxButtons.YesNo);
            //if (res==DialogResult.Yes)
            //{
            //    BANCO.ExcluirDados(labelnconta.Text);
            //    dataGridViewClientepf.Rows.Remove(dataGridViewClientepf.CurrentRow);
            //    MessageBox.Show("Cadastro excluido");
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        
    }
}





