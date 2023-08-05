using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_de_Aptidão_Profissional
{
    public partial class Carrinho : UserControl
    {
        //propriedades do form
        public Carrinho()
        {
            InitializeComponent();
        }


        //variavel para armazenar os valores de cada label de preço e de quantidade
        public decimal[] Preços = new decimal[8]; // -------> Preço
        public int[] Quantidades = new int[8]; // ----------> Quantidade

        //variavel de atualização
        public int atualizar;
        

        //Metodo Load do form
        private void Carrinho_Load(object sender, EventArgs e)
        {
            atualizar = 0;
        }


        //Metodos Click dos botões
        private void BotãoEliminar_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            string query;

            MySqlCommand cmd;

            if (Codigo1.Text == "")
            {
                MessageBox.Show("Carrinho Vazio!!");
            }
            else
            {
                if (PreçoTotal.Text == "0 €")
                {
                    MessageBox.Show("Selecione pelo menos um artigo para eliminar!!");
                }
                else
                {

                    //if para verificar se os registos estão checked para eliminar
                    if (Check1.Checked == true)
                    {
                        query = "Delete from Carrinho where CodRegisto = '" + Codigo1.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        Check1.Checked = false;

                    }

                    if (Check2.Checked == true)
                    {
                        query = "Delete from Carrinho where CodRegisto = '" + Codigo2.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        Check2.Checked = false;

                    }

                    if (Check3.Checked == true)
                    {
                        query = "Delete from Carrinho where CodRegisto = '" + Codigo3.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        Check3.Checked = false;

                    }

                    if (Check4.Checked == true)
                    {
                        query = "Delete from Carrinho where CodRegisto = '" + Codigo4.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        Check4.Checked = false;

                    }

                    if (Check5.Checked == true)
                    {
                        query = "Delete from Carrinho where CodRegisto = '" + Codigo5.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        Check5.Checked = false;

                    }

                    if (Check6.Checked == true)
                    {
                        query = "Delete from Carrinho where CodRegisto = '" + Codigo6.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        Check6.Checked = false;

                    }

                    if (Check7.Checked == true)
                    {
                        query = "Delete from Carrinho where CodRegisto = '" + Codigo7.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        Check7.Checked = false;

                    }

                    if (Check8.Checked == true)
                    {
                        query = "Delete from Carrinho where CodRegisto = '" + Codigo8.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        Check8.Checked = false;

                    }

                    PreçoTotal.Text = "0 €";

                    //retira a cor permanente do botão
                    PD.RetirarCor();

                    //Fecha todas as abas que estiverem abertas
                    PD.FecharTudo();

                    //abre a aba dos computadores para venda
                    PD.home1.Width = 815;
                    PD.home1.Height = 575;

                    PD.home1.Left = 242;
                    PD.home1.Top = 66;

                    PD.home1.Visible = true;

                    //altera a cor das labels contidas no form
                    PD.LabelCor();

                    //altera as variaveis para retroceder
                    PD.FormularioAnterior = PD.FormularioAtual;

                    //altera a variavel
                    PD.FormularioAtual = 1;

                    PD.B_Home.MouseLeave += new EventHandler(PD.ControlAberto_Cor);

                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        //Metodo para atualização dos preços e das quantidades
        private void Atualização()
        {
            if (atualizar == 1)
            {
                //Passagem do texto das labels preço para valores decimal
                Preços[0] = Decimal.Parse(Preço1.Text);

                //Soma de todos os valores das labels e apresenta na label de preçototal
                PreçoTotal.Text = "" + Preços[0] ;

                //Passagem do texto das labels quantidades para valores int
                Quantidades[0] = Int32.Parse(Quantidade1.Text);

                //Soma de todos os valores das labels e apresenta na label de quantidadetotal
                PreçoConta.Text = "" + Quantidades[0];
            }
            else if (atualizar == 2)
            {
                //Passagem do texto das labels preço para valores decimal
                Preços[0] = Decimal.Parse(Preço1.Text);
                Preços[1] = Decimal.Parse(Preço2.Text);

                //Soma de todos os valores das labels e apresenta na label de preçototal
                PreçoTotal.Text = String.Concat(Preços[0] + Preços[1] + Preços[2] + Preços[3] + Preços[4] + Preços[5] + Preços[6] + Preços[7]);

                //Passagem do texto das labels quantidades para valores int
                Quantidades[0] = Int32.Parse(Quantidade1.Text);
                Quantidades[1] = Int32.Parse(Quantidade2.Text);

                //Soma de todos os valores das labels e apresenta na label de quantidadetotal
                PreçoConta.Text = String.Concat(Quantidades[0] + Quantidades[1] + Quantidades[2] + Quantidades[3] + Quantidades[4] + Quantidades[5] + Quantidades[6] + Quantidades[7]);
            }
            else if (atualizar == 3)
            {
                //Passagem do texto das labels preço para valores decimal
                Preços[0] = Decimal.Parse(Preço1.Text);
                Preços[1] = Decimal.Parse(Preço2.Text);
                Preços[2] = Decimal.Parse(Preço3.Text);

                //Soma de todos os valores das labels e apresenta na label de preçototal
                PreçoTotal.Text = String.Concat(Preços[0] + Preços[1] + Preços[2] + Preços[3] + Preços[4] + Preços[5] + Preços[6] + Preços[7]);

                //Passagem do texto das labels quantidades para valores int
                Quantidades[0] = Int32.Parse(Quantidade1.Text);
                Quantidades[1] = Int32.Parse(Quantidade2.Text);
                Quantidades[2] = Int32.Parse(Quantidade3.Text);

                //Soma de todos os valores das labels e apresenta na label de quantidadetotal
                PreçoConta.Text = String.Concat(Quantidades[0] + Quantidades[1] + Quantidades[2] + Quantidades[3] + Quantidades[4] + Quantidades[5] + Quantidades[6] + Quantidades[7]);
            }
            else if (atualizar == 4)
            {
                //Passagem do texto das labels preço para valores decimal
                Preços[0] = Decimal.Parse(Preço1.Text);
                Preços[1] = Decimal.Parse(Preço2.Text);
                Preços[2] = Decimal.Parse(Preço3.Text);
                Preços[3] = Decimal.Parse(Preço4.Text);

                //Soma de todos os valores das labels e apresenta na label de preçototal
                PreçoTotal.Text = String.Concat(Preços[0] + Preços[1] + Preços[2] + Preços[3] + Preços[4] + Preços[5] + Preços[6] + Preços[7]);

                //Passagem do texto das labels quantidades para valores int
                Quantidades[0] = Int32.Parse(Quantidade1.Text);
                Quantidades[1] = Int32.Parse(Quantidade2.Text);
                Quantidades[2] = Int32.Parse(Quantidade3.Text);
                Quantidades[3] = Int32.Parse(Quantidade4.Text);

                //Soma de todos os valores das labels e apresenta na label de quantidadetotal
                PreçoConta.Text = String.Concat(Quantidades[0] + Quantidades[1] + Quantidades[2] + Quantidades[3] + Quantidades[4] + Quantidades[5] + Quantidades[6] + Quantidades[7]);
            }
            else if (atualizar == 5)
            {
                //Passagem do texto das labels preço para valores decimal
                Preços[0] = Decimal.Parse(Preço1.Text);
                Preços[1] = Decimal.Parse(Preço2.Text);
                Preços[2] = Decimal.Parse(Preço3.Text);
                Preços[3] = Decimal.Parse(Preço4.Text);
                Preços[4] = Decimal.Parse(Preço5.Text);

                //Soma de todos os valores das labels e apresenta na label de preçototal
                PreçoTotal.Text = String.Concat(Preços[0] + Preços[1] + Preços[2] + Preços[3] + Preços[4] + Preços[5] + Preços[6] + Preços[7]);

                //Passagem do texto das labels quantidades para valores int
                Quantidades[0] = Int32.Parse(Quantidade1.Text);
                Quantidades[1] = Int32.Parse(Quantidade2.Text);
                Quantidades[2] = Int32.Parse(Quantidade3.Text);
                Quantidades[3] = Int32.Parse(Quantidade4.Text);
                Quantidades[4] = Int32.Parse(Quantidade5.Text);

                //Soma de todos os valores das labels e apresenta na label de quantidadetotal
                PreçoConta.Text = String.Concat(Quantidades[0] + Quantidades[1] + Quantidades[2] + Quantidades[3] + Quantidades[4] + Quantidades[5] + Quantidades[6] + Quantidades[7]);
            }
            else if (atualizar == 6)
            {
                //Passagem do texto das labels preço para valores decimal
                Preços[0] = Decimal.Parse(Preço1.Text);
                Preços[1] = Decimal.Parse(Preço2.Text);
                Preços[2] = Decimal.Parse(Preço3.Text);
                Preços[3] = Decimal.Parse(Preço4.Text);
                Preços[4] = Decimal.Parse(Preço5.Text);
                Preços[5] = Decimal.Parse(Preço6.Text);

                //Soma de todos os valores das labels e apresenta na label de preçototal
                PreçoTotal.Text = String.Concat(Preços[0] + Preços[1] + Preços[2] + Preços[3] + Preços[4] + Preços[5] + Preços[6] + Preços[7]);

                //Passagem do texto das labels quantidades para valores int
                Quantidades[0] = Int32.Parse(Quantidade1.Text);
                Quantidades[1] = Int32.Parse(Quantidade2.Text);
                Quantidades[2] = Int32.Parse(Quantidade3.Text);
                Quantidades[3] = Int32.Parse(Quantidade4.Text);
                Quantidades[4] = Int32.Parse(Quantidade5.Text);
                Quantidades[5] = Int32.Parse(Quantidade6.Text);

                //Soma de todos os valores das labels e apresenta na label de quantidadetotal
                PreçoConta.Text = String.Concat(Quantidades[0] + Quantidades[1] + Quantidades[2] + Quantidades[3] + Quantidades[4] + Quantidades[5] + Quantidades[6] + Quantidades[7]);
            }
            else if (atualizar == 7)
            {
                //Passagem do texto das labels preço para valores decimal
                Preços[0] = Decimal.Parse(Preço1.Text);
                Preços[1] = Decimal.Parse(Preço2.Text);
                Preços[2] = Decimal.Parse(Preço3.Text);
                Preços[3] = Decimal.Parse(Preço4.Text);
                Preços[4] = Decimal.Parse(Preço5.Text);
                Preços[5] = Decimal.Parse(Preço6.Text);
                Preços[6] = Decimal.Parse(Preço7.Text);

                //Soma de todos os valores das labels e apresenta na label de preçototal
                PreçoTotal.Text = String.Concat(Preços[0] + Preços[1] + Preços[2] + Preços[3] + Preços[4] + Preços[5] + Preços[6] + Preços[7]);

                //Passagem do texto das labels quantidades para valores int
                Quantidades[0] = Int32.Parse(Quantidade1.Text);
                Quantidades[1] = Int32.Parse(Quantidade2.Text);
                Quantidades[2] = Int32.Parse(Quantidade3.Text);
                Quantidades[3] = Int32.Parse(Quantidade4.Text);
                Quantidades[4] = Int32.Parse(Quantidade5.Text);
                Quantidades[5] = Int32.Parse(Quantidade6.Text);
                Quantidades[6] = Int32.Parse(Quantidade7.Text);

                //Soma de todos os valores das labels e apresenta na label de quantidadetotal
                PreçoConta.Text = String.Concat(Quantidades[0] + Quantidades[1] + Quantidades[2] + Quantidades[3] + Quantidades[4] + Quantidades[5] + Quantidades[6] + Quantidades[7]);
            }
            else if (atualizar == 8)
            {
                //Passagem do texto das labels preço para valores decimal
                Preços[0] = Decimal.Parse(Preço1.Text);
                Preços[1] = Decimal.Parse(Preço2.Text);
                Preços[2] = Decimal.Parse(Preço3.Text);
                Preços[3] = Decimal.Parse(Preço4.Text);
                Preços[4] = Decimal.Parse(Preço5.Text);
                Preços[5] = Decimal.Parse(Preço6.Text);
                Preços[6] = Decimal.Parse(Preço7.Text);
                Preços[7] = Decimal.Parse(Preço8.Text);

                //Soma de todos os valores das labels e apresenta na label de preçototal
                PreçoTotal.Text = String.Concat(Preços[0] + Preços[1] + Preços[2] + Preços[3] + Preços[4] + Preços[5] + Preços[6] + Preços[7]);

                //Passagem do texto das labels quantidades para valores int
                Quantidades[0] = Int32.Parse(Quantidade1.Text);
                Quantidades[1] = Int32.Parse(Quantidade2.Text);
                Quantidades[2] = Int32.Parse(Quantidade3.Text);
                Quantidades[3] = Int32.Parse(Quantidade4.Text);
                Quantidades[4] = Int32.Parse(Quantidade5.Text);
                Quantidades[5] = Int32.Parse(Quantidade6.Text);
                Quantidades[6] = Int32.Parse(Quantidade7.Text);
                Quantidades[7] = Int32.Parse(Quantidade8.Text);

                //Soma de todos os valores das labels e apresenta na label de quantidadetotal
                PreçoConta.Text = String.Concat(Quantidades[0] + Quantidades[1] + Quantidades[2] + Quantidades[3] + Quantidades[4] + Quantidades[5] + Quantidades[6] + Quantidades[7]);
            }
            
        }


        //Metodos Check
        private void Check1_CheckedChanged(object sender, EventArgs e)
        {
            if (Check1.Checked == false)
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade1.Text);

                quantidadeatual = quantidadeatual - quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço1.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual - preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
            else
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade1.Text);

                quantidadeatual = quantidadeatual + quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço1.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual + preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }

        }

        private void Check2_CheckedChanged(object sender, EventArgs e)
        {
            if (Check2.Checked == false)
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade2.Text);

                quantidadeatual = quantidadeatual - quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço2.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual - preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
            else
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade2.Text);

                quantidadeatual = quantidadeatual + quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço2.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual + preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
        }

        private void Check3_CheckedChanged(object sender, EventArgs e)
        {
            if (Check3.Checked == false)
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade3.Text);

                quantidadeatual = quantidadeatual - quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço3.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual - preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
            else
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade3.Text);

                quantidadeatual = quantidadeatual + quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço3.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual + preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
        }

        private void Check4_CheckedChanged(object sender, EventArgs e)
        {
            if (Check4.Checked == false)
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade4.Text);

                quantidadeatual = quantidadeatual - quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço4.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual - preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
            else
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade4.Text);

                quantidadeatual = quantidadeatual + quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço4.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual + preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
        }

        private void Check5_CheckedChanged(object sender, EventArgs e)
        {
            if (Check5.Checked == false)
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade5.Text);

                quantidadeatual = quantidadeatual - quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço5.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual - preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
            else
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade5.Text);

                quantidadeatual = quantidadeatual + quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço5.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual + preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
        }

        private void Check6_CheckedChanged(object sender, EventArgs e)
        {
            if (Check6.Checked == false)
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade6.Text);

                quantidadeatual = quantidadeatual - quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço6.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual - preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
            else
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade6.Text);

                quantidadeatual = quantidadeatual + quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço6.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual + preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
        }

        private void Check7_CheckedChanged(object sender, EventArgs e)
        {
            if (Check7.Checked == false)
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade7.Text);

                quantidadeatual = quantidadeatual - quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço7.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual - preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
            else
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade7.Text);

                quantidadeatual = quantidadeatual + quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço7.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual + preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
        }

        private void Check8_CheckedChanged(object sender, EventArgs e)
        {
            if (Check8.Checked == false)
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade8.Text);

                quantidadeatual = quantidadeatual - quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço8.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual - preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
            else
            {
                int quantidadeatual;
                int quantidade1;

                quantidadeatual = Int32.Parse(label5.Text);

                quantidade1 = Int32.Parse(Quantidade8.Text);

                quantidadeatual = quantidadeatual + quantidade1;

                label5.Text = quantidadeatual + "";

                string preço;
                string preçoatual;
                double preco;
                double precoatual;

                preço = Preço8.Text.ToString().Replace("€", "");
                preco = Double.Parse(preço);

                preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                preçoatual = preçoatual.ToString().Replace("€", "");
                precoatual = Double.Parse(preçoatual);

                precoatual = precoatual + preco;

                PreçoTotal.Text = precoatual.ToString().Replace(",", ".") + " €";
            }
        }

        private void BotãoComprar_Click(object sender, EventArgs e)
        {
            if (Codigo1.Text == "")
            {
                MessageBox.Show("Carrinho Vazio!!");
            }
            else
            {
                if (PreçoTotal.Text == "0 €")
                {
                    MessageBox.Show("Selecione pelo menos um artigo para comprar!!");
                }
                else
                {
                    FLayout PD = (FLayout)this.Parent;

                    string preçoatual;
                    string preçoatual2;
                    double precoatual;
                    double precoatual2;

                    preçoatual = PreçoTotal.Text.ToString().Replace(".", ",");
                    preçoatual = preçoatual.ToString().Replace("€", "");
                    precoatual = Double.Parse(preçoatual);

                    preçoatual2 = PreçoConta.Text.ToString().Replace(".", ",");
                    preçoatual2 = preçoatual2.ToString().Replace("€", "");
                    precoatual2 = Double.Parse(preçoatual2);

                    if (precoatual2 >= precoatual)
                    {
                        double conta;
                        string contastr;

                        conta = precoatual2 - precoatual;

                        contastr = conta.ToString().Replace(",", ".");

                        string query;

                        query = "Update cliente set Dinheiro = " + contastr + " where Username = '" + PD.Username + "'";

                        MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                        MySqlDataReader ler = cmd.ExecuteReader();

                        ler.Close();

                        cmd.ExecuteNonQuery();

                        if (Check1.Checked == true)
                        {
                            query = "Select Quantidade from stock where CodProduto = '" + CodigoProduto1.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            ler = cmd.ExecuteReader();

                            int quantidade = 0;

                            while (ler.Read())
                            {
                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                            }

                            ler.Close();

                            quantidade = quantidade - 1;

                            query = "update stock set Quantidade = " + quantidade + " where CodProduto = '" + CodigoProduto1.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            query = "Delete from Carrinho where CodRegisto = '" + Codigo1.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            Check1.Checked = false;

                        }

                        if (Check2.Checked == true)
                        {
                            query = "Select Quantidade from stock where CodProduto = '" + CodigoProduto2.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            ler = cmd.ExecuteReader();

                            int quantidade = 0;

                            while (ler.Read())
                            {
                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                            }

                            ler.Close();

                            quantidade = quantidade - 1;

                            query = "update stock set Quantidade = " + quantidade + " where CodProduto = '" + CodigoProduto2.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            query = "Delete from Carrinho where CodRegisto = '" + Codigo2.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            Check2.Checked = false;
                        }

                        if (Check3.Checked == true)
                        {
                            query = "Select Quantidade from stock where CodProduto = '" + CodigoProduto3.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            ler = cmd.ExecuteReader();

                            int quantidade = 0;

                            while (ler.Read())
                            {
                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                            }

                            ler.Close();

                            quantidade = quantidade - 1;

                            query = "update stock set Quantidade = " + quantidade + " where CodProduto = '" + CodigoProduto3.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            query = "Delete from Carrinho where CodRegisto = '" + Codigo3.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            Check3.Checked = false;
                        }

                        if (Check4.Checked == true)
                        {
                            query = "Select Quantidade from stock where CodProduto = '" + CodigoProduto4.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            ler = cmd.ExecuteReader();

                            int quantidade = 0;

                            while (ler.Read())
                            {
                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                            }

                            ler.Close();

                            quantidade = quantidade - 1;

                            query = "update stock set Quantidade = " + quantidade + " where CodProduto = '" + CodigoProduto4.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            query = "Delete from Carrinho where CodRegisto = '" + Codigo4.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            Check4.Checked = false;
                        }

                        if (Check5.Checked == true)
                        {
                            query = "Select Quantidade from stock where CodProduto = '" + CodigoProduto5.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            ler = cmd.ExecuteReader();

                            int quantidade = 0;

                            while (ler.Read())
                            {
                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                            }

                            ler.Close();

                            quantidade = quantidade - 1;

                            query = "update stock set Quantidade = " + quantidade + " where CodProduto = '" + CodigoProduto5.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            query = "Delete from Carrinho where CodRegisto = '" + Codigo5.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            Check5.Checked = false;
                        }

                        if (Check6.Checked == true)
                        {
                            query = "Select Quantidade from stock where CodProduto = '" + CodigoProduto6.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            ler = cmd.ExecuteReader();

                            int quantidade = 0;

                            while (ler.Read())
                            {
                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                            }

                            ler.Close();

                            quantidade = quantidade - 1;

                            query = "update stock set Quantidade = " + quantidade + " where CodProduto = '" + CodigoProduto6.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            query = "Delete from Carrinho where CodRegisto = '" + Codigo6.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            Check6.Checked = false;
                        }

                        if (Check7.Checked == true)
                        {
                            query = "Select Quantidade from stock where CodProduto = '" + CodigoProduto7.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            ler = cmd.ExecuteReader();

                            int quantidade = 0;

                            while (ler.Read())
                            {
                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                            }

                            ler.Close();

                            quantidade = quantidade - 1;

                            query = "update stock set Quantidade = " + quantidade + " where CodProduto = '" + CodigoProduto7.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            query = "Delete from Carrinho where CodRegisto = '" + Codigo7.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            Check7.Checked = false;
                        }

                        if (Check8.Checked == true)
                        {
                            query = "Select Quantidade from stock where CodProduto = '" + CodigoProduto8.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            ler = cmd.ExecuteReader();

                            int quantidade = 0;

                            while (ler.Read())
                            {
                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                            }

                            ler.Close();

                            quantidade = quantidade - 1;

                            query = "update stock set Quantidade = " + quantidade + " where CodProduto = '" + CodigoProduto8.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            query = "Delete from Carrinho where CodRegisto = '" + Codigo8.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            Check8.Checked = false;
                        }

                        MessageBox.Show("Compra Realizada com sucesso!!");

                        PreçoTotal.Text = "0 €";

                        //retira a cor permanente do botão
                        PD.RetirarCor();

                        //Fecha todas as abas que estiverem abertas
                        PD.FecharTudo();

                        //abre a aba dos computadores para venda
                        PD.home1.Width = 815;
                        PD.home1.Height = 575;

                        PD.home1.Left = 242;
                        PD.home1.Top = 66;

                        PD.home1.Visible = true;

                        //altera a cor das labels contidas no form
                        PD.LabelCor();

                        //altera as variaveis para retroceder
                        PD.FormularioAnterior = PD.FormularioAtual;

                        //altera a variavel
                        PD.FormularioAtual = 1;

                        PD.B_Home.MouseLeave += new EventHandler(PD.ControlAberto_Cor);

                    }
                    else
                    {
                        MessageBox.Show("Saldo Insuficiente!!");
                    }
                }
            }
        }
    }
}
