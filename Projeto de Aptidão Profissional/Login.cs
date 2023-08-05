using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Projeto_de_Aptidão_Profissional
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //metodo para criar a elipse
        private static extern IntPtr Cantos
       (
           int nLeftRect, // Coordenada x do canto superior esquerdo
           int nTopRect, // Coordenada y do canto inferior esquerdo
           int nRightRect, // Coordenada x do canto inferior direito
           int nBottomRect, // Coordenada y do canto inferior esquerdo
           int nWidthEllipse, // Altura da ellipse
           int nHeightEllipse // Comprimento da ellipse
       );


        //Propriedades do form
        public Login()
        {
            InitializeComponent();

            //desenha os cantos
            Region = System.Drawing.Region.FromHrgn(Cantos(0, 0, Width, Height, 50, 50));
        }

        //variaveis para a conecção MySQL
        private string StringConecção = "datasource=localhost; username=root; password =; database=pap";
        private MySqlConnection ola;
        public string query;
        public bool aberto = false;

        //Metodo de load do form
        private void Login_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Imagem_de_fundo2;

            panel2.Width = 0;
            panel2.Height = 0;

            panel2.Location = new Point(0, 0);

            panel1.Width = 0;
            panel1.Height = 0;

            panel1.Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Width = 0;
            panel1.Height = 0;

            panel1.Location = new Point(0, 0);
            
        }

        private void B_Login_Click(object sender, EventArgs e)
        {



            Conecao();

            query = "Select * from acessos where Username = '" + T_Username.Text + "'";

            MySqlCommand cmd = new MySqlCommand(query, ola);

            try
            {
                MySqlDataReader ler = cmd.ExecuteReader();

                int contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    query = "Select * from acessos where Username = '" + T_Username.Text + "' and Password = '" + T_Password.Text + "'";

                    cmd = new MySqlCommand(query, ola);

                    ler = cmd.ExecuteReader();

                    int contar2 = 0;

                    while (ler.Read())
                    {
                        contar2 = contar2 + 1;
                    }

                    ler.Close();

                    query = "Select Cor from acessos where Username = '" + T_Username.Text + "' and Password = '" + T_Password.Text + "'";

                    cmd = new MySqlCommand(query, ola);

                    ler = cmd.ExecuteReader();

                    int cor = 0;

                    while (ler.Read())
                    {
                        cor = ler.GetInt32(ler.GetOrdinal("Cor"));
                    }

                    if (contar2 == 1)
                    {
                        FLayout Call2 = new FLayout();

                        Call2.Username = T_Username.Text;
                        Call2.VerMHD = cor;

                        Call2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password Errada");
                    }
                }
                else
                {
                    MessageBox.Show("Username Errado");
                }
            }
            catch (Exception a)
            {
                T_Username.Text = "";
                T_Password.Text = "";
            }
        }

        private void B_Register_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(13, 173);

            panel1.Width = 539;
            panel1.Height = 298;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conecao();

            if (textBox3.Text.Length < 3 && textBox2.Text.Length > 20)
            {
                MessageBox.Show("Username não é valido!!");

            }else if (textBox4.Text.Length < 3 && textBox4.Text.Length > 15)
            {
                MessageBox.Show("Password não é valido!!");

            }
            else if (textBox2.Text.Length < 3 && textBox2.Text.Length > 10)
            {
                MessageBox.Show("Email não é valido!!");

            }
            else if (textBox1.Text.Length < 3 && textBox1.Text.Length > 40)
            {
                MessageBox.Show("Introduza uma resposta correta!!");
            }
            else if (textBox5.Text.Length < 3 && textBox5.Text.Length > 15)
            {
                MessageBox.Show("Introduza um Nome valido!!");
            }
            else if (textBox6.Text.Length < 3 && textBox6.Text.Length > 15)
            {
                MessageBox.Show("Introduza um Apelido valido!!");
            }
            else if (textBox8.Text.Length < 3 && textBox8.Text.Length > 40)
            {
                MessageBox.Show("Introduza uma Cidade valida!!");
            }
            else
            {
                string str = textBox8.Text;
                int numeroK;

                bool n = int.TryParse(str, out numeroK);

                if (n == false)
                {
                    MessageBox.Show("ERRO! Introduza uma idade correta");
                }
                else
                {
                    string email;

                    email = "" + textBox2.Text + label4.Text + comboBox1.Text;

                    try
                    {
                        query = "select username from acessos where username = '" + textBox3.Text + "'";

                        MySqlCommand cmd = new MySqlCommand(query, ola);

                        MySqlDataReader ler = cmd.ExecuteReader();

                        int contar = 0;

                        while (ler.Read())
                        {
                            contar = contar + 1;
                        }

                        ler.Close();

                        if (contar == 1)
                        {
                            MessageBox.Show("ERRO!! Username ja registado!!");
                        }
                        else
                        {
                            query = "insert into acessos(Username, Password, Email, Pergunta, Cor) values ('" + textBox3.Text + "','" + textBox4.Text + "', '" + email + "', '" + textBox1.Text + "', 1)";

                            cmd = new MySqlCommand(query, ola);

                            cmd.ExecuteNonQuery();


                            query = "insert into cliente(Username, NomeCliente, Apelido, Idade, Pais, Cidade, Dinheiro) values ('" + textBox3.Text + "','" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox8.Text + "', '" + textBox7.Text + "', '" + textBox10.Text + "', 0.00)";

                            cmd = new MySqlCommand(query, ola);

                            cmd.ExecuteNonQuery();

                            panel1.Width = 0;
                            panel1.Height = 0;

                            panel1.Location = new Point(0, 0);
                        }

                    }
                    catch (Exception b)
                    {

                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }


                }
            }

            
        }


        //Metodo de conecção
        private void Conecao()
        {
            ola = new MySqlConnection(StringConecção);

            try
            {
                ola.Open();
                aberto = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Base de dados nao esta disponivel neste momento");
                aberto = false;
                
            }
        }

        private void L_SairL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void L_SairL_MouseHover(object sender, EventArgs e)
        {
            L_SairL.ForeColor = Color.White;
        }

        private void L_SairL_MouseLeave(object sender, EventArgs e)
        {
            L_SairL.ForeColor = Color.Silver;
        }

        private void L_Alterar_Pass_Click(object sender, EventArgs e)
        {
            panel2.Width = 469;
            panel2.Height = 135;

            panel2.Location = new Point(58, 204);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conecao();

            if (textBox16.Text.Length < 3 || textBox16.Text.Length > 20)
            {
                MessageBox.Show("Username Incorreto!!");
            }
            else if (textBox9.Text.Length < 3 && textBox9.Text.Length > 40)
            {
                MessageBox.Show("Resposta Incorreta!!");
            }
            else
            {
                query = "Select * from acessos where Username = '" + textBox16.Text + "'";

                MySqlCommand cmd = new MySqlCommand(query, ola);

                MySqlDataReader ler = cmd.ExecuteReader();

                int contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    query = "Select * from acessos where Username = '" + textBox16.Text + "' and Pergunta = '" + textBox9.Text + "'";

                    cmd = new MySqlCommand(query, ola);

                    ler = cmd.ExecuteReader();

                    int contar2 = 0;

                    while (ler.Read())
                    {
                        contar2 = contar2 + 1;
                    }

                    ler.Close();

                    if (contar2 == 1)
                    {
                        query = "update acessos set Password = '12345' where Username = '" + textBox16.Text + "'";

                        cmd = new MySqlCommand(query, ola);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Password recuperada!! Nova Password: 12345.");

                        panel2.Width = 0;
                        panel2.Height = 0;

                        panel2.Location = new Point(0, 0);
                    }
                    else
                    {
                        MessageBox.Show("Resposta Errada!!");
                    }
                }
                else
                {
                    MessageBox.Show("Username Errado!!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Width = 0;
            panel2.Height = 0;

            panel2.Location = new Point(0, 0);
        }
    }
}
