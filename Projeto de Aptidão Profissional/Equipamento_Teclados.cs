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
    public partial class Equipamento_Teclados : UserControl
    {
        public Equipamento_Teclados()
        {
            InitializeComponent();
        }


        //variavel
        private int Numero_Painel;

        //Metodo Load
        private void Equipamento_Teclados_Load(object sender, EventArgs e)
        {
            Painel2.Visible = false;

            Numero_Painel = 1;

            Painel1.Location = new Point(0, 74);

            Painel1.Width = 815;
            Painel1.Height = 440;

            Painel1.Visible = true;
        }


        //Metodos Click
        private void L_EquipamentosRetroceder_Click(object sender, EventArgs e)
        {
            //Inicia as variaveis para aceder a outras variaveis
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba das definições
            PD.equipamentos1.Width = 815; //815
            PD.equipamentos1.Height = 575; //575

            PD.equipamentos1.Left = 242;
            PD.equipamentos1.Top = 66;

            PD.equipamentos1.Visible = true;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Equipamentos.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;
                case 2:
                    PD.B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;
                case 3:
                    PD.B_Equipamentos.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;
                case 4:
                    PD.B_Equipamentos.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;
            }

            //altera as labels contidas no form
            PD.LabelCor();

            //altera a variavel
            PD.FormularioAtual = 6;

            //altera o evento do botão
            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Paineis1_Click(object sender, EventArgs e)
        {
            FecharPaineis();

            Numero_Painel = 1;

            Painel1.Location = new Point(0, 74);

            Painel1.Width = 815;
            Painel1.Height = 440;

            Painel1.Visible = true;
        }

        private void L_Paineis2_Click(object sender, EventArgs e)
        {
            FecharPaineis();

            Numero_Painel = 2;

            Painel2.Location = new Point(0, 74);

            Painel2.Width = 815;
            Painel2.Height = 440;

            Painel2.Visible = true;
        }


        //Metodos Mousehover
        private void L_EquipamentosRetroceder_MouseHover(object sender, EventArgs e)
        {
            //Iniciaçização da variavel para aceder a outras variaveis
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            switch (PD.VerMHD)
            {
                case 1:
                    L_EquipamentosRetroceder.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;

                case 2:
                    L_EquipamentosRetroceder.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;

                case 3:
                    L_EquipamentosRetroceder.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    L_EquipamentosRetroceder.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
                    break;

            }
        }

        private void L_Paineis1_MouseHover(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            switch (PD.VerMHD)
            {
                case 1:
                    L_Paineis1.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;

                case 2:
                    L_Paineis1.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;

                case 3:
                    L_Paineis1.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    L_Paineis1.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
                    break;

            }
        }

        private void L_Paineis2_MouseHover(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            switch (PD.VerMHD)
            {
                case 1:
                    L_Paineis2.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;

                case 2:
                    L_Paineis2.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;

                case 3:
                    L_Paineis2.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    L_Paineis2.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
                    break;

            }
        }


        //Metodos MouseLeave
        private void L_EquipamentosRetroceder_MouseLeave(object sender, EventArgs e)
        {
            //Iniciaçização da variavel para aceder a outras variaveis
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            switch (PD.VerMHD)
            {
                case 1:
                    L_EquipamentosRetroceder.ForeColor = Color.FromArgb(PD.computadores1.CorLabels[0], PD.computadores1.CorLabels[1], PD.computadores1.CorLabels[1]);
                    break;

                case 2:
                    L_EquipamentosRetroceder.ForeColor = Color.FromArgb(PD.computadores1.CorLabels[1], PD.computadores1.CorLabels[1], PD.computadores1.CorLabels[0]);
                    break;

                case 3:
                    L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    break;

                case 4:
                    L_EquipamentosRetroceder.ForeColor = Color.FromArgb(PD.computadores1.CorLabels[1], PD.computadores1.CorLabels[0], PD.computadores1.CorLabels[1]);
                    break;

            }
        }

        private void L_Paineis1_MouseLeave(object sender, EventArgs e)
        {
            L_Paineis1.ForeColor = Color.Gray;
        }

        private void L_Paineis2_MouseLeave(object sender, EventArgs e)
        {
            L_Paineis2.ForeColor = Color.Gray;
        }


        //Metodo para fechar os paineis
        private void FecharPaineis()
        {
            switch (Numero_Painel)
            {
                case 1:
                    Painel1.Width = 20;
                    Painel1.Height = 20;

                    Painel1.Location = new Point(200, 10);

                    Painel1.Visible = false;
                    break;

                case 2:
                    Painel2.Width = 20;
                    Painel2.Height = 20;

                    Painel2.Location = new Point(200, 10);

                    Painel2.Visible = false;
                    break;

            }
        }


        //metodos click Comprar
        private void Equipteclado1_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado1'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado1' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado1' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado1' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado1','RAZER - Teclado BlackWidow Ultimate', 1, 122.99, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }

        }

        private void Equipteclado2_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado2'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado2' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado2' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado2' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado2','RAZER - Teclado BlackWidow Chroma V2', 1, 176.62, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }

        private void Equipteclado3_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado3'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado3' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado3' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado3' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado3','RAZER - Teclado BlackWidow X Chroma', 1, 158.22, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }

        private void Equipteclado4_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado4'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado4' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado4' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado4' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado4','LOGITECH - KEYBOARD WIRELESS K375S', 1, 38.94, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }

        private void Equipteclado5_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado5'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado5' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado5' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado5' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado5','TRUST - TECLADO TRUST - GXT850 GAMING', 1, 37.71, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }

        private void Equipteclado6_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado6'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado6' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado6' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado6' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado6','TRUST - TECLADO ZIVA GAMING', 1, 114.67, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }

        private void Equipteclado7_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado7'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado7' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado7' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado7' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado7','TRUST - TECLADO TRUST GXT 830-RW AVONN GAMING', 1, 112.44, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }

        private void Equipteclado8_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado8'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado8' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado8' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado8' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado8','CORSAIR - GamingT K70 LUX Mechanical Keyboard', 1, 33.73, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }

        private void Equipteclado9_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado9'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado9' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado9' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado9' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado9','CORSAIR - GamingT STRAFE Mechanical Gaming Keyboard', 1, 6.87, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }

        private void Equipteclado10_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equipteclado10'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                quantidade = ler.GetInt32(ler.GetOrdinal("quantidade"));
            }

            ler.Close();

            Random rnd = new Random();
            int x = 0;
            int card = rnd.Next(10);

            string codregisto = "" + card;
            x = x + 1;

            do
            {
                card = rnd.Next(10);

                codregisto = codregisto + card;

                x = x + 1;


            } while (x <= 9);


            query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

            cmd = new MySqlCommand(query, PD.ola);

            ler = cmd.ExecuteReader();

            int contar = 0;

            while (ler.Read())
            {
                contar = contar + 1;
            }

            ler.Close();

            if (contar >= 1)
            {
                bool concon = false;

                do
                {
                    x = 0;
                    card = rnd.Next(10);

                    codregisto = "" + card;
                    x = x + 1;

                    do
                    {
                        card = rnd.Next(10);

                        codregisto = codregisto + card;

                        x = x + 1;


                    } while (x <= 9);


                    query = "Select CodRegisto from Carrinho where CodRegisto = '" + codregisto + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    if (contar >= 1)
                    {
                        concon = false;
                    }
                    else
                    {
                        concon = true;
                    }

                } while (concon == true);
            }

            if (quantidade > 0)
            {
                query = "Select CodProduto from Carrinho where CodProduto = 'equipteclado10' and Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(query, PD.ola);

                ler = cmd.ExecuteReader();

                contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    int quantidadeLocal = 0;

                    query = "select quantidade from carrinho where CodProduto = 'equipteclado10' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equipteclado10' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();




                    MessageBox.Show("Update Criado");
                }
                else
                {
                    int quantidadecarrinho = 0;

                    query = "select Username from carrinho where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        contar = contar + 1;
                    }

                    ler.Close();

                    quantidadecarrinho = contar;

                    if (contar >= 8)
                    {
                        MessageBox.Show("Carrinho Cheio!!");
                    }
                    else
                    {
                        query = "insert into Carrinho(CodRegisto, CodProduto, NomeProduto, Quantidade, Preco, Username)" +
                        "values('" + codregisto + "', 'equipteclado10','COOLER MASTER - MasterKeys Lite L RGB Gaming Keyboard', 1, 19.09, '" + PD.Username + "')";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo Criado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Fora de Stock");
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
