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
    public partial class Equipamento_Ratos : UserControl
    {
        public Equipamento_Ratos()
        {
            InitializeComponent();
        }

        //variavel
        private int Numero_Painel;

        //Metodo Load
        private void Equipamento_Rato_Load(object sender, EventArgs e)
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
        private void Equiprato1_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato1'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato1' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato1' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato1' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato1','ASUS - Rato ASUS ROG SPATHA WIRELESS', 1, 179.19, '" + PD.Username + "')";

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

        private void Equiprato2_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato2'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato2' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato2' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato2' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato2','LIFETECH - MOUSE BASIC BLACK SCROLL', 1, 4.56, '" + PD.Username + "')";

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

        private void Equiprato3_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato3'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato3' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato3' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato3' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato3','MARS GAMING - Mouse MM1 Gaming', 1, 8.89, '" + PD.Username + "')";

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

        private void Equiprato4_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato4'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato4' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato4' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato4' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato4','MICROSOFT - Comfort Mouse', 1, 16.25, '" + PD.Username + "')";

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

        private void Equiprato5_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato5'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato5' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato5' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato5' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato5','CONCEPTRONIC - Optical Wireless Travel Mouse', 1, 8.88, '" + PD.Username + "')";

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

        private void Equiprato6_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato6'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato6' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato6' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato6' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato6','RAZER - Gaming Mouse Abyssus', 1, 46.87, '" + PD.Username + "')";

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

        private void Equiprato7_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato7'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato7' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato7' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato7' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato7','RAZER - Rato MAMBA TOURNAMENT EDITION', 1, 79.86, '" + PD.Username + "')";

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

        private void Equiprato8_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato8'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato8' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato8' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato8' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato8','RAZER - Rato NAGA CHROMA ERGONOMIC MMO GAMING', 1, 90.75, '" + PD.Username + "')";

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

        private void Equiprato9_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            int quantidade = 0;
            string query = "";

            query = "Select quantidade from stock where CodProduto = 'equiprato9'";

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
                query = "Select CodProduto from Carrinho where CodProduto = 'equiprato9' and Username = '" + PD.Username + "'";

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

                    query = "select quantidade from carrinho where CodProduto = 'equiprato9' and Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    contar = 0;

                    while (ler.Read())
                    {
                        quantidadeLocal = ler.GetInt32(ler.GetOrdinal("quantidade"));
                    }

                    ler.Close();

                    quantidadeLocal = quantidadeLocal + 1;

                    query = "Update Carrinho set Quantidade = " + quantidadeLocal + " where CodProduto = 'equiprato9' and Username = '" + PD.Username + "'";

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
                        "values('" + codregisto + "', 'equiprato9','RAZER - Mouse Naga Trinity', 1, 101.88, '" + PD.Username + "')";

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
