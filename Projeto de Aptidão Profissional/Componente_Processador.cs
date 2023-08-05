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
    public partial class Componente_Processador : UserControl
    {
        public Componente_Processador()
        {
            InitializeComponent();
        }

        //variavel
        private int Numero_Painel;


        //Metodo Load
        private void Componente_Processador_Load(object sender, EventArgs e)
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
        private void CompCPU1_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU1'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU1' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU1' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU1' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU1','INTEL - I3-7300', 1, 164.99, '" + PD.Username + "')";

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

        private void CompCPU2_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU2'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU2' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU2' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU2' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU2','INTEL - I3-8300', 1, 150.99, '" + PD.Username + "')";

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

        private void CompCPU3_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU3'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU3' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU3' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU3' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU3','INTEL - I5-7600', 1, 251.99, '" + PD.Username + "')";

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

        private void CompCPU4_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU4'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU4' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU4' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU4' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU4','INTEL - I5-8400', 1, 163.70, '" + PD.Username + "')";

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

        private void CompCPU5_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU5'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU5' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU5' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU5' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU5','INTEL - I5-8500', 1, 197.99, '" + PD.Username + "')";

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

        private void CompCPU6_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU6'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU6' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU6' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU6' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU6','INTEL - I7-6700', 1, 307.67, '" + PD.Username + "')";

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

        private void CompCPU7_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU7'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU7' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU7' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU7' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU7','INTEL - I7-6700K', 1, 298.27, '" + PD.Username + "')";

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

        private void CompCPU8_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU8'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU8' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU8' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU8' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU8','INTEL - I7-7700', 1, 343.99, '" + PD.Username + "')";

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

        private void CompCPU9_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU9'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU9' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU9' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU9' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU9','INTEL - I7-7700K', 1, 393.99, '" + PD.Username + "')";

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

        private void CompCPU10_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU10'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU10' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU10' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU10' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU10','INTEL - I7-8700', 1, 276.98, '" + PD.Username + "')";

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

        private void CompCPU11_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU11'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU11' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU11' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU11' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU11','AMD - FX-6300', 1, 67.56, '" + PD.Username + "')";

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

        private void CompCPU12_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU12'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU12' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU12' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU12' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU12','AMD - A10-7890K', 1, 162.85, '" + PD.Username + "')";

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

        private void CompCPU13_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU13'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU13' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU13' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU13' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU13','AMD - RYZEN 7 1700X', 1, 232.80, '" + PD.Username + "')";

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

        private void CompCPU14_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU14'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU14' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU14' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU14' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU14','AMD - RYZEN 7 1800X', 1, 250.85, '" + PD.Username + "')";

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

        private void CompCPU15_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'compCPU15'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'compCPU15' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'compCPU15' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'compCPU15' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'compCPU15','AMD - RYZEN 5 1500X', 1, 144.82, '" + PD.Username + "')";

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
