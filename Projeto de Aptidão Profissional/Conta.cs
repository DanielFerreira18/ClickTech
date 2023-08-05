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
    public partial class Conta : UserControl
    {
        //propriedades do form
        public Conta()
        {
            InitializeComponent();
           
        }


        //Variaveis para aceder a outras variaveis do form Computadores, Definições
        Definições PD2 = new Definições();
        Computadores PD3 = new Computadores();

        string query;

        //Metodos Click
        private void L_Alterar_Foto_Click(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            PD.definições1.iniciapainel = 1;

            PD.definições1.BotãoAlteração = 5;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba das definições
            PD.definições1.Width = 815; //815
            PD.definições1.Height = 575; //575

            PD.definições1.Left = 242;
            PD.definições1.Top = 66;

            PD.definições1.Visible = true;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Definições.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;
                case 2:
                    PD.B_Definições.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;
                case 3:
                    PD.B_Definições.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;
                case 4:
                    PD.B_Definições.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
                    break;
            }
            
            //altera as labels contidas no form
            PD.LabelCor();

            //altera a variavel
            PD.FormularioAtual = 4;

            PD.B_Definições.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Alterar_User_Click(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            PD.definições1.iniciapainel = 1;

            PD.definições1.BotãoAlteração = 2;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba das definições
            PD.definições1.Width = 815; //815
            PD.definições1.Height = 575; //575

            PD.definições1.Left = 242;
            PD.definições1.Top = 66;

            PD.definições1.Visible = true;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Definições.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;
                case 2:
                    PD.B_Definições.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;
                case 3:
                    PD.B_Definições.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;
                case 4:
                    PD.B_Definições.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
                    break;
            }

            //altera as labels contidas no form
            PD.LabelCor();

            //altera a variavel
            PD.FormularioAtual = 4;

            PD.B_Definições.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Alterar_Pass_Click(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            PD.definições1.iniciapainel = 1;

            PD.definições1.BotãoAlteração = 3;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba das definições
            PD.definições1.Width = 815; //815
            PD.definições1.Height = 575; //575

            PD.definições1.Left = 242;
            PD.definições1.Top = 66;

            PD.definições1.Visible = true;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Definições.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;
                case 2:
                    PD.B_Definições.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;
                case 3:
                    PD.B_Definições.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;
                case 4:
                    PD.B_Definições.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
                    break;
            }

            //altera as labels contidas no form
            PD.LabelCor();

            //altera a variavel
            PD.FormularioAtual = 4;

            PD.B_Definições.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Alterar_Email_Click(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            PD.definições1.iniciapainel = 1;

            PD.definições1.BotãoAlteração = 4;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba das definições
            PD.definições1.Width = 815; //815
            PD.definições1.Height = 575; //575

            PD.definições1.Left = 242;
            PD.definições1.Top = 66;

            PD.definições1.Visible = true;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Definições.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;
                case 2:
                    PD.B_Definições.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;
                case 3:
                    PD.B_Definições.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;
                case 4:
                    PD.B_Definições.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
                    break;
            }

            //altera as labels contidas no form
            PD.LabelCor();

            //altera a variavel
            PD.FormularioAtual = 4;

            PD.B_Definições.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void AdicionarComp(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            query = "Select * from acessos where Username = '" + LabelUser.Text+ "'";

            MySqlCommand cmd = new MySqlCommand(query, PD.ola);

            MySqlDataReader Ler = cmd.ExecuteReader();

            int contar = 0;

            while (Ler.Read())
            {
                contar = contar + 1;

            }

            Ler.Close();

            if (contar == 1)
            {
                query = "Select * from acessos where Username = '" + LabelUser.Text + "' and Password = '" + LabelPass.Text + "'";

                cmd = new MySqlCommand(query, PD.ola);

                Ler = cmd.ExecuteReader();

                int contar2 = 0;

                while (Ler.Read())
                {
                    contar2 = contar2 + 1;

                }

                Ler.Close();

                if (contar2 == 1)
                {
                    query = "Select * from acessos where Username = '" + LabelUser.Text + "' and Password = '" + LabelPass.Text + "' and Pergunta = '" + Labelpergunta.Text + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    Ler = cmd.ExecuteReader();

                    int contar3 = 0;

                    while (Ler.Read())
                    {
                        contar3 = contar3 + 1;

                    }

                    Ler.Close();

                    if (contar3 == 1)
                    {
                        string TotalDinheiro;
                        double totaldinheiro;
                        double dinheiro;
                        decimal Dinheiro = 0;

                        TotalDinheiro = (LabelEuros.Text + "," + LabelCentimos.Text);

                        totaldinheiro = Convert.ToDouble(TotalDinheiro);

                        query = "Select Dinheiro from cliente where Username = '" + LabelUser.Text +"'";

                        cmd = new MySqlCommand(query, PD.ola);

                        Ler = cmd.ExecuteReader();

                        while (Ler.Read())
                        {
                            Dinheiro = Ler.GetDecimal(Ler.GetOrdinal("Dinheiro"));

                        }

                        Ler.Close();

                        dinheiro = (double) Dinheiro;

                        totaldinheiro = totaldinheiro + dinheiro;

                        string ne;

                        ne = totaldinheiro.ToString().Replace(",", ".");

                        TotalDinheiro = ne;

                        query = "Update cliente set dinheiro = " + TotalDinheiro + " where Username = '" + LabelUser.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        cmd.ExecuteNonQuery();

                        label12.Text = TotalDinheiro + " €";

                        Painel1.Width = 0;
                        Painel1.Height = 0;

                        Painel1.Location = new Point(0, 0);
                    }
                    else
                    {
                        MessageBox.Show("Resposta Errada!!");
                    }

                }
                else
                {
                    MessageBox.Show("Password Errada!!");
                }

            }
            else
            {
                MessageBox.Show("Username Errado!!");
            }

        }


        //Metodos MouseHover
        private void L_Alterar_Foto_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Alterar_Foto.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Alterar_Foto.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Alterar_Foto.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Alterar_Foto.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void L_Alterar_User_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Alterar_User.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Alterar_User.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Alterar_User.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Alterar_User.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void L_Alterar_Pass_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Alterar_Pass.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Alterar_Pass.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Alterar_Pass.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Alterar_Pass.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void L_Alterar_Email_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Alterar_Email.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Alterar_Email.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Alterar_Email.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Alterar_Email.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }


        //Metodos MouseLeave
        private void L_Alterar_Foto_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Alterar_Foto.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Alterar_Foto.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Alterar_Foto.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Alterar_Foto.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void L_Alterar_User_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Alterar_User.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Alterar_User.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Alterar_User.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Alterar_User.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void L_Alterar_Pass_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Alterar_Pass.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Alterar_Pass.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Alterar_Pass.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Alterar_Pass.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void L_Alterar_Email_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Alterar_Email.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Alterar_Email.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Alterar_Email.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Alterar_Email.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Painel1.Width = 0;
            Painel1.Height = 0;

            Painel1.Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Painel1.Width = 502;
            Painel1.Height = 127;

            Painel1.Location = new Point(311, 436);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label16.UseSystemPasswordChar = false;
            }
            else
            {
                label16.UseSystemPasswordChar = true;
            }
        }

        private void label16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
