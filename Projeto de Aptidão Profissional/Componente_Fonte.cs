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
    public partial class Componente_Fonte : UserControl
    {
        public Componente_Fonte()
        {
            InitializeComponent();
        }

        //variavel
        private int Numero_Painel;

        //Metodo Load
        private void Componente_Fonte_Load(object sender, EventArgs e)
        {
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
        

        //Metodos Click comprar
        private void Compfonte1_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compfonte1'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compfonte1' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compfonte1' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compfonte1' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compfonte1','NOX - Urano VX 750W', 1, 48.82, '" + PD.Username + "')";

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

        private void Compfonte2_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compfonte2'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compfonte2' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compfonte2' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compfonte2' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compfonte2','NOX - Urano VX 500W', 1, 31.22, '" + PD.Username + "')";

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

        private void Compfonte3_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compfonte3'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compfonte3' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compfonte3' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compfonte3' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compfonte3','NOX - NXS650 650W', 1, 50.64, '" + PD.Username + "')";

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

        private void Compfonte4_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compfonte4'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compfonte4' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compfonte4' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compfonte4' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compfonte4','NOX - Urano TX 850W', 1, 68.17, '" + PD.Username + "')";

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

        private void Compfonte5_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compfonte5'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compfonte5' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compfonte5' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compfonte5' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compfonte5','CORSAIR - HX1000', 1, 188.86, '" + PD.Username + "')";

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

        private void Compfonte6_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compfonte6'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compfonte6' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compfonte6' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compfonte6' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compfonte6','TOOQ - XGE-II 600W', 1, 49.31, '" + PD.Username + "')";

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
