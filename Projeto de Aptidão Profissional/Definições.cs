using System;
using System.Collections;
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
    public partial class Definições : UserControl
    {
        //propriedades do form definições
        public Definições()
        {
            InitializeComponent();
        }


        /*declaração das variaveis Cor - armazena as cores; Checking - armazena o numero para o switch
        Ativo - armazena um valor verdadeiro ou falso para a veriicação do butão aplicar*/
        public int[,] Cor = new int[2, 3] { { 225, 192, 130 }, { 50, 30, 0}};

        //variavel declarada para decidir para qual cor o cliente pretende mudar
        public int checking = 1;

        //variavel para escolha de butão para cada painel
        public int BotãoAlteração = 1;

        //varaivel para escolha de painel do form conta
        public int iniciapainel = 0;

        //variavel para parar o timer e para aumentar o painel
        private int F = 30;
        private int G = 300;

        //variaveis para mover os outros paineis para baixo
        private int PUsername = 120; // --- Painel Username
        private int PPassword = 160; // --- Painel Password
        private int PEmail = 200; // --- Painel Email
        private int PFotografia = 240; // --- Painel Fotografia

        //variaveis para mover os outros paineis para cima
        private int PUsernameC = 390; // --- Painel Username
        private int PPasswordC = 430; // --- Painel Password
        private int PEmailC = 470; // --- Painel Email
        private int PFotografiaC = 510; // --- Painel Fotografia

        string query;


        //Metodos click
        private void button1_Click(object sender, EventArgs e)
        {
            //Comando para aceder aos objetos do form de design Flayout
            FLayout PD = (FLayout)this.Parent;

            //if para mudar alterar e checkar o butão da cor vermelho
            if (Check_Azul.Checked == true)
            {
                Check_Azul.Checked = false;
                Check_Vermelho.Checked = true;

            }else if (Check_Preto.Checked ==true)
            {
                Check_Preto.Checked = false;
                Check_Vermelho.Checked = true;

            }else if (Check_Verde.Checked == true)
            {
                Check_Verde.Checked = false;
                Check_Vermelho.Checked = true;
            }

            //muda o estado do check para false caso seja true e o cliente deseje mudar para outra cor antes de clicar em aplicar
            if(PD.verificação == 0)
            {
                PD.verificação = 1;
            }

            //variavel para a escolha de cor no botão aplicar
            checking = 1;

            /*
                Resto do codigo para atualizar a base de dados com os dados da base de dados
                em mySQL para cada conta do utilizador - cor vermelha -

            */


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Comando para aceder aos objetos do form de design Flayout
            FLayout PD = (FLayout)this.Parent;

            //if para mudar alterar e checkar o butão da cor Azul
            if (Check_Vermelho.Checked == true)
            {
                Check_Vermelho.Checked = false;
                Check_Azul.Checked = true;

            }
            else if (Check_Preto.Checked == true)
            {
                Check_Preto.Checked = false;
                Check_Azul.Checked = true;

            }
            else if (Check_Verde.Checked == true)
            {
                Check_Verde.Checked = false;
                Check_Azul.Checked = true;
            }

            //muda o estado do check para false caso seja true e o cliente deseje mudar para outra cor antes de clicar em aplicar
            if (PD.verificação == 0)
            {
                PD.verificação = 1;
            }

            //variavel para a escolha de cor no butão aplicar
            checking = 2;

            /*
                Resto do codigo para atualizar a base de dados com os dados da base de dados
                em mySQL para cada conta do utilizador - cor azul -

            */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Comando para aceder aos objetos do form de design Flayout
            FLayout PD = (FLayout)this.Parent;

            //if para mudar alterar e checkar o butão da cor Preta
            if (Check_Vermelho.Checked == true)
            {
                Check_Vermelho.Checked = false;
                Check_Preto.Checked = true;

            }
            else if (Check_Azul.Checked == true)
            {
                Check_Azul.Checked = false;
                Check_Preto.Checked = true;

            }
            else if (Check_Verde.Checked == true)
            {
                Check_Verde.Checked = false;
                Check_Preto.Checked = true;
            }

            //muda o estado do check para false caso seja true e o cliente deseje mudar para outra cor antes de clicar em aplicar
            if (PD.verificação == 0)
            {
                PD.verificação = 1;
            }

            //variavel para a escolha de cor no butão aplicar
            checking = 3;

            /*
                Resto do codigo para atualizar a base de dados com os dados da base de dados
                em mySQL para cada conta do utilizador - cor preta -

            */

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Comando para aceder aos objetos do form de design Flayout
            FLayout PD = (FLayout)this.Parent;

            //if para mudar alterar e checkar o butão da cor verde
            if (Check_Vermelho.Checked == true)
            {
                Check_Vermelho.Checked = false;
                Check_Verde.Checked = true;

            }
            else if (Check_Azul.Checked == true)
            {
                Check_Azul.Checked = false;
                Check_Verde.Checked = true;

            }
            else if (Check_Preto.Checked == true)
            {
                Check_Preto.Checked = false;
                Check_Verde.Checked = true;
            }

            //muda o estado da variavel para 1 caso seja 0 se o cliente desejar mudar para outra cor antes de clicar em aplicar
            if (PD.verificação == 0)
            {
                PD.verificação = 1;
            }

            //variavel para a escolha de cor no butão aplicar
            checking = 4;

            /*
                Resto do codigo para atualizar a base de dados com os dados da base de dados
                em mySQL para cada conta do utilizador - cor vermelha -

            */
        }

        private void B_Aplicar_Click(object sender, EventArgs e)
        {
            //Comando para aceder aos objetos do form de design Flayout
            FLayout PD = (FLayout)this.Parent;

            //Switch para escolha de cor dependendo da variavel escolhida dos 4 butoes anteriores
            switch (checking)
            {
                //case 1 - cor vermelha
                case 1:
                    PD.Painel_Menu.BackColor = Color.FromArgb(Cor[0, 0], 0, 0);
                    PD.B_DinheiroConta.BackColor = Color.FromArgb(Cor[0, 0], 0, 0);
                    PD.B_Computadores.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Equipamentos.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Componentes.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Configurador.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Carrinho.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.Painel_Dec.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);

                    //alteração da cor de todas as labels
                    LabelCor();
                    PD.B_Definições.ForeColor = Color.FromArgb(Cor[0, 1], 0, 0);

                    //Backcolor do botão caso a cor altere
                    PD.B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 0], 0, 0);
                    PD.B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 0], 0, 0);

                    query = "Update acessos set cor = 1 where Username = '" + PD.Username + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();

                    //variavel para os eventos MouseHover e MouseDown
                    PD.VerMHD = 1;

                    break;

                //case 2 - cor azul
                case 2:
                    PD.Painel_Menu.BackColor = Color.FromArgb(0, 0, Cor[0, 0]);
                    PD.B_DinheiroConta.BackColor = Color.FromArgb(0, 0, Cor[0, 0]);
                    PD.B_Computadores.BackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_Equipamentos.BackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_Configurador.BackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_Carrinho.BackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.Painel_Dec.BackColor = Color.FromArgb(0, 0, Cor[0, 1]);

                    //alteração da cor de todas as labels
                    LabelCor();
                    PD.B_Definições.ForeColor = Color.FromArgb(0, 0, Cor[0, 1]);

                    //Backcolor do botão caso a cor altere
                    PD.B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, Cor[0, 2]);
                    PD.B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, Cor[0, 2]);
                    PD.B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, Cor[0, 2]);
                    PD.B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, Cor[0, 2]);
                    PD.B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, Cor[0, 2]);
                    PD.B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, Cor[0, 1]);
                    PD.B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, Cor[0, 0]);
                    PD.B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, Cor[0, 0]);

                    query = "Update acessos set cor = 2 where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();

                    //variavel para os eventos MouseHover e MouseDown
                    PD.VerMHD = 2;

                    break;
                
                //case 3 - cor preta
                case 3:
                    PD.Painel_Menu.BackColor = Color.FromArgb(Cor[1, 0], Cor[1, 0], Cor[1, 0]);
                    PD.B_DinheiroConta.BackColor = Color.FromArgb(Cor[1, 0], Cor[1, 0], Cor[1, 0]);
                    PD.B_Computadores.BackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_Equipamentos.BackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_Componentes.BackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_Configurador.BackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_Carrinho.BackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.Painel_Dec.BackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);

                    //alteração da cor de todas as labels
                    LabelCor();
                    PD.B_Definições.ForeColor = Color.FromArgb(Cor[1, 2], Cor[1, 2], Cor[1, 2]);

                    //Backcolor do botão caso a cor altere
                    PD.B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[1, 2], Cor[1, 2], Cor[1, 2]);
                    PD.B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[1, 2], Cor[1, 2], Cor[1, 2]);
                    PD.B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[1, 2], Cor[1, 2], Cor[1, 2]);
                    PD.B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[1, 2], Cor[1, 2], Cor[1, 2]);
                    PD.B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[1, 2], Cor[1, 2], Cor[1, 2]);
                    PD.B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[1, 1], Cor[1, 1], Cor[1, 1]);
                    PD.B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[1, 0], Cor[1, 0], Cor[1, 0]);
                    PD.B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[1, 0], Cor[1, 0], Cor[1, 0]);

                    query = "Update acessos set cor = 3 where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();

                    //variavel para os eventos MouseHover e MouseDown
                    PD.VerMHD = 3;

                    break;

                //case 4 - cor verde
                case 4:
                    PD.Painel_Menu.BackColor = Color.FromArgb(0, Cor[0, 0], 0);
                    PD.B_DinheiroConta.BackColor = Color.FromArgb(0, Cor[0, 0], 0);
                    PD.B_Computadores.BackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_Equipamentos.BackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_Componentes.BackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_Configurador.BackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_Carrinho.BackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.Painel_Dec.BackColor = Color.FromArgb(0, Cor[0, 1], 0);

                    //alteração da cor de todas as labels
                    LabelCor();
                    PD.B_Definições.ForeColor = Color.FromArgb(0, Cor[0, 1], 0);

                    //Backcolor do botão caso a cor altere
                    PD.B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, Cor[0, 2], 0);
                    PD.B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, Cor[0, 2], 0);
                    PD.B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, Cor[0, 2], 0);
                    PD.B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, Cor[0, 2], 0);
                    PD.B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, Cor[0, 2], 0);
                    PD.B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, Cor[0, 1], 0);
                    PD.B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, Cor[0, 0], 0);
                    PD.B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, Cor[0, 0], 0);

                    query = "Update acessos set cor = 4 where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();

                    //variavel para os eventos MouseHover e MouseDown
                    PD.VerMHD = 4;

                    break;

                //case default - por defeito a cor normal do form é a cor vermelha
                default:
                    PD.Painel_Menu.BackColor = Color.FromArgb(Cor[0, 0], 0, 0);
                    PD.B_DinheiroConta.BackColor = Color.FromArgb(Cor[0, 0], 0, 0);
                    PD.B_Computadores.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Equipamentos.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Componentes.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Configurador.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Carrinho.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.Painel_Dec.BackColor = Color.FromArgb(Cor[0, 1], 0, 0);

                    //alteração da cor de todas as labels
                    LabelCor();
                    L_DefiniçõesRetroceder.ForeColor = Color.FromArgb(Cor[0, 1], 0, 0);

                    //Backcolor do botão caso a cor altere
                    PD.B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 2], 0, 0);
                    PD.B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 1], 0, 0);
                    PD.B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(Cor[0, 0], 0, 0);
                    PD.B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(Cor[0, 0], 0, 0);

                    query = "Update acessos set cor = 1 where Username = '" + PD.Username + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    cmd.ExecuteNonQuery();

                    //variavel para os eventos MouseHover e MouseDown
                    PD.VerMHD = 1;

                    break;
            }

            //verifica que o botão aplicar foi aplicado
            PD.verificação = 0;
        }
 
        private void B_AlterarCor_Click (object sender, EventArgs e)
        {
            //altera o botão de escolha do painel
            BotãoAlteração = 1;

            //if para verificar se o painel esta fechado ou aberto
            if (Panel_AlterarCor.Height == 30)
            {
                //verifica se algum painel esta aberto e retraio antes de iniciar a abertura do painel escolhido
                if (Panel_AlterarEmail.Height == 300)
                {
                    Panel_AlterarEmail.Height = 30;    
                }
                else if (Panel_AlterarFotografia.Height == 300)
                {
                    Panel_AlterarFotografia.Height = 30;
                }
                else if (Panel_AlterarPassword.Height == 300)
                {
                    Panel_AlterarPassword.Height = 30;
                }
                else if (Panel_AlterarUsername.Height == 300)
                {
                    Panel_AlterarUsername.Height = 30;
                }

                //inicia o timer para abrir o painel
                TimerExtenção.Enabled = true;

            }else if (Panel_AlterarCor.Height == 300)
            {
                //inicia o timer para fechar o painel
                TimerRetroceder.Enabled = true;
            }
        }

        private void B_AlterarUsername_Click(object sender, EventArgs e)
        {
            //altera o botão de escolha do painel
            BotãoAlteração = 2;

            //if para verificar se o painel esta fechado ou aberto
            if (Panel_AlterarUsername.Height == 30)
            {
                //verifica se algum painel esta aberto e retraio antes de iniciar a abertura do painel escolhido
                if (Panel_AlterarCor.Height == 300)
                {
                    Panel_AlterarCor.Height = 30;

                    Panel_AlterarUsername.Location = new Point(54, 120);
                    Panel_AlterarPassword.Location = new Point(54, 160);
                    Panel_AlterarEmail.Location = new Point(54, 200);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }
                else if (Panel_AlterarFotografia.Height == 300)
                {
                    Panel_AlterarFotografia.Height = 30;
                }
                else if (Panel_AlterarPassword.Height == 300)
                {
                    Panel_AlterarPassword.Height = 30;
                }
                else if (Panel_AlterarEmail.Height == 300)
                {
                    Panel_AlterarEmail.Height = 30;
                }

                //inicia o timer para abrir o painel
                TimerExtenção.Enabled = true;
            }
            else if (Panel_AlterarUsername.Height == 300)
            {
                //inicia o timer para fechar o painel
                TimerRetroceder.Enabled = true;
            }
        }

        private void B_AlterarPassword_Click(object sender, EventArgs e)
        {
            //altera o botão de escolha do painel
            BotãoAlteração = 3;

            //if para verificar se o painel esta fechado ou aberto
            if (Panel_AlterarPassword.Height == 30)
            {
                //verifica se algum painel esta aberto e retraio antes de iniciar a abertura do painel escolhido
                if (Panel_AlterarEmail.Height == 300)
                {
                    Panel_AlterarEmail.Height = 30;
                }
                else if (Panel_AlterarFotografia.Height == 300)
                {
                    Panel_AlterarFotografia.Height = 30;
                }
                else if (Panel_AlterarCor.Height == 300)
                {
                    Panel_AlterarCor.Height = 30;

                    Panel_AlterarUsername.Location = new Point(54, 200);
                    Panel_AlterarPassword.Location = new Point(54, 120);
                    Panel_AlterarEmail.Location = new Point(54, 160);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }
                else if (Panel_AlterarUsername.Height == 300)
                {
                    Panel_AlterarUsername.Height = 30;

                    Panel_AlterarPassword.Location = new Point(54, 120);
                    Panel_AlterarEmail.Location = new Point(54, 160);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }

                //inicia o timer para abrir o painel
                TimerExtenção.Enabled = true;
            }
            else if (Panel_AlterarPassword.Height == 300)
            {
                //inicia o timer para fechar o painel
                TimerRetroceder.Enabled = true;
            }
        }

        private void B_AlterarEmail_Click(object sender, EventArgs e)
        {
            //altera o botão de escolha do painel
            BotãoAlteração = 4;

            //if para verificar se o painel esta fechado ou aberto
            if (Panel_AlterarEmail.Height == 30)
            {
                //verifica se algum painel esta aberto e retraio antes de iniciar a abertura do painel escolhido
                if (Panel_AlterarCor.Height == 300)
                {
                    Panel_AlterarCor.Height = 30;

                    Panel_AlterarUsername.Location = new Point(54, 200);
                    Panel_AlterarPassword.Location = new Point(54, 120);
                    Panel_AlterarEmail.Location = new Point(54, 160);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }
                else if (Panel_AlterarFotografia.Height == 300)
                {
                    Panel_AlterarFotografia.Height = 30;
                }
                else if (Panel_AlterarPassword.Height == 300)
                {
                    Panel_AlterarPassword.Height = 30;

                    Panel_AlterarEmail.Location = new Point(54, 160);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }
                else if (Panel_AlterarUsername.Height == 300)
                {
                    Panel_AlterarUsername.Height = 30;

                    Panel_AlterarPassword.Location = new Point(54, 120);
                    Panel_AlterarEmail.Location = new Point(54, 160);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }

                //inicia o timer para abrir o painel
                TimerExtenção.Enabled = true;
            }
            else if (Panel_AlterarEmail.Height == 300)
            {
                //inicia o timer para fechar o painel
                TimerRetroceder.Enabled = true;
            }
        }

        private void B_AlterarFotografia_Click(object sender, EventArgs e)
        {
            //altera o botão de escolha do painel
            BotãoAlteração = 5;

            //if para verificar se o painel esta fechado ou aberto
            if (Panel_AlterarFotografia.Height == 30)
            {
                //verifica se algum painel esta aberto e retraio antes de iniciar a abertura do painel escolhido
                if (Panel_AlterarEmail.Height == 300)
                {
                    Panel_AlterarEmail.Height = 30;

                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }
                else if (Panel_AlterarCor.Height == 300)
                {
                    Panel_AlterarCor.Height = 30;

                    Panel_AlterarUsername.Location = new Point(54, 120);
                    Panel_AlterarPassword.Location = new Point(54, 160);
                    Panel_AlterarEmail.Location = new Point(54, 200);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }
                else if (Panel_AlterarPassword.Height == 300)
                {
                    Panel_AlterarPassword.Height = 30;

                    Panel_AlterarEmail.Location = new Point(54, 200);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }
                else if (Panel_AlterarUsername.Height == 300)
                {
                    Panel_AlterarUsername.Height = 30;

                    Panel_AlterarPassword.Location = new Point(54, 160);
                    Panel_AlterarEmail.Location = new Point(54, 200);
                    Panel_AlterarFotografia.Location = new Point(54, 240);
                }

                //inicia o timer para abrir o painel
                TimerExtenção.Enabled = true;
            }
            else if (Panel_AlterarFotografia.Height == 300)
            {
                //inicia o timer para fechar o painel
                TimerRetroceder.Enabled = true;
            }
        }

        private void L_DefiniçõesRetroceder_CLick(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //Abre o formulario anterior
            PD.AbrirRetroceder();

            //altera as labels contidas no form
            LabelCor();

            //altera a variavel
            if (PD.FormularioAnterior == 1)
            {
                PD.FormularioAtual = 1;
                PD.FormularioPosterior = 0;
                PD.FormularioAnterior = 0;
            }
            else
            {
                //metodo para alterar o botão de avançar do formulario que vai retroceder

                //metodo para fechar o botão de retroceder do formulario

                PD.FormularioPosterior = PD.FormularioAtual;
                PD.FormularioAtual = PD.FormularioAnterior;
                PD.FormularioAnterior = 0;
            }

            //Metodo para alterar o evento
            PD.B_Definições.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        //Metodo para alterar a cor de todas as labels
        private void LabelCor()
        {
            //variavel para aceder a outras variaveis do form Computadores
            Computadores PD = new Computadores();

            //switch para escolher a cor
            switch (checking)
            {
                case 1:
                    L_DefiniçõesRetroceder.ForeColor = Color.FromArgb(PD.CorLabels[0], PD.CorLabels[1], PD.CorLabels[1]);

                    break;

                case 2:
                    L_DefiniçõesRetroceder.ForeColor = Color.FromArgb(PD.CorLabels[1], PD.CorLabels[1], PD.CorLabels[0]);

                    break;

                case 3:
                    L_DefiniçõesRetroceder.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_DefiniçõesRetroceder.ForeColor = Color.FromArgb(PD.CorLabels[1], PD.CorLabels[0], PD.CorLabels[1]);

                    break;
            }   
        }


        //metodo load do form
        private void Definições_Load(object sender, EventArgs e)
        {
            Panel_AlterarCor.Height = 30;
            Panel_AlterarUsername.Height = 30;
            Panel_AlterarEmail.Height = 30;
            Panel_AlterarFotografia.Height = 30;
            Panel_AlterarPassword.Height = 30;
        }


        //metodo tick do timer
        private void TimerExtenção_Tick(object sender, EventArgs e)
        {
            //switch para escolher qual botão foi pressionado
            switch (BotãoAlteração)
            {
                case 1:
                    //altera o tamanho do painel 
                    Panel_AlterarCor.Height = F + 15;

                    //altera a posição dos outros paineis
                    Panel_AlterarUsername.Location = new Point(54, PUsername + 15);
                    Panel_AlterarPassword.Location = new Point(54, PPassword + 15);
                    Panel_AlterarEmail.Location = new Point(54, PEmail + 15);
                    Panel_AlterarFotografia.Location = new Point(54, PFotografia + 15);

                    if (F >= 300)
                    {
                        Panel_AlterarCor.Height = 300;

                        Panel_AlterarUsername.Location = new Point(54, 470);
                        Panel_AlterarPassword.Location = new Point(54, 390);
                        Panel_AlterarEmail.Location = new Point(54, 430);
                        Panel_AlterarFotografia.Location = new Point(54, 510);

                        TimerExtenção.Enabled = false;

                        F = 30;

                        PUsername = 120;
                        PPassword = 160;
                        PEmail = 200;
                        PFotografia = 240;

                    }

                    F = F + 15;
                    PUsername = PUsername + 15;
                    PPassword = PPassword + 15;
                    PEmail = PEmail + 15;
                    PFotografia = PFotografia + 15;
                    break;

                case 2:
                    Panel_AlterarUsername.Height = F + 15;

                    Panel_AlterarPassword.Location = new Point(54, PPassword + 15);
                    Panel_AlterarEmail.Location = new Point(54, PEmail + 15);
                    Panel_AlterarFotografia.Location = new Point(54, PFotografia + 15);

                    if (F >= 300)
                    {
                        Panel_AlterarUsername.Height = 300;

                        Panel_AlterarPassword.Location = new Point(54, 430);
                        Panel_AlterarEmail.Location = new Point(54, 470);
                        Panel_AlterarFotografia.Location = new Point(54, 510);

                        TimerExtenção.Enabled = false;

                        F = 30;

                        PPassword = 160;
                        PEmail = 200;
                        PFotografia = 240;
                    }

                    F = F + 15;

                    PPassword = PPassword + 15;
                    PEmail = PEmail + 15;
                    PFotografia = PFotografia + 15;
                    break;

                case 3:
                    Panel_AlterarPassword.Height = F + 15;

                    Panel_AlterarEmail.Location = new Point(54, PEmail + 15);
                    Panel_AlterarFotografia.Location = new Point(54, PFotografia + 15);

                    if (F >= 300)
                    {
                        Panel_AlterarPassword.Height = 300;

                        Panel_AlterarEmail.Location = new Point(54, 430);
                        Panel_AlterarFotografia.Location = new Point(54, 510);

                        TimerExtenção.Enabled = false;

                        F = 30;

                        PEmail = 200;
                        PFotografia = 240;
                    }

                    F = F + 15;

                    PEmail = PEmail + 15;
                    PFotografia = PFotografia + 15;
                    break;

                case 4:
                    Panel_AlterarEmail.Height = F + 15;

                    Panel_AlterarFotografia.Location = new Point(54, PFotografia + 15);

                    if (F >= 300)
                    {
                        Panel_AlterarEmail.Height = 300;

                        Panel_AlterarFotografia.Location = new Point(54, 510);

                        TimerExtenção.Enabled = false;
                        F = 30;

                        PFotografia = 240;
                    }

                    F = F + 15;

                    PFotografia = PFotografia + 15;
                    break;

                case 5:
                    Panel_AlterarFotografia.Height = F + 15;

                    if (F >= 300)
                    {
                        Panel_AlterarFotografia.Height = 300;
                        TimerExtenção.Enabled = false;
                        F = 30;
                    }

                    F = F + 15;
                    break;
            }

        }

        private void TimerRetroceder_Tick(object sender, EventArgs e)
        {
            //switch para escolher qual botão foi pressionado
            switch (BotãoAlteração)
            {
                case 1:
                    //altera o tamanho do painel
                    Panel_AlterarCor.Height = G - 15;

                    //altera a posição dos outros paineis
                    Panel_AlterarUsername.Location = new Point(54, PUsernameC - 15);
                    Panel_AlterarPassword.Location = new Point(54, PPasswordC - 15);
                    Panel_AlterarEmail.Location = new Point(54, PEmailC - 15);
                    Panel_AlterarFotografia.Location = new Point(54, PFotografiaC - 15);

                    if (G <= 30)
                    {
                        Panel_AlterarCor.Height = 30;

                        Panel_AlterarUsername.Location = new Point(54, 200);
                        Panel_AlterarPassword.Location = new Point(54, 120);
                        Panel_AlterarEmail.Location = new Point(54, 160);
                        Panel_AlterarFotografia.Location = new Point(54, 240);

                        TimerRetroceder.Enabled = false;

                        G = 300;

                        PUsernameC = 470;
                        PPasswordC = 390;
                        PEmailC = 430;
                        PFotografiaC = 510;
                    }

                    G = G - 15;

                    PUsernameC = PUsernameC - 15;
                    PPasswordC = PPasswordC - 15;
                    PEmailC = PEmailC - 15;
                    PFotografiaC = PFotografiaC - 15;
                    break;

                case 2:
                    Panel_AlterarUsername.Height = G - 15;

                    Panel_AlterarPassword.Location = new Point(54, PPasswordC - 15);
                    Panel_AlterarEmail.Location = new Point(54, PEmailC - 15);
                    Panel_AlterarFotografia.Location = new Point(54, PFotografiaC - 15);

                    if (G <= 30)
                    {
                        Panel_AlterarUsername.Height = 30;

                        Panel_AlterarPassword.Location = new Point(54, 160);
                        Panel_AlterarEmail.Location = new Point(54, 200);
                        Panel_AlterarFotografia.Location = new Point(54, 240);

                        TimerRetroceder.Enabled = false;

                        G = 300;

                        PPasswordC = 430;
                        PEmailC = 470;
                        PFotografiaC = 510;
                    }

                    G = G - 15;

                    PPasswordC = PPasswordC - 15;
                    PEmailC = PEmailC - 15;
                    PFotografiaC = PFotografiaC - 15;
                    break;

                case 3:
                    Panel_AlterarPassword.Height = G - 15;

                    Panel_AlterarEmail.Location = new Point(54, PEmailC - 15);
                    Panel_AlterarFotografia.Location = new Point(54, PFotografiaC - 15);

                    if (G <= 30)
                    {
                        Panel_AlterarPassword.Height = 30;

                        Panel_AlterarEmail.Location = new Point(54, 160);
                        Panel_AlterarFotografia.Location = new Point(54, 240);

                        TimerRetroceder.Enabled = false;
                        G = 300;

                        PEmailC = 430;
                        PFotografiaC = 510;
                    }

                    G = G - 15;

                    PEmailC = PEmailC - 15;
                    PFotografiaC = PFotografiaC - 15;
                    break;

                case 4:
                    Panel_AlterarEmail.Height = G - 15;

                    Panel_AlterarFotografia.Location = new Point(54, PFotografiaC - 15);

                    if (G <= 30)
                    {
                        Panel_AlterarEmail.Height = 30;

                        Panel_AlterarFotografia.Location = new Point(54, 240);

                        TimerRetroceder.Enabled = false;
                        G = 300;

                        PFotografiaC = 510;
                    }

                    G = G - 15;

                    PFotografiaC = PFotografiaC - 15;
                    break;

                case 5:
                    Panel_AlterarFotografia.Height = G - 15;

                    if (G <= 30)
                    {
                        Panel_AlterarFotografia.Height = 30;
                        TimerRetroceder.Enabled = false;
                        G = 300;
                    }

                    G = G - 15;
                    break;
            }
        }


        //Metodo visivel
        private void Definições_VisibleChanged(object sender, EventArgs e)
        {
            if (iniciapainel == 1)
            {
                TimerExtenção.Enabled = true;
                iniciapainel = 0;
            }
        }

        private void B_AplicarUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void B_AplicarP_Click(object sender, EventArgs e)
        {
            //Comando para aceder aos objetos do form de design Flayout
            FLayout PD = (FLayout)this.Parent;

            if (textBox10.Text.Length < 3 || textBox10.Text.Length > 20 || textBox10.Text != textBox8.Text)
            {
                MessageBox.Show("Password confirmação errada!!");
            }
            else if (textBox9.Text.Length < 3 || textBox9.Text.Length > 20)
            {
                MessageBox.Show("Password errada!!");
            }
            else if (textBox8.Text.Length < 3 || textBox8.Text.Length > 20)
            {
                MessageBox.Show("Nova password invalida!!");
            }
            else if (textBox6.Text.Length < 3 || textBox6.Text.Length > 50)
            {
                MessageBox.Show("Introduza uma resposta valida!!");
            }
            else if (textBox7.Text.Length < 3 || textBox7.Text.Length > 15)
            {
                MessageBox.Show("Introduza uma Username valido!!");
            }
            else
            {
                query = "Select Username from acessos where Username = '" + textBox7.Text + "'";

                MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                MySqlDataReader ler = cmd.ExecuteReader();

                int contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    query = "Select Username from acessos where Username = '" + textBox7.Text + "' and Password = '" + textBox9.Text + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    int contar2 = 0;

                    while (ler.Read())
                    {
                        contar2 = contar2 + 1;
                    }

                    ler.Close();

                    if (contar2 == 1)
                    {
                        query = "Select Username from acessos where Username = '" + textBox7.Text + "' and Pergunta = '" + textBox6.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        ler = cmd.ExecuteReader();

                        int contar3 = 0;

                        while (ler.Read())
                        {
                            contar3 = contar3 + 1;
                        }

                        ler.Close();

                        if (contar3 == 1)
                        {
                            query = "update acessos set Password = '" + textBox8.Text + "' where Username = '" + textBox7.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            textBox6.Text = "";
                            textBox7.Text = "";
                            textBox8.Text = "";
                            textBox9.Text = "";
                            textBox10.Text = "";

                            MessageBox.Show("Password alterada!!");
                        }
                        else
                        {
                            MessageBox.Show("Pergunta Errada!!");
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
        }

        private void B_AplicarE_Click(object sender, EventArgs e)
        {
            //Comando para aceder aos objetos do form de design Flayout
            FLayout PD = (FLayout)this.Parent;

            if (textBox14.Text.Length < 3 || textBox14.Text.Length > 20)
            {
                MessageBox.Show("Password errada!!");
            }
            else if (textBox13.Text.Length < 3 || textBox13.Text.Length > 20)
            {
                MessageBox.Show("Email invalido!!");
            }
            else if (textBox11.Text.Length < 3 || textBox11.Text.Length > 50)
            {
                MessageBox.Show("Introduza uma resposta valida!!");
            }
            else if (textBox12.Text.Length < 3 || textBox12.Text.Length > 15)
            {
                MessageBox.Show("Introduza uma Username valido!!");
            }
            else
            {
                query = "Select Username from acessos where Username = '" + textBox12.Text + "'";

                MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                MySqlDataReader ler = cmd.ExecuteReader();

                int contar = 0;

                while (ler.Read())
                {
                    contar = contar + 1;
                }

                ler.Close();

                if (contar == 1)
                {
                    query = "Select Username from acessos where Username = '" + textBox12.Text + "' and Password = '" + textBox14.Text + "'";

                    cmd = new MySqlCommand(query, PD.ola);

                    ler = cmd.ExecuteReader();

                    int contar2 = 0;

                    while (ler.Read())
                    {
                        contar2 = contar2 + 1;
                    }

                    ler.Close();

                    if (contar2 == 1)
                    {
                        query = "Select Username from acessos where Username = '" + textBox12.Text + "' and Pergunta = '" + textBox11.Text + "'";

                        cmd = new MySqlCommand(query, PD.ola);

                        ler = cmd.ExecuteReader();

                        int contar3 = 0;

                        while (ler.Read())
                        {
                            contar3 = contar3 + 1;
                        }

                        ler.Close();

                        if (contar3 == 1)
                        {
                            string email;

                            email = "" + textBox13.Text + label4.Text + comboBox1.Text;

                            query = "update acessos set Email = '" + email + "' where Username = '" + textBox12.Text + "'";

                            cmd = new MySqlCommand(query, PD.ola);

                            cmd.ExecuteNonQuery();

                            textBox11.Text = "";
                            textBox12.Text = "";
                            textBox13.Text = "";
                            textBox14.Text = "";

                            MessageBox.Show("Email alterado!!");
                        }
                        else
                        {
                            MessageBox.Show("Pergunta Errada!!");
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
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox8.UseSystemPasswordChar = false;
            }
            else
            {
                textBox8.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox10.UseSystemPasswordChar = false;
            }
            else
            {
                textBox10.UseSystemPasswordChar = true;
            }
        }

        private void Panel_AlterarEmail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox14.UseSystemPasswordChar = false;
            }
            else
            {
                textBox14.UseSystemPasswordChar = true;
            }
        }
    }
}