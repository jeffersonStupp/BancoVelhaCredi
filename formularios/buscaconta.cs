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
    public partial class buscaconta : Form
    {
        FormPrincipal form;
        DataTable dt = new DataTable();
        public buscaconta(FormPrincipal f)
        {
            InitializeComponent();
            form = f;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpF = maskedTextBoxCpf.Text;
            if (!maskedTextBoxCpf.MaskCompleted)
            {
                MessageBox.Show("Informe o CPF");
                maskedTextBoxCpf.Clear();
                maskedTextBoxCpf.Focus();
            }
            string sql = "SELECT * FROM T_PF_CADASTRO WHERE T_PF_CPF='" + cpF + "'";
            dt = BANCO.consultar(sql);
            if (dt.Rows.Count == 1)
            {
                textBoxconta.Text = dt.Rows[0].ItemArray[0].ToString();
                textBoxnome.Text = dt.Rows[0].ItemArray[2].ToString();
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }



        }

        private void buscaconta_Load(object sender, EventArgs e)
        {
            maskedTextBoxCpf.Clear();
            maskedTextBoxCpf.Focus();
        }
    }
}
