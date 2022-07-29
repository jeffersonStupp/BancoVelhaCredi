using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using BancoVelhaCredi.classes;

namespace BancoVelhaCredi.formularios
{
    internal class BANCO
    {

        private static SQLiteConnection conexão;

        //CONECTARBANCO===================================================
        private static SQLiteConnection ConectarBanco()
        {
            conexão = new SQLiteConnection("DATA SOURCE=" + Globais.caminhobanco + Globais.nomebanco);
            conexão.Open();
            return conexão;
        }

        //OBTER CLIENTES===========================CONECTARBANCO

        public static DataTable ObterClientes()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var con = ConectarBanco();
                var cmd = con.CreateCommand();

                cmd.CommandText = "SELECT*FROM T_PF_CADASTRO";
                adapter = new SQLiteDataAdapter(cmd.CommandText, con);
                adapter.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //CONSULTAR=============================== OBTER CLIENTES

        public static DataTable consultar(string sql)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var con = ConectarBanco();
                var cmd = con.CreateCommand();

                cmd.CommandText = sql;
                adapter = new SQLiteDataAdapter(cmd.CommandText, con);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //NOVO CLIENTE==============================CONSULTAR

        public static void NovoCliente(ClientePF pf)
        {
            if (ExisteConta(pf))
            {
                MessageBox.Show("Conta já existente");
                return;
            }
            try
            {
                var con = ConectarBanco();
                var cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO T_PF_CADASTRO(T_PF_CONTA,T_PF_SENHA,T_PF_NOME,T_PF_CPF,T_PF_TELEFONE,T_PF_DATA_NACIMENTO,T_PF_EMAIL,T_PF_RUA,T_PF_NUMERO,T_PF_BAIRRO,T_PF_CIDADE,T_PF_CEP,T_PF_ESTADO,T_PF_DATA_CONTA,T_PF_STATUS,T_PF_NIVEL_ACESSO)VALUES(@CONTA,@SENHA,@NOME,@CPF,@TELEFONE,@DATA_NACIMENTO,@EMAIL,@RUA,@NUMERO,@BAIRRO,@CIDADE,@CEP,@ESTADO,@DATA_CONTA,@STATUS,@NIVEL_ACESSO)";

                cmd.Parameters.AddWithValue("@CONTA", pf.conta);
                cmd.Parameters.AddWithValue("@SENHA", pf.senha);
                cmd.Parameters.AddWithValue("@NOME", pf.nome);
                cmd.Parameters.AddWithValue("@CPF", pf.cpf);
                cmd.Parameters.AddWithValue("@DATA_NACIMENTO", pf.datanacimento);
                cmd.Parameters.AddWithValue("@TELEFONE", pf.telefone);
                cmd.Parameters.AddWithValue("@EMAIL", pf.email);
                cmd.Parameters.AddWithValue("@RUA", pf.rua);
                cmd.Parameters.AddWithValue("@NUMERO", pf.numero);
                cmd.Parameters.AddWithValue("@BAIRRO", pf.bairro);
                cmd.Parameters.AddWithValue("@CIDADE", pf.cidade);
                cmd.Parameters.AddWithValue("@CEP", pf.cep);
                cmd.Parameters.AddWithValue("@ESTADO", pf.estado);
                cmd.Parameters.AddWithValue("@DATA_CONTA", pf.dataconta);
                cmd.Parameters.AddWithValue("@STATUS", pf.status);
                cmd.Parameters.AddWithValue("@NIVEL_ACESSO", pf.nivel);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Conta criada com sucesso");
                con.Close();


            }
            catch (Exception ex)
            {

                throw ex;



            }
            //==================/NOVO CLIENTE\=============
        }

        //EXISTE CONTA===============================NOVO CLIENTE


        public static bool ExisteConta(ClientePF pf)
        {
            bool resp;
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();

            var con = ConectarBanco();
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT T_PF_CONTA FROM T_PF_CADASTRO WHERE T_PF_CONTA='" + pf.conta + "'";
            adapter = new SQLiteDataAdapter(cmd.CommandText, con);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                resp = true;
            }
            else
            {
                resp = false;
            }
            con.Close();
            return resp;
            //==================/EXISTE CONTA\=============
        }

        //OBTER CLIENTES===============================EXISTE CONTA

        public static DataTable ObterDadosClientes(string vconta)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                var con = ConectarBanco();
                var cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM T_PF_CADASTRO WHERE T_PF_CONTA=" + vconta;
                adapter = new SQLiteDataAdapter(cmd.CommandText, con);
                adapter.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //==================/OBTER DADOS CLIENTE\=============
        }


        // CONTA CPF=================================OBTER CLIENTES

        public static DataTable ObterClientes_conta_cpf()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT T_PF_CONTA as 'Conta',T_PF_NOME as 'Nome do Titular', T_PF_CPF as 'CPF' FROM T_PF_CADASTRO";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }




        }


        //ATUALIZAR CLIENTE==========================CONTA CPF

        public static void AtualizarDados(ClientePF c)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE T_PF_CADASTRO SET T_PF_NOME='" + c.nome + "', T_PF_CPF='" + c.cpf + "',T_PF_TELEFONE='" + c.telefone + "',T_PF_DATA_NACIMENTO='" + c.datanacimento + "',T_PF_EMAIL='" + c.email + "',T_PF_RUA='" + c.rua + "',T_PF_NUMERO='" + c.numero + "',T_PF_BAIRRO='" + c.bairro + "',T_PF_CIDADE='" + c.cidade + "',T_PF_CEP='" + c.cep + "',T_PF_ESTADO='" + c.estado + "',T_PF_STATUS='" + c.status + "',T_PF_NIVEL_ACESSO='" + c.nivel + "'WHERE T_PF_CONTA=" + c.conta;

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //EXCLUIR CLIENTE============================ATUALIZAR CLIENTE
        public static void ExcluirDados(string c)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM T_PF_CADASTRO WHERE T_PF_CONTA=" + c;





                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //==================/EXCLUIR CLIENTE\=============
        }
    }
}

