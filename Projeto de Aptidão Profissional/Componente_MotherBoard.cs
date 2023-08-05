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
    public partial class Componente_MotherBoard : UserControl
    {
        public Componente_MotherBoard()
        {
            InitializeComponent();
        }


        //variavel
        private int Numero_Painel;

        //Metodo Load
        private void Componente_MotherBoard_Load(object sender, EventArgs e)
        {
            Painel2.Visible = false;
            Painel3.Visible = false;

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
            PD.componentes1.Width = 815; //815
            PD.componentes1.Height = 575; //575

            PD.componentes1.Left = 242;
            PD.componentes1.Top = 66;

            PD.componentes1.Visible = true;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;
                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;
                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;
                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;
            }

            //altera as labels contidas no form
            PD.LabelCor();

            //altera a variavel
            PD.FormularioAtual = 7;

            //altera o evento do botão
            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
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

        private void L_Paineis3_Click(object sender, EventArgs e)
        {
            FecharPaineis();

            Numero_Painel = 3;

            Painel3.Location = new Point(0, 74);

            Painel3.Width = 815;
            Painel3.Height = 440;

            Painel3.Visible = true;
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

        private void L_Paineis3_MouseHover(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            switch (PD.VerMHD)
            {
                case 1:
                    L_Paineis3.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;

                case 2:
                    L_Paineis3.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;

                case 3:
                    L_Paineis3.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    L_Paineis3.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
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

        private void L_Paineis3_MouseLeave(object sender, EventArgs e)
        {
            L_Paineis3.ForeColor = Color.Gray;
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

                case 3:
                    Painel3.Width = 20;
                    Painel3.Height = 20;

                    Painel3.Location = new Point(200, 10);

                    Painel3.Visible = false;
                    break;

            }
        }


        //Metodos Click comprar
        private void Compmother1_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother1'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother1' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother1' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother1' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother1','ASUS - MB H110M-K', 1, 52.48, '" + PD.Username + "')";

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

        private void Compmother2_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother2'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother2' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother2' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother2' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother2','ASUS - H81M-K', 1, 53.04, '" + PD.Username + "')";

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

        private void Compmother3_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother3'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother3' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother3' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother3' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother3','ASUS - PRIME B250M-K', 1, 54.00, '" + PD.Username + "')";

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

        private void Compmother4_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother4'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother4' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother4' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother4' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother4','ASUS - H81M-P PLUS', 1, 55.23, '" + PD.Username + "')";

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

        private void Compmother5_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother5'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother5' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother5' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother5' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother5','ASUS - H110M-D', 1, 55.88, '" + PD.Username + "')";

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

        private void Compmother6_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother6'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother6' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother6' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother6' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother6','ASUS - EX-A320M-GAMING', 1, 78.36, '" + PD.Username + "')";

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

        private void Compmother7_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother7'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother7' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother7' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother7' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother7','ASUS - STRIX B250G', 1, 82.95, '" + PD.Username + "')";

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

        private void Compmother8_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother8'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother8' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother8' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother8' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother8','ASUS - TUF B360M-E', 1, 87.99, '" + PD.Username + "')";

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

        private void Compmother9_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother9'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother9' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother9' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother9' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother9','ASUS - STRIX B250H', 1, 102.48, '" + PD.Username + "')";

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

        private void Compmother10_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother10'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother10' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother10' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother10' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother10','ASUS - MAXIMUS VIII', 1, 178.41, '" + PD.Username + "')";

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

        private void Compmother11_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother11'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother11' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother11' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother11' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother11','ASUS - MAXIMUS X', 1, 271.30, '" + PD.Username + "')";

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

        private void Compmother12_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother12'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother12' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother12' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother12' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother12','ASROCK - H81M-DG4', 1, 47.93, '" + PD.Username + "')";

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

        private void Compmother13_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother13'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother13' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother13' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother13' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother13','ASROCK - A320M', 1, 56.62, '" + PD.Username + "')";

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

        private void Compmother14_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compmother14'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compmother14' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compmother14' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compmother14' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compmother14','ASROCK - J335B-ITX', 1, 69.40, '" + PD.Username + "')";

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
    }
}
