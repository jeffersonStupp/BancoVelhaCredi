using BancoVelhaCredi.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp;

namespace BancoVelhaCredi.formularios
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }
        private void buttonpessoal_Click_1(object sender, EventArgs e)
        {
            Random conta = new Random();
            Globais.conta = Convert.ToString(conta.Next(1000, 9999));




            CadastrarPessoais();


        }



        private void buttonendereco_Click(object sender, EventArgs e)
        {
            CadastrarEnderecos();
        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            CadastrarConta();
        }




        public void CadastrarPessoais()
        {//========================================= nome
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Informe o nome");
                textBoxNome.Focus();
            }
            else
            {
                //========================================= cpf
                if (!maskedTextBoxCpf.MaskCompleted)
                {
                    MessageBox.Show("Informe o CPF");
                    maskedTextBoxCpf.Clear();
                    maskedTextBoxCpf.Focus();
                }
                else
                {
                    //========================================= telefone
                    if (!maskedTextBoxTelefone.MaskCompleted)
                    {
                        MessageBox.Show("Informe o Telefone");
                        maskedTextBoxTelefone.Clear();
                        maskedTextBoxTelefone.Focus();
                    }
                    else
                    {
                        //========================================= data
                        if (!maskedTextBoxData.MaskCompleted)
                        {
                            MessageBox.Show("Informe a data de nascimento");
                            maskedTextBoxData.Clear();
                            maskedTextBoxData.Focus();
                        }
                        else
                        {

                            //========================================= email
                            if (textBoxMail.Text == "")
                            {
                                MessageBox.Show("Informe o e-mail");
                                textBoxMail.Clear();
                                textBoxMail.Focus();
                            }
                            else
                            {

                                labelNome.Text = textBoxNome.Text;
                                labelCpf.Text = maskedTextBoxCpf.Text;
                                labeltelefone.Text = maskedTextBoxTelefone.Text;
                                labeldatanacimento.Text = maskedTextBoxTelefone.Text;
                                labelemail.Text = textBoxMail.Text;


                                groupBoxDadosPessois.Visible = false;
                                groupBoxdadospreenchidos.Visible = true;
                                groupBoxEnd.Visible = true;
                                picturePessoal.Visible = true;
                                progressBar1.Value = 1;


                                textBoxRua.Focus();



                            }

                        }
                    }

                }
            }

        }




        public void CadastrarEnderecos()
        {
            //========================================= rua
            textBoxRua.Focus();
            if (textBoxRua.Text == "")
            {
                MessageBox.Show("Informe a rua");
                textBoxRua.Focus();
            }
            else
            {
                //========================================= numero
                if (textBoxNumero.Text == "")
                {
                    MessageBox.Show("Informe o numero da rua");
                    textBoxNumero.Focus();
                }
                else
                {
                    //========================================= bairro
                    if (textBoxBairro.Text == "")
                    {
                        MessageBox.Show("Informe o bairro");
                        textBoxBairro.Focus();
                    }
                    else
                    {
                        //========================================= cidade
                        if (textBoxCidade.Text == "")
                        {
                            MessageBox.Show("Informe a cidade");
                            textBoxCidade.Focus();

                        }
                        else
                        {
                            //========================================= cep
                            if (!maskedTextBoxCep.MaskCompleted)
                            {
                                maskedTextBoxCep.Text = (" CEP não informado");
                            }

                            else
                            {
                                //========================================= estado
                                if (comboBoxEst.Text == "")
                                {
                                    MessageBox.Show("Informe o estado");

                                }
                                else
                                {





                                    labelRua.Text = textBoxRua.Text;
                                    labelNumero.Text = textBoxNumero.Text;
                                    labelBairro.Text = textBoxBairro.Text;
                                    labelCidade.Text = textBoxCidade.Text;
                                    labelCep.Text = maskedTextBoxCep.Text;
                                    labelestado.Text = comboBoxEst.Text;
                                    labelconta.Text = Globais.conta;


                                    buttoncancelar.Visible = false;

                                    groupBoxEnd.Visible = false;
                                    groupBoxdadospreenchidos.Visible = true;
                                    groupBoxEndPrenchido.Visible = true;
                                    progressBar1.Value = 2;
                                    groupBoxConta.Visible = false;
                                    groupBoxprotocolo.Visible = true;
                                    textBoxSenha.Focus();
                                    Random chavegerada = new Random();
                                    Globais.chavegerada = Convert.ToString(chavegerada.Next(1000, 9999));
                                }









                            }



                        }
                    }
                }
            }
        }

        public void CadastrarConta()
        {



            Globais.senha = textBoxSenha.Text;
            Globais.confirm = textBoxconfirm.Text;
            if (Globais.senha != Globais.confirm || Globais.senha.Length != 6)
            {
                MessageBox.Show("Senha incorreta");

                textBoxSenha.Clear();
                textBoxconfirm.Clear();
                textBoxSenha.Focus();
            }
            else

            {
                progressBar1.Value = 3;

                ClientePF clientepf = new ClientePF();

                clientepf.conta = Globais.conta;
                clientepf.senha = Globais.senha;
                clientepf.nome = textBoxNome.Text;
                clientepf.cpf = maskedTextBoxCpf.Text;
                clientepf.telefone = maskedTextBoxTelefone.Text;
                clientepf.datanacimento = maskedTextBoxData.Text;
                clientepf.email = textBoxMail.Text;
                clientepf.rua = textBoxRua.Text;
                clientepf.numero = textBoxNumero.Text;
                clientepf.bairro = textBoxBairro.Text;
                clientepf.cidade = textBoxCidade.Text;
                clientepf.cep = maskedTextBoxCep.Text;
                clientepf.estado = comboBoxEst.Text;
                clientepf.dataconta = DateTime.Today.ToString("dd/MM/yyyy");
                clientepf.status = "A";
                clientepf.nivel = "Cliente PF";











                BANCO.NovoCliente(clientepf);
                this.Close();


                //textBoxNome.Clear();
                //maskedTextBoxCpf.Clear();
                //maskedTextBoxTelefone.Clear();
                //maskedTextBoxData.Clear();
                //textBoxMail.Clear();



            }
        }



        private void buttoncancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // FileStream arquivopdf = new FileStream("proposta.pdf", FileMode.Create);
                string nomearquivo = Globais.caminho + "\\proposta.pdf";
                FileStream arquivopdf = new FileStream(nomearquivo , FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorpdf = PdfWriter.GetInstance(doc, arquivopdf);

                string dados = "";

                Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Underline));
                paragrafo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                paragrafo.Add("PROPOSTA DE ADESÃO");

                Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Italic));
                paragrafo2.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                paragrafo2.Add("\n");
                iTextSharp.text.Image logotipo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logotipo.jpg");
                logotipo.ScaleToFit(120f, 100f);
                logotipo.Alignment = Element.ALIGN_CENTER;

                Paragraph paragrafo3 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Italic));
                paragrafo3.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                paragrafo3.Add("\n\t1- Parte integrante e complementar do contrato de abertura de Conta Corrente emitido em " + DateTime.Today.ToString("dd/MM/yyyy") + ".");

                Paragraph paragrafo4 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Italic));
                paragrafo4.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                paragrafo4.Add("\n\t Credor Caucionado:VELHACREDI S/A, assim doravante, o Banco VELHACREDI S/A, pessoa jurídica de direito privado, devidamente inscrita no CNPJ sob o nº 98.765.543/0001-21, com sede na rua Av.Cruzeiro do Sul, nº 2418, Bairro Carindé , Cidade São Paulo,SP.\n");

                Paragraph paragrafo5 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Italic));
                paragrafo5.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                paragrafo5.Add("\n\tCaucionante: Assim denominada doravante a " + textBoxNome.Text + ", portador do CPF nº " + maskedTextBoxCpf.Text + ", residente na rua " + textBoxRua.Text + ", nº " + textBoxNumero.Text + ", no bairro " + textBoxBairro.Text + ", na cidade de " + textBoxCidade.Text + "," + comboBoxEst.Text + ".\n");


                Paragraph paragrafo6 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Italic));
                paragrafo5.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                paragrafo5.Add("\n\t 2- Em garantia e para reforço daquelas constituídas no Instrumento mencionado no Quadro 01 acima, a CAUCIONANTE, entrega neste ato ao em CAUÇÃO, em valores equivalentes ao percentual especificado no Quadro 02, os DIREITOS CREDITÓRIOS, integrais, oriundos de diversos contratos firmados com terceiros, conforme relação anexa a este termo, devidamente rubricada pelas partes, obrigando-se a CAUCIONANTE desde já, a manter sempre integra e vincenda a garantia ora pactuada. A CAUCIONANTE, obriga-se ainda a atender de imediato, qualquer solicitação do para complementação da garantia e/ou substituição de quaisquer dos contratos especificados na relação anexa.2 Por força da caução ora formalizada, a CAUCIONANTE, assume a responsabilidade de mandatària da cobrança dos créditos caucionados, devendo repassar os valores recebido ao para pagamento total ou parcial das obrigações assumidas na operação ora formalizada, e que não forem localizadas nas datas avençadas.Para tanto, dois diretores da sociedade assumem neste ato, por suas assinaturas, o encargo de fiéis depositários do produto em cobrança desses créditos caucionados, devidamente qualificados no preàmbulo, os quais ficarão responsáveis pela efetivação dos recebimentos e guarda das respectivas quantias, em valores suficientes para o cumprimento de todas as obrigações principais e acessórias assumidas pela CEDENTE, no instrumento mencionado no Quadro 01. do qual este termo faz parte integrante.O na qualidade de CREDOR CAUCIONADO, poderá a qualquer tempo e a seu exclusivo critério, exigir dos fiéis depositarios, a entrega dos valores recebidos ou que venham receber relativas à presente caução em quantias suficientes para o cumprimento das obrigações assumidas pelo CEDENTE na operação em referència ficando os mesmos congados ao prazo estipulado.");

                Paragraph paragrafo7 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Italic));
                paragrafo7.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                paragrafo7.Add("\n\t 3- O presente termo passa automaticamente, a fazer parte integrante des instrumentos de formalização das operações de créditos avengadas vigorando até o vencimento e/ou hquidação integral de todas as obrigações assumidas pela CEDENTE");


                Paragraph paragrafo8 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Italic));
                paragrafo8.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                paragrafo8.Add("\n\t 4- E por estarem assim justas e acertadas, as partes firmam este termo em duas vias, de igual teor e para o mesmo fim, juntamente com duas testemunhas.");

                Paragraph paragrafo9 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Italic));
                paragrafo9.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                paragrafo9.Add("\n\t E, por estarem firmados.\n\n");

                PdfPTable tabela = new PdfPTable(3);
                tabela.DefaultCell.FixedHeight = 20;
                tabela.DefaultCell.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                tabela.DefaultCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                tabela.DefaultCell.BorderColor = BaseColor.White;


                Paragraph prot = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Bold));
                prot.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
                prot.Add("Protocolo: " + Globais.chavegerada);





                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");
                tabela.AddCell("");

                tabela.AddCell("_______________________");
                tabela.AddCell("");
                tabela.AddCell("_______________________");


                tabela.AddCell("VelhaCredi");
                tabela.AddCell("");
                tabela.AddCell(textBoxNome.Text);











                doc.Open();

                doc.Add(logotipo);
                doc.Add(paragrafo);
                doc.Add(paragrafo2);
                doc.Add(paragrafo3);
                doc.Add(paragrafo4);
                doc.Add(paragrafo5);
                doc.Add(paragrafo6);
                doc.Add(paragrafo7);
                doc.Add(paragrafo8);
                doc.Add(paragrafo9);
                doc.Add(tabela);
                doc.Add(prot);


                doc.Close();
                arquivopdf.Dispose();
                System.Diagnostics.Process.Start("proposta.pdf");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonprotocolo_Click(object sender, EventArgs e)
        {
            if (textBoxprotocolo.Text == Globais.chavegerada)
            {
                groupBoxConta.Visible = true;
                groupBoxprotocolo.Visible = false;
            }
            else
            {

                MessageBox.Show("O protocolo informado não condiz com o documento ");
                textBoxprotocolo.Clear();
                textBoxprotocolo.Focus();
            }
        }


    }

}





