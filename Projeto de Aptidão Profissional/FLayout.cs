using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Projeto_de_Aptidão_Profissional
{
    public partial class FLayout : Form
    {
        //importação da função Graphics Device Interface
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //metodo
        private static extern IntPtr Cantos
       (
           int nLeftRect, // Coordenada x do canto superior esquerdo
           int nTopRect, // Coordenada y do canto inferior esquerdo
           int nRightRect, // Coordenada x do canto inferior direito
           int nBottomRect, // Coordenada y do canto inferior esquerdo
           int nWidthEllipse, // Altura da ellipse
           int nHeightEllipse // Comprimento da ellipse
       );

        //variavel de verificação para o botão aplicar em usercontrol definições, é usado no metodo logout_click
        public int verificação = 0;

        //variavel para o MouseHover e Mouse Down
        public int VerMHD;

        //variavel para escolher os forms
        public int FormularioAtual = 1;
        public int FormularioAnterior = 0;
        public int FormularioPosterior = 0;


        //propriedades do form Flayout
        public FLayout()
        {
            InitializeComponent();

            //desenha os cantos
            Region = System.Drawing.Region.FromHrgn(Cantos(0, 0, Width, Height, 50, 50));
        }
        //variaveis para a conecção MySQL
        public string StringConecção = "datasource=localhost; username=root; password =; database=pap";
        public MySqlConnection ola;
        public string query;

        public string Username;

        public string[,] Strings = new string[8, 3];
        public int[] inteiros = new int[8];
        public decimal[] decimais = new decimal[8];

        //Metodo de conecção
        public void Conecao()
        {
            ola = new MySqlConnection(StringConecção);

            try
            {
                ola.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Base de dados nao diponivel");

                this.Hide();
                Login vai = new Login();
                vai.Show();

            }
        }


        //Metodo para fazer os comandos quando o form é iniciado pela primeira vez
        public void Flayout_Load(object sender, EventArgs e)
        {
            Conecao();

            //variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //inicia a variavel para o valor 1, é o numero do formulario Home
            FormularioAtual = 1;

            //troca a cor das variaveis
            LabelCor();

            //codigo para quando iniciar o form por default: Home
            home1.Width = 815;
            home1.Height = 575;

            home1.Left = 242;
            home1.Top = 66;

            home1.Visible = true;

            if (VerMHD == 1)
            {
                Painel_Menu.BackColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                B_DinheiroConta.BackColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                B_Computadores.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Configurador.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Carrinho.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Home.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                Painel_Dec.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);

                B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

                definições1.Check_Vermelho.Checked = true;
                definições1.Check_Azul.Checked = false;
                definições1.Check_Verde.Checked = false;
                definições1.Check_Preto.Checked = false;
            }
            else if (VerMHD == 2)
            {
                Painel_Menu.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                B_DinheiroConta.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                B_Computadores.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Configurador.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Carrinho.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Home.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                Painel_Dec.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);

                B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);

                definições1.Check_Vermelho.Checked = false;
                definições1.Check_Azul.Checked = true;
                definições1.Check_Verde.Checked = false;
                definições1.Check_Preto.Checked = false;
            }
            else if (VerMHD == 3)
            {
                Painel_Menu.BackColor = Color.FromArgb(PD.Cor[1, 0], PD.Cor[1, 0], PD.Cor[1, 0]);
                B_DinheiroConta.BackColor = Color.FromArgb(PD.Cor[1, 0], PD.Cor[1, 0], PD.Cor[1, 0]);
                B_Computadores.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Configurador.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Carrinho.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Home.ForeColor = Color.FromArgb(PD.Cor[1, 0], PD.Cor[1, 0], PD.Cor[1, 0]);
                Painel_Dec.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);

                B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(PD.Cor[1, 0], PD.Cor[1, 0], PD.Cor[1, 0]);
                B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(PD.Cor[1, 0], PD.Cor[1, 0], PD.Cor[1, 0]);

                definições1.Check_Vermelho.Checked = false;
                definições1.Check_Azul.Checked = false;
                definições1.Check_Verde.Checked = false;
                definições1.Check_Preto.Checked = true;
            }
            else if (VerMHD == 4)
            {
                Painel_Menu.BackColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                B_DinheiroConta.BackColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                B_Computadores.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Configurador.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Carrinho.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Home.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                Painel_Dec.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);

                B_Computadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                B_Computadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Equipamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                B_Equipamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Componentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                B_Componentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Configurador.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                B_Configurador.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_Carrinho.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                B_Carrinho.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                B_DinheiroConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                B_DinheiroConta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

                definições1.Check_Vermelho.Checked = false;
                definições1.Check_Azul.Checked = false;
                definições1.Check_Verde.Checked = true;
                definições1.Check_Preto.Checked = false;
            }


            //Username
            L_NomeConta.Text = Username;

            //Altera a cor de imediato para aquela escolhida pelo cliente e mantem a cor
            B_Home.MouseLeave += new EventHandler(ControlAberto_Cor);

        }


        //Metodos de click, atua quando clicamos no botão em questão
        private void B_Definições_Click(object sender, EventArgs e)
        {
            Conecao();

            //retira a cor permanente do botão
            RetirarCor();

            //Fecha todas as abas que estiverem abertas
            FecharTudo();

            //abre a aba das definições
            definições1.Width = 815; //815
            definições1.Height = 575; //575

            definições1.Left = 242;
            definições1.Top = 66;

            definições1.Visible = true;

            //altera as labels contidas no form
            LabelCor();

            //altera as variaveis para retroceder
            FormularioAnterior = FormularioAtual;

            //altera a variavel
            FormularioAtual = 4;
            FormularioAnterior = 1;

            B_Definições.MouseLeave += new EventHandler(ControlAberto_Cor);
        }

        private void B_Logout_Click(object sender, EventArgs e)
        {
            //abre a coneção
            Conecao();

            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //if de verificação para o utilizador confirmar se pretende desconectar-se
            if (verificação == 1)
            {
                //apresenta uma message box para o utilizador caso queira sair da aba definições sem alterar a cor pretendida
                MessageBox.Show("Ainda não aplicou as definições, certeza que deseja sair??", "Aplicar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else 
            {
                //apresenta uma message box para o utilizador para confirmar que pretende desconectar-se da sua conta
                DialogResult Log = MessageBox.Show("Tem a certeza que pretende sair??", "Logout", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                //caso o utilizador diga que sim
                if (Log == DialogResult.Yes)
                {
                    Login Call = new Login();

                    this.Hide();
                    Call.Show();

                    //código para sair da conta e regressar ao form de login
                }
                //caso o utilizador diga que não
                else if (Log == DialogResult.No) 
                {
                    //retira a cor permanente do botão
                    RetirarCor();

                    //Fecha todas as abas que estiverem abertas
                    FecharTudo();

                    //abre a aba dos computadores para venda
                    home1.Width = 815;
                    home1.Height = 575;

                    home1.Left = 242;
                    home1.Top = 66;

                    home1.Visible = true;

                    //altera a cor da label do botão home
                    switch (VerMHD)
                    {
                        case 1:
                            B_Home.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                            break;

                        case 2:
                            B_Home.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                            break;

                        case 3:
                            B_Home.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;

                        case 4:
                            B_Home.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                            break;

                    }

                    //altera a cor das labels contidas no form
                    LabelCor();

                    //altera a variavel
                    FormularioAtual = 1;

                    B_Home.MouseLeave += new EventHandler(ControlAberto_Cor);

                }
            }
        }

        private void B_Computadores_Click(object sender, EventArgs e)
        {
            //abre a coneção
            Conecao();

            //retira a cor permanente do botão
            RetirarCor();

            //Fecha todas as abas que estiverem abertas
            FecharTudo();

            //abre a aba dos computadores para venda
            computadores1.Width = 815; //815
            computadores1.Height = 575; //575

            computadores1.Left = 242;
            computadores1.Top = 66;

            computadores1.Visible = true;

            //altera a cor das labels contidas no form
            LabelCor();

            //altera as variaveis para retroceder
            FormularioAnterior = FormularioAtual;

            //altera a variavel
            FormularioAtual = 5;

            B_Computadores.MouseLeave += new EventHandler(ControlAberto_Cor);
        }

        private void B_Conta_Click(object sender, EventArgs e)
        {
            //abre a coneção
            Conecao();

            //retira a cor permanente do botão
            RetirarCor();

            //Fecha todas as abas que estiverem abertas
            FecharTudo();

            //abre a aba dos computadores para venda
            conta1.Width = 815;
            conta1.Height = 575;

            conta1.Left = 242;
            conta1.Top = 66;

            conta1.Visible = true;

            query = "Select * from cliente where Username = '" + Username + "'";

            MySqlCommand cmd = new MySqlCommand(query, ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                conta1.label13.Text = ler.GetString(ler.GetOrdinal("NomeCliente"));
                conta1.label14.Text = ler.GetString(ler.GetOrdinal("Apelido"));
                conta1.label15.Text = ler.GetString(ler.GetOrdinal("Username"));
                conta1.label18.Text = ler.GetString(ler.GetOrdinal("Idade"));
                conta1.label21.Text = ler.GetString(ler.GetOrdinal("Pais"));
                conta1.label22.Text = ler.GetString(ler.GetOrdinal("Cidade"));
                conta1.label12.Text = ler.GetDecimal(ler.GetOrdinal("Dinheiro")) + " €";
            }

            ler.Close();

            query = "Select * from acessos where Username = '" + Username + "'";

            cmd = new MySqlCommand(query, ola);

            ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                conta1.label17.Text = ler.GetString(ler.GetOrdinal("Email"));
                conta1.label16.Text = ler.GetString(ler.GetOrdinal("Password"));
                conta1.label7.Text = ler.GetString(ler.GetOrdinal("Pergunta"));
            }

            ler.Close();

            //altera a cor das labels contidas no form
            LabelCor();

            //altera as variaveis para retroceder
            FormularioAnterior = FormularioAtual;

            //altera a variavel
            FormularioAtual = 2;

            B_Conta.MouseLeave += new EventHandler(ControlAberto_Cor);
        }

        private void B_Mensagens_Click(object sender, EventArgs e)
        {

        }

        private void B_Home_Click(object sender, EventArgs e)
        {
            //abre a coneção
            Conecao();

            //retira a cor permanente do botão
            RetirarCor();

            //Fecha todas as abas que estiverem abertas
            FecharTudo();

            //abre a aba dos computadores para venda
            home1.Width = 815;
            home1.Height = 575;

            home1.Left = 242;
            home1.Top = 66;

            home1.Visible = true;

            query = "Select Count(*) as Conta from acessos";

            MySqlCommand cmd = new MySqlCommand(query, ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            string conta = "";

            while (ler.Read())
            {
                conta = ler.GetString(ler.GetOrdinal("Conta"));
            }

            home1.L_UsersHome.Text = conta;

            ler.Close();

            //altera a cor das labels contidas no form
            LabelCor();

            //altera as variaveis para retroceder
            FormularioAnterior = FormularioAtual;

            //altera a variavel
            FormularioAtual = 1;

            B_Home.MouseLeave += new EventHandler(ControlAberto_Cor);
        }

        private void B_Equipamentos_Click(object sender, EventArgs e)
        {
            //abre a coneção
            Conecao();

            //retira a cor permanente do botão
            RetirarCor();

            //Fecha todas as abas que estiverem abertas
            FecharTudo();

            //abre a aba dos computadores para venda
            equipamentos1.Width = 815;
            equipamentos1.Height = 575;

            equipamentos1.Left = 242;
            equipamentos1.Top = 66;

            equipamentos1.Visible = true;

            //altera a cor das labels contidas no form
            LabelCor();

            //altera as variaveis para retroceder
            FormularioAnterior = FormularioAtual;

            //altera a variavel
            FormularioAtual = 6;

            B_Equipamentos.MouseLeave += new EventHandler(ControlAberto_Cor);
        }

        private void B_Componentes_Click(object sender, EventArgs e)
        {
            //abre a coneção
            Conecao();

            Componentes PD = new Componentes();

            //retira a cor permanente do botão
            RetirarCor();

            //Fecha todas as abas que estiverem abertas
            FecharTudo();

            //abre a aba dos computadores para venda
            componentes1.Width = 815;
            componentes1.Height = 575;

            componentes1.Left = 242;
            componentes1.Top = 66;

            componentes1.Visible = true;

            //altera a cor das labels contidas no form
            LabelCor();

            //altera as variaveis para retroceder
            FormularioAnterior = FormularioAtual;

            //altera a variavel
            FormularioAtual = 7;

            B_Componentes.MouseLeave += new EventHandler(ControlAberto_Cor);
        }

        private void B_Configurador_Click(object sender, EventArgs e)
        {
            //abre a coneção
            Conecao();

            //retira a cor permanente do botão
            RetirarCor();

            //Fecha todas as abas que estiverem abertas
            FecharTudo();

            //abre a aba dos computadores para venda
            configurador1.Width = 815;
            configurador1.Height = 575;

            configurador1.Left = 242;
            configurador1.Top = 66;

            configurador1.Visible = true;

            query = "Select Dinheiro from cliente where Username = '" + Username + "'";

            MySqlCommand cmd = new MySqlCommand(query, ola);

            MySqlDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                configurador1.PreçoConta.Text = ler.GetDecimal(ler.GetOrdinal("Dinheiro")) + " €";
            }

            ler.Close();

            //altera a cor das labels contidas no form
            LabelCor();

            //altera as variaveis para retroceder
            FormularioAnterior = FormularioAtual;

            //altera a variavel
            FormularioAtual = 8;

            B_Configurador.MouseLeave += new EventHandler(ControlAberto_Cor);
        }

        private void B_Carrinho_Click(object sender, EventArgs e)
        {
            //abre a coneção
            Conecao();

            //retira a cor permanente do botão
            RetirarCor();

            //Fecha todas as abas que estiverem abertas
            FecharTudo();

            //Faz reset as labels do Carrinho
            CarrinhoDefault();

            //Retira Data
            Descarregar();

            //Altera as Labels
            Carregar();

            //abre a aba dos computadores para venda
            carrinho1.Width = 815;
            carrinho1.Height = 575;

            carrinho1.Left = 242;
            carrinho1.Top = 66;

            carrinho1.Visible = true;

            //altera a cor das labels contidas no form
            LabelCor();

            //altera as variaveis para retroceder
            FormularioAnterior = FormularioAtual;

            //altera a variavel
            FormularioAtual = 9;

            B_Carrinho.MouseLeave += new EventHandler(ControlAberto_Cor);
        }

        private void L_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void L_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        //Metodos para alterar a cor das letras dependendo da cor quando se passa com o rato por cima
        private void L_Sair_MouseHover(object sender, EventArgs e)
        {
            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //if de verificação da cor
            if (VerMHD == 1)
            {
                L_Sair.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

            } else if (VerMHD == 2)
            {
                L_Sair.ForeColor = Color.FromArgb(0, 0, PD.Cor[0,0]);

            } else if (VerMHD == 3)
            {
                L_Sair.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);

            } else if (VerMHD == 4)
            {
                L_Sair.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

            }
            
        }

        private void L_Minimizar_MouseHover(object sender, EventArgs e)
        {
            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //if de verificação de cor
            if (VerMHD == 1)
            {
                L_Minimizar.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

            }
            else if (VerMHD == 2)
            {
                L_Minimizar.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);

            }
            else if (VerMHD == 3)
            {
                L_Minimizar.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);

            }
            else if (VerMHD == 4)
            {
                L_Minimizar.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

            }
        }

        private void B_Home_MouseHover(object sender, EventArgs e)
        {
            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //if de verificação de cor
            if (VerMHD == 1)
            {
                B_Home.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

            }
            else if (VerMHD == 2)
            {
                B_Home.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);

            }
            else if (VerMHD == 3)
            {
                B_Home.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);

            }
            else if (VerMHD == 4)
            {
                B_Home.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

            }
        }

        private void B_Conta_MouseHover(object sender, EventArgs e)
        {
            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //if de verificação de cor
            if (VerMHD == 1)
            {
                B_Conta.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

            }
            else if (VerMHD == 2)
            {
                B_Conta.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);

            }
            else if (VerMHD == 3)
            {
                B_Conta.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);

            }
            else if (VerMHD == 4)
            {
                B_Conta.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

            }
        }

        private void B_Definições_MouseHover(object sender, EventArgs e)
        {
            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //if de verificação de cor
            if (VerMHD == 1)
            {
                B_Definições.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

            }
            else if (VerMHD == 2)
            {
                B_Definições.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);

            }
            else if (VerMHD == 3)
            {
                B_Definições.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);

            }
            else if (VerMHD == 4)
            {
                B_Definições.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

            }
        }

        private void B_Logout_MouseHover(object sender, EventArgs e)
        {
            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //if de verificação de cor
            if (VerMHD == 1)
            {
                B_Logout.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

            }
            else if (VerMHD == 2)
            {
                B_Logout.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);

            }
            else if (VerMHD == 3)
            {
                B_Logout.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);

            }
            else if (VerMHD == 4)
            {
                B_Logout.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

            }
        }


        //Metodo para voltar a trocar a cor para a cor original quando se tira o rato
        private void L_Sair_MouseLeave(object sender, EventArgs e)
        {
            L_Sair.ForeColor = Color.Gray;
        }

        private void L_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            L_Minimizar.ForeColor = Color.Gray;
        }

        private void B_Home_MouseLeave(object sender, EventArgs e)
        {
            B_Home.ForeColor = Color.Gray;
        }

        private void B_Conta_MouseLeave(object sender, EventArgs e)
        {
            B_Conta.ForeColor = Color.Gray;
        }

        private void B_Definições_MouseLeave(object sender, EventArgs e)
        {
            B_Definições.ForeColor = Color.Gray;
        }

        private void B_Logout_MouseLeave(object sender, EventArgs e)
        {
            B_Logout.ForeColor = Color.Gray;
        }


        //Controla o fecho dos UserControls
        public void FecharTudo()
        {
            //Switch para fechar o UserControl que esteja aberto, todos os useres controls estão identificados no metodo Info_Formularios
            switch (FormularioAtual)
            {
                case 1:
                    home1.Width = 20;
                    home1.Height = 20;

                    home1.Left = 389;
                    home1.Top = 86;

                    home1.Visible = false;

                    break;

                case 2:
                    conta1.Width = 20;
                    conta1.Height = 20;

                    conta1.Left = 389;
                    conta1.Top = 86;

                    conta1.Visible = false;
                    break;

                case 3:
     
                    break;

                case 4:
                    definições1.Width = 20;
                    definições1.Height = 20;

                    definições1.Left = 389;
                    definições1.Top = 86;

                    definições1.Visible = false;

                    break;

                case 5:
                    computadores1.Width = 20;
                    computadores1.Height = 20;

                    computadores1.Left = 389;
                    computadores1.Top = 86;

                    computadores1.Visible = false;

                    break;

                case 6:
                    equipamentos1.Width = 20;
                    equipamentos1.Height = 20;

                    equipamentos1.Left = 389;
                    equipamentos1.Top = 86;

                    equipamentos1.Visible = false;
                    break;

                case 7:
                    componentes1.Width = 20;
                    componentes1.Height = 20;

                    componentes1.Left = 389;
                    componentes1.Top = 86;

                    componentes1.Visible = false;

                    break;

                case 8:
                    configurador1.Width = 20;
                    configurador1.Height = 20;

                    configurador1.Left = 389;
                    configurador1.Top = 86;

                    configurador1.Visible = false;

                    break;

                case 9:
                    carrinho1.Width = 20;
                    carrinho1.Height = 20;

                    carrinho1.Left = 389;
                    carrinho1.Top = 86;

                    carrinho1.Visible = false;

                    break;

                case 10:
                    pC_Portateis1.Width = 20;
                    pC_Portateis1.Height = 20;

                    pC_Portateis1.Left = 389;
                    pC_Portateis1.Top = 86;

                    pC_Portateis1.Visible = false;
                    break;

                case 11:
                    pC_Fixos1.Width = 20;
                    pC_Fixos1.Height = 20;

                    pC_Fixos1.Left = 389;
                    pC_Fixos1.Top = 86;

                    pC_Fixos1.Visible = false;
                    break;

                case 12:
                    equipamento_Ratos1.Width = 20;
                    equipamento_Ratos1.Height = 20;

                    equipamento_Ratos1.Left = 389;
                    equipamento_Ratos1.Top = 86;

                    equipamento_Ratos1.Visible = false;
                    break;

                case 13:
                    equipamento_Teclados1.Width = 20;
                    equipamento_Teclados1.Height = 20;

                    equipamento_Teclados1.Left = 389;
                    equipamento_Teclados1.Top = 86;

                    equipamento_Teclados1.Visible = false;
                    break;

                case 14:
                    equipamento_Tapetes1.Width = 20;
                    equipamento_Tapetes1.Height = 20;

                    equipamento_Tapetes1.Left = 389;
                    equipamento_Tapetes1.Top = 86;

                    equipamento_Tapetes1.Visible = false;
                    break;

                case 15:
                    equipamento_Monitores1.Width = 20;
                    equipamento_Monitores1.Height = 20;

                    equipamento_Monitores1.Left = 389;
                    equipamento_Monitores1.Top = 86;

                    equipamento_Monitores1.Visible = false;
                    break;

                case 16:
                    equipamento_HeadSetFones1.Width = 20;
                    equipamento_HeadSetFones1.Height = 20;

                    equipamento_HeadSetFones1.Left = 389;
                    equipamento_HeadSetFones1.Top = 86;

                    equipamento_HeadSetFones1.Visible = false;
                    break;

                case 17:
                    equipamento_Cadeiras1.Width = 20;
                    equipamento_Cadeiras1.Height = 20;

                    equipamento_Cadeiras1.Left = 389;
                    equipamento_Cadeiras1.Top = 86;

                    equipamento_Cadeiras1.Visible = false;
                    break;

                case 18:
                    equipamento_Colunas1.Width = 20;
                    equipamento_Colunas1.Height = 20;

                    equipamento_Colunas1.Left = 389;
                    equipamento_Colunas1.Top = 86;

                    equipamento_Colunas1.Visible = false;
                    break;

                case 19:
                    equipamento_PenCartoes1.Width = 20;
                    equipamento_PenCartoes1.Height = 20;

                    equipamento_PenCartoes1.Left = 389;
                    equipamento_PenCartoes1.Top = 86;

                    equipamento_PenCartoes1.Visible = false;
                    break;

                case 22:
                    componente_MotherBoard1.Width = 20;
                    componente_MotherBoard1.Height = 20;

                    componente_MotherBoard1.Left = 389;
                    componente_MotherBoard1.Top = 86;

                    componente_MotherBoard1.Visible = false;
                    break;

                case 23:
                    componente_Processador1.Width = 20;
                    componente_Processador1.Height = 20;

                    componente_Processador1.Left = 389;
                    componente_Processador1.Top = 86;

                    componente_Processador1.Visible = false;
                    break;

                case 24:
                    componente_PlacaGrafica1.Width = 20;
                    componente_PlacaGrafica1.Height = 20;

                    componente_PlacaGrafica1.Left = 389;
                    componente_PlacaGrafica1.Top = 86;

                    componente_PlacaGrafica1.Visible = false;
                    break;

                case 25:
                    componente_DiscoRigido1.Width = 20;
                    componente_DiscoRigido1.Height = 20;

                    componente_DiscoRigido1.Left = 389;
                    componente_DiscoRigido1.Top = 86;

                    componente_DiscoRigido1.Visible = false;
                    break;

                case 26:
                    componente_RAM1.Width = 20;
                    componente_RAM1.Height = 20;

                    componente_RAM1.Left = 389;
                    componente_RAM1.Top = 86;

                    componente_RAM1.Visible = false;
                    break;

                case 27:
                    componente_PlacaRede1.Width = 20;
                    componente_PlacaRede1.Height = 20;

                    componente_PlacaRede1.Left = 389;
                    componente_PlacaRede1.Top = 86;

                    componente_PlacaRede1.Visible = false;
                    break;

                case 28:
                    componente_LeitorCD1.Width = 20;
                    componente_LeitorCD1.Height = 20;

                    componente_LeitorCD1.Left = 389;
                    componente_LeitorCD1.Top = 86;

                    componente_LeitorCD1.Visible = false;
                    break;

                case 29:
                    componente_Fonte1.Width = 20;
                    componente_Fonte1.Height = 20;

                    componente_Fonte1.Left = 389;
                    componente_Fonte1.Top = 86;

                    componente_Fonte1.Visible = false;
                    break;

                case 30:
                    componente_Cooler1.Width = 20;
                    componente_Cooler1.Height = 20;

                    componente_Cooler1.Left = 389;
                    componente_Cooler1.Top = 86;

                    componente_Cooler1.Visible = false;
                    break;

                case 31:
                    componente_Caixa1.Width = 20;
                    componente_Caixa1.Height = 20;

                    componente_Caixa1.Left = 389;
                    componente_Caixa1.Top = 86;

                    componente_Caixa1.Visible = false;
                    break;

                case 32:
                    configurador2.Width = 20;
                    configurador2.Height = 20;

                    configurador2.Left = 389;
                    configurador2.Top = 86;

                    configurador2.Visible = false;
                    break;

            }
        }


        //Abre os UserControls
        public void AbrirRetroceder()
        {
            //Switch para abrir o UserControl, todos os useres controls estão identificados no metodo Info_Formularios
            switch (FormularioAnterior)
            {
                case 1:
                    //abre a aba dos computadores para venda
                    home1.Width = 815;
                    home1.Height = 575;

                    home1.Left = 242;
                    home1.Top = 66;

                    home1.Visible = true;

                    break;

                case 2:
                    //abre a aba dos computadores para venda
                    conta1.Width = 815;
                    conta1.Height = 575;

                    conta1.Left = 242;
                    conta1.Top = 66;

                    conta1.Visible = true;
                    break;

                case 3:

                    break;

                case 4:
                    //abre a aba das definições
                    definições1.Width = 815; //815
                    definições1.Height = 575; //575

                    definições1.Left = 242;
                    definições1.Top = 66;

                    definições1.Visible = true;

                    break;

                case 5:
                    //abre a aba dos computadores para venda
                    computadores1.Width = 815; //815
                    computadores1.Height = 575; //575

                    computadores1.Left = 242;
                    computadores1.Top = 66;

                    computadores1.Visible = true;

                    break;

                case 6:
                    //abre a aba dos computadores para venda
                    equipamentos1.Width = 815;
                    equipamentos1.Height = 575;

                    equipamentos1.Left = 242;
                    equipamentos1.Top = 66;

                    equipamentos1.Visible = true;
                    break;

                case 7:
                    //abre a aba dos computadores para venda
                    componentes1.Width = 815;
                    componentes1.Height = 575;

                    componentes1.Left = 242;
                    componentes1.Top = 66;

                    componentes1.Visible = true;

                    break;

                case 8:
                    //abre a aba dos computadores para venda
                    configurador1.Width = 815;
                    configurador1.Height = 575;

                    configurador1.Left = 242;
                    configurador1.Top = 66;

                    configurador1.Visible = true;

                    break;

                case 9:
                    //abre a aba dos computadores para venda
                    carrinho1.Width = 815;
                    carrinho1.Height = 575;

                    carrinho1.Left = 242;
                    carrinho1.Top = 66;

                    carrinho1.Visible = true;

                    break;

                case 10:

                    break;

                case 11:

                    break;

                case 12:

                    break;

                case 13:

                    break;

                case 14:

                    break;

                case 15:

                    break;

                case 16:

                    break;

                case 17:

                    break;

                case 18:

                    break;

                case 19:

                    break;

                case 20:

                    break;

                case 21:

                    break;

                case 22:

                    break;

                case 23:

                    break;

                case 24:

                    break;

                case 25:

                    break;

                case 26:

                    break;

                case 27:

                    break;

                case 28:

                    break;

                case 29:
                    break;

                case 30:

                    break;

                case 31:

                    break;

                case 32:

                    break;

                case 33:

                    break;

                case 34:

                    break;

                case 35:

                    break;

                case 36:
                    configurador2.Width = 20;
                    configurador2.Height = 20;

                    configurador2.Left = 389;
                    configurador2.Top = 86;

                    configurador2.Visible = false;
                    break;

                case 37:

                    break;

                case 38:

                    break;

            }
        }


        //Retira a cor permanente do form quando este muda de UserControl
        public void RetirarCor()
        {
            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //switch para escolha do formulario
            switch (FormularioAtual)
            {
                case 1:
                    B_Home.ForeColor = Color.Gray;
                    break;

                case 2:
                    B_Conta.ForeColor = Color.Gray;
                    break;

                case 4:
                    B_Definições.ForeColor = Color.Gray;
                    break;

                case 5:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;
                        case 2:
                            B_Computadores.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;
                        case 3:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;
                        case 4:
                            B_Computadores.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 6:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;
                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;
                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;
                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 7:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;
                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;
                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;
                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 8:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Configurador.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;
                        case 2:
                            B_Configurador.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;
                        case 3:
                            B_Configurador.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;
                        case 4:
                            B_Configurador.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 9:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Carrinho.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;
                        case 2:
                            B_Carrinho.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;
                        case 3:
                            B_Carrinho.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;
                        case 4:
                            B_Carrinho.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 10:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;
                        case 2:
                            B_Computadores.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;
                        case 3:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;
                        case 4:
                            B_Computadores.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 11:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;
                        case 2:
                            B_Computadores.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;
                        case 3:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;
                        case 4:
                            B_Computadores.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 12:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);                            
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 13:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;
                case 14:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 15:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 16:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 17:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 18:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 19:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 20:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 21:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 22:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 23:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 24:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 25:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 26:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 27:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 28:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 29:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;
                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;
                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;
                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 30:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 31:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;

                case 32:
                    //switch para escolher a cor
                    switch (VerMHD)
                    {
                        case 1:
                            B_Carrinho.BackColor = Color.FromArgb(PD.Cor[0, 1], 0, 0);
                            break;

                        case 2:
                            B_Carrinho.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 1]);
                            break;

                        case 3:
                            B_Carrinho.BackColor = Color.FromArgb(PD.Cor[1, 1], PD.Cor[1, 1], PD.Cor[1, 1]);
                            break;

                        case 4:
                            B_Carrinho.BackColor = Color.FromArgb(0, PD.Cor[0, 1], 0);
                            break;
                    }
                    break;
            }
        }


        //Metodo para por a cor sempre que o usercontrol esteja aberto
        public void ControlAberto_Cor(object sender, EventArgs e)
        {
            //Variavel para aceder as variaveis do form definições
            Definições PD = new Definições();

            //switch para escolher a cor
            switch (VerMHD)
            {
                //Cor Vermelha
                case 1:
                    //Switch para escolha do UserControl que esteja ativo
                    switch (FormularioAtual)
                    {
                        case 1:
                            B_Home.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

                            break;

                        case 2:
                            B_Conta.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                            break;

                        case 4:
                            B_Definições.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                            break;

                        case 5:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                            break;

                        case 6:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                            break;

                        case 7:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                            break;

                        case 8:
                            B_Configurador.BackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                            break;

                        case 9:
                            B_Carrinho.BackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                            break;

                        case 10:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                            break;

                        case 29:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[0, 2], 0, 0);
                            break;

                    }

                    break;

                //Cor azul
                case 2:
                    //Switch para escolha do UserControl que esteja ativo
                    switch (FormularioAtual)
                    {
                        case 1:
                            B_Home.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);

                            break;

                        case 2:
                            B_Conta.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                            break;

                        case 4:
                            B_Definições.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                            break;

                        case 5:
                            B_Computadores.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                            break;

                        case 6:
                            B_Equipamentos.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                            break;

                        case 7:
                            B_Componentes.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                            break;

                        case 8:
                            B_Configurador.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                            break;

                        case 9:
                            B_Carrinho.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                            break;

                        case 10:
                            B_Computadores.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 2]);
                            break;
                    }
                    break;

                //Cor Preto
                case 3:
                    //Switch para escolha do UserControl que esteja ativo
                    switch (FormularioAtual)
                    {
                        case 1:
                            B_Home.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);

                            break;

                        case 2:
                            B_Conta.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;

                        case 4:
                            B_Definições.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;

                        case 5:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;

                        case 6:
                            B_Equipamentos.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;

                        case 7:
                            B_Componentes.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;

                        case 8:
                            B_Configurador.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;

                        case 9:
                            B_Carrinho.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;

                        case 10:
                            B_Computadores.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                            break;
                    }
                    break;

                //Cor Verde
                case 4:
                    //Switch para escolha do UserControl que esteja ativo
                    switch (FormularioAtual)
                    {
                        case 1:
                            B_Home.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

                            break;

                        case 2:
                            B_Conta.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                            break;

                        case 4:
                            B_Definições.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                            break;

                        case 5:
                            B_Computadores.BackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                            break;

                        case 6:
                            B_Equipamentos.BackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                            break;

                        case 7:
                            B_Componentes.BackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                            break;

                        case 8:
                            B_Configurador.BackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                            break;

                        case 9:
                            B_Carrinho.BackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                            break;

                        case 10:
                            B_Computadores.BackColor = Color.FromArgb(0, PD.Cor[0, 2], 0);
                            break;
                    }
                    break;
            }
        }


        //Metodo para alterar a cor as labels
        public void LabelCor()
        {
            //variavel para aceder as variaveis dos forms
            Definições PD = new Definições();

            //switch para escolha de cor
            switch (VerMHD)
            {
                case 1:
                    //Form Home 
                    home1.L_ContaHome.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                    home1.L_PesquisaHome.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                    home1.L_RecentesHome.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                    home1.L_UtilizadoresHome.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                    home1.L_UsersHome.ForeColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                    home1.P_User1Home.BackColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                    home1.P_User2Home.BackColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);
                    home1.P_User3Home.BackColor = Color.FromArgb(PD.Cor[0, 0], 0, 0);

                    //Form Conta
                    conta1.L_ContaRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    conta1.L_Alterar_Foto.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    conta1.L_Alterar_User.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    conta1.L_Alterar_Pass.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    conta1.L_Alterar_Email.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    //Form Mensagens


                    //Form Definições
                    definições1.L_DefiniçõesRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    //Form Computadores
                    computadores1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    computadores1.L_Laptops.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    computadores1.L_Desktops.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    //Form PC_Portateis
                    pC_Portateis1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    //Form PC_Fixos
                    pC_Fixos1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    //Form Equipamentos
                    equipamentos1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamentos1.L_Ratos.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamentos1.L_Teclados.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamentos1.L_Tapetes.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamentos1.L_Monitores.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamentos1.L_HeadSetsFones.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamentos1.L_PenCartoes.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    
                    //FormEquipamentosIndividual
                    equipamento_Ratos1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamento_Teclados1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamento_Tapetes1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamento_Monitores1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamento_HeadSetFones1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamento_Cadeiras1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamento_Colunas1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    equipamento_PenCartoes1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    //Form Componentes
                    componentes1.L_ComponentesRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componentes1.L_MotherBoard.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componentes1.L_Processador.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componentes1.L_PlacaGrafica.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componentes1.L_DiscoRigido.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componentes1.L_MemoriaRAM.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componentes1.L_Fonte.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componentes1.L_Caixa.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    //FormComponentesIndividual
                    componente_MotherBoard1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componente_PlacaGrafica1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componente_Processador1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componente_DiscoRigido1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componente_Caixa1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componente_RAM1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);
                    componente_Fonte1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    //Form Configurador
                    configurador1.L_ConfiguradorRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    //Form Carrinho
                    carrinho1.L_CarrinhoRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[0], computadores1.CorLabels[1], computadores1.CorLabels[1]);

                    break;

                case 2:
                    //Form Home 
                    home1.L_ContaHome.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                    home1.L_PesquisaHome.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                    home1.L_RecentesHome.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                    home1.L_UtilizadoresHome.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                    home1.L_UsersHome.ForeColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                    home1.P_User1Home.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                    home1.P_User2Home.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);
                    home1.P_User3Home.BackColor = Color.FromArgb(0, 0, PD.Cor[0, 0]);

                    //Form Conta
                    conta1.L_ContaRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    conta1.L_Alterar_Foto.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    conta1.L_Alterar_User.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    conta1.L_Alterar_Pass.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    conta1.L_Alterar_Email.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //Form Mensagens


                    //Form Definições
                    definições1.L_DefiniçõesRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //Form Computadores
                    computadores1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    computadores1.L_Laptops.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    computadores1.L_Desktops.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //Form PC_Portateis
                    pC_Portateis1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //Form PC_Fixos
                    pC_Fixos1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //Form Equipamentos
                    equipamentos1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamentos1.L_Ratos.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamentos1.L_Teclados.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamentos1.L_Tapetes.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamentos1.L_Monitores.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamentos1.L_HeadSetsFones.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamentos1.L_PenCartoes.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    
                    //FormEquipamentosIndividual
                    equipamento_Ratos1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamento_Teclados1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamento_Tapetes1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamento_Monitores1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamento_HeadSetFones1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamento_Cadeiras1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamento_Colunas1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    equipamento_PenCartoes1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //Form Componentes
                    componentes1.L_ComponentesRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componentes1.L_MotherBoard.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componentes1.L_Processador.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componentes1.L_PlacaGrafica.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componentes1.L_DiscoRigido.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componentes1.L_MemoriaRAM.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componentes1.L_Fonte.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componentes1.L_Caixa.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //FormComponentesIndividual
                    componente_MotherBoard1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componente_PlacaGrafica1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componente_Processador1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componente_DiscoRigido1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componente_Caixa1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componente_RAM1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);
                    componente_Fonte1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //Form Configurador
                    configurador1.L_ConfiguradorRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    //Form Carrinho
                    carrinho1.L_CarrinhoRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[1], computadores1.CorLabels[0]);

                    break;

                case 3:
                    //Form Home 
                    home1.L_ContaHome.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                    home1.L_PesquisaHome.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                    home1.L_RecentesHome.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                    home1.L_UtilizadoresHome.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                    home1.L_UsersHome.ForeColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                    home1.P_User1Home.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                    home1.P_User2Home.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);
                    home1.P_User3Home.BackColor = Color.FromArgb(PD.Cor[1, 2], PD.Cor[1, 2], PD.Cor[1, 2]);

                    //Form Conta
                    conta1.L_ContaRetroceder.ForeColor = Color.Gray;
                    conta1.L_Alterar_Foto.ForeColor = Color.Gray;
                    conta1.L_Alterar_User.ForeColor = Color.Gray;
                    conta1.L_Alterar_Pass.ForeColor = Color.Gray;
                    conta1.L_Alterar_Email.ForeColor = Color.Gray;

                    //Form Mensagens


                    //Form Definições
                    definições1.L_DefiniçõesRetroceder.ForeColor = Color.Gray;

                    //Form Computadores
                    computadores1.L_ComputadoresRetroceder.ForeColor = Color.Gray;
                    computadores1.L_Laptops.ForeColor = Color.Gray;
                    computadores1.L_Desktops.ForeColor = Color.Gray;

                    //Form PC_Portateis
                    pC_Portateis1.L_ComputadoresRetroceder.ForeColor = Color.Gray;

                    //Form PC_Fixos
                    pC_Fixos1.L_ComputadoresRetroceder.ForeColor = Color.Gray;

                    //Form Equipamentos
                    equipamentos1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    equipamentos1.L_Ratos.ForeColor = Color.Gray;
                    equipamentos1.L_Teclados.ForeColor = Color.Gray;
                    equipamentos1.L_Tapetes.ForeColor = Color.Gray;
                    equipamentos1.L_Monitores.ForeColor = Color.Gray;
                    equipamentos1.L_HeadSetsFones.ForeColor = Color.Gray;
                    equipamentos1.L_PenCartoes.ForeColor = Color.Gray; 
                    
                    //FormEquipamentosIndividual
                    equipamento_Ratos1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    equipamento_Teclados1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    equipamento_Tapetes1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    equipamento_Monitores1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    equipamento_HeadSetFones1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    equipamento_Cadeiras1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    equipamento_Colunas1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    equipamento_PenCartoes1.L_EquipamentosRetroceder.ForeColor = Color.Gray;

                    //Form Componentes
                    componentes1.L_ComponentesRetroceder.ForeColor = Color.Gray;
                    componentes1.L_MotherBoard.ForeColor = Color.Gray;
                    componentes1.L_Processador.ForeColor = Color.Gray;
                    componentes1.L_PlacaGrafica.ForeColor = Color.Gray;
                    componentes1.L_DiscoRigido.ForeColor = Color.Gray;
                    componentes1.L_MemoriaRAM.ForeColor = Color.Gray;
                    componentes1.L_Fonte.ForeColor = Color.Gray;
                    componentes1.L_Caixa.ForeColor = Color.Gray;

                    //FormComponentesIndividual
                    componente_MotherBoard1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    componente_PlacaGrafica1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    componente_Processador1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    componente_DiscoRigido1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    componente_Caixa1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    componente_RAM1.L_EquipamentosRetroceder.ForeColor = Color.Gray;
                    componente_Fonte1.L_EquipamentosRetroceder.ForeColor = Color.Gray;

                    //Form Configurador
                    configurador1.L_ConfiguradorRetroceder.ForeColor = Color.Gray;

                    //Form Carrinho
                    carrinho1.L_CarrinhoRetroceder.ForeColor = Color.Gray;

                    break;

                case 4:
                    //Form Home 
                    home1.L_ContaHome.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                    home1.L_PesquisaHome.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                    home1.L_RecentesHome.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                    home1.L_UtilizadoresHome.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                    home1.L_UsersHome.ForeColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                    home1.P_User1Home.BackColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                    home1.P_User2Home.BackColor = Color.FromArgb(0, PD.Cor[0, 0], 0);
                    home1.P_User3Home.BackColor = Color.FromArgb(0, PD.Cor[0, 0], 0);

                    //Form Conta
                    conta1.L_ContaRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    conta1.L_Alterar_Foto.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    conta1.L_Alterar_User.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    conta1.L_Alterar_Pass.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    conta1.L_Alterar_Email.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    //Form Mensagens


                    //Form Definições
                    definições1.L_DefiniçõesRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    //Form Computadores
                    computadores1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    computadores1.L_Laptops.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    computadores1.L_Desktops.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    //Form PC_Portateis
                    pC_Portateis1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    //Form PC_Fixos
                    pC_Fixos1.L_ComputadoresRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    //Form Equipamentos
                    equipamentos1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamentos1.L_Ratos.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamentos1.L_Teclados.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamentos1.L_Tapetes.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamentos1.L_Monitores.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamentos1.L_HeadSetsFones.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamentos1.L_PenCartoes.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    
                    //FormEquipamentosIndividual
                    equipamento_Ratos1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamento_Teclados1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamento_Tapetes1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamento_Monitores1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamento_HeadSetFones1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamento_Cadeiras1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamento_Colunas1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    equipamento_PenCartoes1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);


                    //Form Componentes
                    componentes1.L_ComponentesRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componentes1.L_MotherBoard.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componentes1.L_Processador.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componentes1.L_PlacaGrafica.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componentes1.L_DiscoRigido.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componentes1.L_MemoriaRAM.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componentes1.L_Fonte.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componentes1.L_Caixa.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    //FormComponentesIndividual
                    componente_MotherBoard1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componente_PlacaGrafica1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componente_Processador1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componente_DiscoRigido1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componente_Caixa1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componente_RAM1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);
                    componente_Fonte1.L_EquipamentosRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    //Form Configurador
                    configurador1.L_ConfiguradorRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    //Form Carrinho
                    carrinho1.L_CarrinhoRetroceder.ForeColor = Color.FromArgb(computadores1.CorLabels[1], computadores1.CorLabels[0], computadores1.CorLabels[1]);

                    break;
            }
        }


        //Metodo Carrinho
        public void Descarregar()
        {
            Conecao();

            string query = "Select * from carrinho where Username = '" + Username + "'";

            MySqlCommand cmd = new MySqlCommand(query, ola);

            MySqlDataReader Ler = cmd.ExecuteReader();

            int i = 0;

            while (Ler.Read())
            {
                Strings[i, 0] = Ler.GetString(Ler.GetOrdinal("CodRegisto"));
                Strings[i, 1] = Ler.GetString(Ler.GetOrdinal("CodProduto"));
                Strings[i, 2] = Ler.GetString(Ler.GetOrdinal("NomeProduto"));
                inteiros[i] = Ler.GetInt32(Ler.GetOrdinal("Quantidade"));
                decimais[i] = Ler.GetDecimal(Ler.GetOrdinal("Preco"));

                i = i + 1;

            }

            Ler.Close();

            query = "Select Dinheiro from cliente where Username = '" + Username + "'";

            cmd = new MySqlCommand(query, ola);

            Ler = cmd.ExecuteReader();

            while (Ler.Read())
            {
                carrinho1.PreçoConta.Text = Ler.GetDecimal(Ler.GetOrdinal("Dinheiro")) + " €";
            }

            Ler.Close();
        }


        //Metodo Carregar Carrinho
        public void Carregar()
        {
            Carrinho PD = new Carrinho();
            
            if (inteiros[7] == 0)
            {
                if (inteiros[6] == 0)
                {
                    if (inteiros[5] == 0)
                    {
                        if (inteiros[4] == 0)
                        {
                            if (inteiros[3] == 0)
                            {
                                if (inteiros[2] == 0)
                                {
                                    if (inteiros[1] == 0)
                                    {
                                        if (inteiros[0] == 0)
                                        {
                                            carrinho1.Check1.Visible = false;
                                            carrinho1.Check2.Visible = false;
                                            carrinho1.Check3.Visible = false;
                                            carrinho1.Check4.Visible = false;
                                            carrinho1.Check5.Visible = false;
                                            carrinho1.Check6.Visible = false;
                                            carrinho1.Check7.Visible = false;
                                            carrinho1.Check8.Visible = false;

                                            carrinho1.Check1.Enabled = false;
                                            carrinho1.Check2.Enabled = false;
                                            carrinho1.Check3.Enabled = false;
                                            carrinho1.Check4.Enabled = false;
                                            carrinho1.Check5.Enabled = false;
                                            carrinho1.Check6.Enabled = false;
                                            carrinho1.Check7.Enabled = false;
                                            carrinho1.Check8.Enabled = false;
                                        }
                                        else
                                        {
                                            carrinho1.Codigo1.Text = Strings[0, 0];

                                            carrinho1.CodigoProduto1.Text = Strings[0, 1];

                                            carrinho1.Produto1.Text = Strings[0, 2];

                                            carrinho1.Quantidade1.Text = "" + inteiros[0];

                                            carrinho1.Preço1.Text = (inteiros[0] * decimais[0]) + " €";

                                            carrinho1.Check1.Visible = true;
                                            carrinho1.Check2.Visible = false;
                                            carrinho1.Check3.Visible = false;
                                            carrinho1.Check4.Visible = false;
                                            carrinho1.Check5.Visible = false;
                                            carrinho1.Check6.Visible = false;
                                            carrinho1.Check7.Visible = false;
                                            carrinho1.Check8.Visible = false;

                                            carrinho1.Check1.Enabled = true;
                                            carrinho1.Check2.Enabled = false;
                                            carrinho1.Check3.Enabled = false;
                                            carrinho1.Check4.Enabled = false;
                                            carrinho1.Check5.Enabled = false;
                                            carrinho1.Check6.Enabled = false;
                                            carrinho1.Check7.Enabled = false;
                                            carrinho1.Check8.Enabled = false;


                                        }
                                    }
                                    else
                                    {
                                        carrinho1.Codigo1.Text = Strings[0, 0];
                                        carrinho1.Codigo2.Text = Strings[1, 0];

                                        carrinho1.CodigoProduto1.Text = Strings[0, 1];
                                        carrinho1.CodigoProduto2.Text = Strings[1, 1];

                                        carrinho1.Produto1.Text = Strings[0, 2];
                                        carrinho1.Produto2.Text = Strings[1, 2];

                                        carrinho1.Quantidade1.Text = "" + inteiros[0];
                                        carrinho1.Quantidade2.Text = "" + inteiros[1];

                                        carrinho1.Preço1.Text = (inteiros[0] * decimais[0]) + " €";
                                        carrinho1.Preço2.Text = (inteiros[1] * decimais[1]) + " €";

                                        carrinho1.Check1.Visible = true;
                                        carrinho1.Check2.Visible = true;
                                        carrinho1.Check3.Visible = false;
                                        carrinho1.Check4.Visible = false;
                                        carrinho1.Check5.Visible = false;
                                        carrinho1.Check6.Visible = false;
                                        carrinho1.Check7.Visible = false;
                                        carrinho1.Check8.Visible = false;

                                        carrinho1.Check1.Enabled = true;
                                        carrinho1.Check2.Enabled = true;
                                        carrinho1.Check3.Enabled = false;
                                        carrinho1.Check4.Enabled = false;
                                        carrinho1.Check5.Enabled = false;
                                        carrinho1.Check6.Enabled = false;
                                        carrinho1.Check7.Enabled = false;
                                        carrinho1.Check8.Enabled = false;

                                    }
                                }
                                else
                                {
                                    carrinho1.Codigo1.Text = Strings[0, 0];
                                    carrinho1.Codigo2.Text = Strings[1, 0];
                                    carrinho1.Codigo3.Text = Strings[2, 0];

                                    carrinho1.CodigoProduto1.Text = Strings[0, 1];
                                    carrinho1.CodigoProduto2.Text = Strings[1, 1];
                                    carrinho1.CodigoProduto3.Text = Strings[2, 1];

                                    carrinho1.Produto1.Text = Strings[0, 2];
                                    carrinho1.Produto2.Text = Strings[1, 2];
                                    carrinho1.Produto3.Text = Strings[2, 2];

                                    carrinho1.Quantidade1.Text = "" + inteiros[0];
                                    carrinho1.Quantidade2.Text = "" + inteiros[1];
                                    carrinho1.Quantidade3.Text = "" + inteiros[2];

                                    carrinho1.Preço1.Text = (inteiros[0] * decimais[0]) + " €";
                                    carrinho1.Preço2.Text = (inteiros[1] * decimais[1]) + " €";
                                    carrinho1.Preço3.Text = (inteiros[2] * decimais[2]) + " €";

                                    carrinho1.Check1.Visible = true;
                                    carrinho1.Check2.Visible = true;
                                    carrinho1.Check3.Visible = true;
                                    carrinho1.Check4.Visible = false;
                                    carrinho1.Check5.Visible = false;
                                    carrinho1.Check6.Visible = false;
                                    carrinho1.Check7.Visible = false;
                                    carrinho1.Check8.Visible = false;

                                    carrinho1.Check1.Enabled = true;
                                    carrinho1.Check2.Enabled = true;
                                    carrinho1.Check3.Enabled = true;
                                    carrinho1.Check4.Enabled = false;
                                    carrinho1.Check5.Enabled = false;
                                    carrinho1.Check6.Enabled = false;
                                    carrinho1.Check7.Enabled = false;
                                    carrinho1.Check8.Enabled = false;

                                }
                            }
                            else
                            {
                                carrinho1.Codigo1.Text = Strings[0, 0];
                                carrinho1.Codigo2.Text = Strings[1, 0];
                                carrinho1.Codigo3.Text = Strings[2, 0];
                                carrinho1.Codigo4.Text = Strings[3, 0];

                                carrinho1.CodigoProduto1.Text = Strings[0, 1];
                                carrinho1.CodigoProduto2.Text = Strings[1, 1];
                                carrinho1.CodigoProduto3.Text = Strings[2, 1];
                                carrinho1.CodigoProduto4.Text = Strings[3, 1];

                                carrinho1.Produto1.Text = Strings[0, 2];
                                carrinho1.Produto2.Text = Strings[1, 2];
                                carrinho1.Produto3.Text = Strings[2, 2];
                                carrinho1.Produto4.Text = Strings[3, 2];

                                carrinho1.Quantidade1.Text = "" + inteiros[0];
                                carrinho1.Quantidade2.Text = "" + inteiros[1];
                                carrinho1.Quantidade3.Text = "" + inteiros[2];
                                carrinho1.Quantidade4.Text = "" + inteiros[3];

                                carrinho1.Preço1.Text = (inteiros[0] * decimais[0]) + " €";
                                carrinho1.Preço2.Text = (inteiros[1] * decimais[1]) + " €";
                                carrinho1.Preço3.Text = (inteiros[2] * decimais[2]) + " €";
                                carrinho1.Preço4.Text = (inteiros[3] * decimais[3]) + " €";

                                carrinho1.Check1.Visible = true;
                                carrinho1.Check2.Visible = true;
                                carrinho1.Check3.Visible = true;
                                carrinho1.Check4.Visible = true;
                                carrinho1.Check5.Visible = false;
                                carrinho1.Check6.Visible = false;
                                carrinho1.Check7.Visible = false;
                                carrinho1.Check8.Visible = false;

                                carrinho1.Check1.Enabled = true;
                                carrinho1.Check2.Enabled = true;
                                carrinho1.Check3.Enabled = true;
                                carrinho1.Check4.Enabled = true;
                                carrinho1.Check5.Enabled = false;
                                carrinho1.Check6.Enabled = false;
                                carrinho1.Check7.Enabled = false;
                                carrinho1.Check8.Enabled = false;

                            }
                        }
                        else
                        {
                            carrinho1.Codigo1.Text = Strings[0, 0];
                            carrinho1.Codigo2.Text = Strings[1, 0];
                            carrinho1.Codigo3.Text = Strings[2, 0];
                            carrinho1.Codigo4.Text = Strings[3, 0];
                            carrinho1.Codigo5.Text = Strings[4, 0];

                            carrinho1.CodigoProduto1.Text = Strings[0, 1];
                            carrinho1.CodigoProduto2.Text = Strings[1, 1];
                            carrinho1.CodigoProduto3.Text = Strings[2, 1];
                            carrinho1.CodigoProduto4.Text = Strings[3, 1];
                            carrinho1.CodigoProduto5.Text = Strings[4, 1];

                            carrinho1.Produto1.Text = Strings[0, 2];
                            carrinho1.Produto2.Text = Strings[1, 2];
                            carrinho1.Produto3.Text = Strings[2, 2];
                            carrinho1.Produto4.Text = Strings[3, 2];
                            carrinho1.Produto5.Text = Strings[4, 2];

                            carrinho1.Quantidade1.Text = "" + inteiros[0];
                            carrinho1.Quantidade2.Text = "" + inteiros[1];
                            carrinho1.Quantidade3.Text = "" + inteiros[2];
                            carrinho1.Quantidade4.Text = "" + inteiros[3];
                            carrinho1.Quantidade5.Text = "" + inteiros[4];

                            carrinho1.Preço1.Text = (inteiros[0] * decimais[0]) + " €";
                            carrinho1.Preço2.Text = (inteiros[1] * decimais[1]) + " €";
                            carrinho1.Preço3.Text = (inteiros[2] * decimais[2]) + " €";
                            carrinho1.Preço4.Text = (inteiros[3] * decimais[3]) + " €";
                            carrinho1.Preço5.Text = (inteiros[4] * decimais[4]) + " €";
                            carrinho1.Check1.Visible = true;
                            carrinho1.Check2.Visible = true;
                            carrinho1.Check3.Visible = true;
                            carrinho1.Check4.Visible = true;
                            carrinho1.Check5.Visible = true;
                            carrinho1.Check6.Visible = false;
                            carrinho1.Check7.Visible = false;
                            carrinho1.Check8.Visible = false;

                            carrinho1.Check1.Enabled = true;
                            carrinho1.Check2.Enabled = true;
                            carrinho1.Check3.Enabled = true;
                            carrinho1.Check4.Enabled = true;
                            carrinho1.Check5.Enabled = true;
                            carrinho1.Check6.Enabled = false;
                            carrinho1.Check7.Enabled = false;
                            carrinho1.Check8.Enabled = false;

                        }
                    }
                    else
                    {
                        carrinho1.Codigo1.Text = Strings[0, 0];
                        carrinho1.Codigo2.Text = Strings[1, 0];
                        carrinho1.Codigo3.Text = Strings[2, 0];
                        carrinho1.Codigo4.Text = Strings[3, 0];
                        carrinho1.Codigo5.Text = Strings[4, 0];
                        carrinho1.Codigo6.Text = Strings[5, 0];

                        carrinho1.CodigoProduto1.Text = Strings[0, 1];
                        carrinho1.CodigoProduto2.Text = Strings[1, 1];
                        carrinho1.CodigoProduto3.Text = Strings[2, 1];
                        carrinho1.CodigoProduto4.Text = Strings[3, 1];
                        carrinho1.CodigoProduto5.Text = Strings[4, 1];
                        carrinho1.CodigoProduto6.Text = Strings[5, 1];

                        carrinho1.Produto1.Text = Strings[0, 2];
                        carrinho1.Produto2.Text = Strings[1, 2];
                        carrinho1.Produto3.Text = Strings[2, 2];
                        carrinho1.Produto4.Text = Strings[3, 2];
                        carrinho1.Produto5.Text = Strings[4, 2];
                        carrinho1.Produto6.Text = Strings[5, 2];

                        carrinho1.Quantidade1.Text = "" + inteiros[0];
                        carrinho1.Quantidade2.Text = "" + inteiros[1];
                        carrinho1.Quantidade3.Text = "" + inteiros[2];
                        carrinho1.Quantidade4.Text = "" + inteiros[3];
                        carrinho1.Quantidade5.Text = "" + inteiros[4];
                        carrinho1.Quantidade6.Text = "" + inteiros[5];

                        carrinho1.Preço1.Text = (inteiros[0] * decimais[0]) + " €";
                        carrinho1.Preço2.Text = (inteiros[1] * decimais[1]) + " €";
                        carrinho1.Preço3.Text = (inteiros[2] * decimais[2]) + " €";
                        carrinho1.Preço4.Text = (inteiros[3] * decimais[3]) + " €";
                        carrinho1.Preço5.Text = (inteiros[4] * decimais[4]) + " €";
                        carrinho1.Preço6.Text = (inteiros[5] * decimais[5]) + " €";

                        carrinho1.Check1.Visible = true;
                        carrinho1.Check2.Visible = true;
                        carrinho1.Check3.Visible = true;
                        carrinho1.Check4.Visible = true;
                        carrinho1.Check5.Visible = true;
                        carrinho1.Check6.Visible = true;
                        carrinho1.Check7.Visible = false;
                        carrinho1.Check8.Visible = false;

                        carrinho1.Check1.Enabled = true;
                        carrinho1.Check2.Enabled = true;
                        carrinho1.Check3.Enabled = true;
                        carrinho1.Check4.Enabled = true;
                        carrinho1.Check5.Enabled = true;
                        carrinho1.Check6.Enabled = true;
                        carrinho1.Check7.Enabled = false;
                        carrinho1.Check8.Enabled = false;

                    }
                }
                else
                {
                    carrinho1.Codigo1.Text = Strings[0, 0];
                    carrinho1.Codigo2.Text = Strings[1, 0];
                    carrinho1.Codigo3.Text = Strings[2, 0];
                    carrinho1.Codigo4.Text = Strings[3, 0];
                    carrinho1.Codigo5.Text = Strings[4, 0];
                    carrinho1.Codigo6.Text = Strings[5, 0];
                    carrinho1.Codigo7.Text = Strings[6, 0];

                    carrinho1.CodigoProduto1.Text = Strings[0, 1];
                    carrinho1.CodigoProduto2.Text = Strings[1, 1];
                    carrinho1.CodigoProduto3.Text = Strings[2, 1];
                    carrinho1.CodigoProduto4.Text = Strings[3, 1];
                    carrinho1.CodigoProduto5.Text = Strings[4, 1];
                    carrinho1.CodigoProduto6.Text = Strings[5, 1];
                    carrinho1.CodigoProduto7.Text = Strings[6, 1];

                    carrinho1.Produto1.Text = Strings[0, 2];
                    carrinho1.Produto2.Text = Strings[1, 2];
                    carrinho1.Produto3.Text = Strings[2, 2];
                    carrinho1.Produto4.Text = Strings[3, 2];
                    carrinho1.Produto5.Text = Strings[4, 2];
                    carrinho1.Produto6.Text = Strings[5, 2];
                    carrinho1.Produto7.Text = Strings[6, 2];

                    carrinho1.Quantidade1.Text = "" + inteiros[0];
                    carrinho1.Quantidade2.Text = "" + inteiros[1];
                    carrinho1.Quantidade3.Text = "" + inteiros[2];
                    carrinho1.Quantidade4.Text = "" + inteiros[3];
                    carrinho1.Quantidade5.Text = "" + inteiros[4];
                    carrinho1.Quantidade6.Text = "" + inteiros[5];
                    carrinho1.Quantidade7.Text = "" + inteiros[6];

                    carrinho1.Preço1.Text = (inteiros[0] * decimais[0]) + " €";
                    carrinho1.Preço2.Text = (inteiros[1] * decimais[1]) + " €";
                    carrinho1.Preço3.Text = (inteiros[2] * decimais[2]) + " €";
                    carrinho1.Preço4.Text = (inteiros[3] * decimais[3]) + " €";
                    carrinho1.Preço5.Text = (inteiros[4] * decimais[4]) + " €";
                    carrinho1.Preço6.Text = (inteiros[5] * decimais[5]) + " €";
                    carrinho1.Preço7.Text = (inteiros[6] * decimais[6]) + " €";

                    carrinho1.Check1.Visible = true;
                    carrinho1.Check2.Visible = true;
                    carrinho1.Check3.Visible = true;
                    carrinho1.Check4.Visible = true;
                    carrinho1.Check5.Visible = true;
                    carrinho1.Check6.Visible = true;
                    carrinho1.Check7.Visible = true;
                    carrinho1.Check8.Visible = false;

                    carrinho1.Check1.Enabled = true;
                    carrinho1.Check2.Enabled = true;
                    carrinho1.Check3.Enabled = true;
                    carrinho1.Check4.Enabled = true;
                    carrinho1.Check5.Enabled = true;
                    carrinho1.Check6.Enabled = true;
                    carrinho1.Check7.Enabled = true;
                    carrinho1.Check8.Enabled = false;

                }
            }
            else
            {
                carrinho1.Codigo1.Text = Strings[0, 0];
                carrinho1.Codigo2.Text = Strings[1, 0];
                carrinho1.Codigo3.Text = Strings[2, 0];
                carrinho1.Codigo4.Text = Strings[3, 0];
                carrinho1.Codigo5.Text = Strings[4, 0];
                carrinho1.Codigo6.Text = Strings[5, 0];
                carrinho1.Codigo7.Text = Strings[6, 0];
                carrinho1.Codigo8.Text = Strings[7, 0];

                carrinho1.CodigoProduto1.Text = Strings[0, 1];
                carrinho1.CodigoProduto2.Text = Strings[1, 1];
                carrinho1.CodigoProduto3.Text = Strings[2, 1];
                carrinho1.CodigoProduto4.Text = Strings[3, 1];
                carrinho1.CodigoProduto5.Text = Strings[4, 1];
                carrinho1.CodigoProduto6.Text = Strings[5, 1];
                carrinho1.CodigoProduto7.Text = Strings[6, 1];
                carrinho1.CodigoProduto8.Text = Strings[7, 1];

                carrinho1.Produto1.Text = Strings[0, 2];
                carrinho1.Produto2.Text = Strings[1, 2];
                carrinho1.Produto3.Text = Strings[2, 2];
                carrinho1.Produto4.Text = Strings[3, 2];
                carrinho1.Produto5.Text = Strings[4, 2];
                carrinho1.Produto6.Text = Strings[5, 2];
                carrinho1.Produto7.Text = Strings[6, 2];
                carrinho1.Produto8.Text = Strings[7, 2];

                carrinho1.Quantidade1.Text = "" + inteiros[0];
                carrinho1.Quantidade2.Text = "" + inteiros[1];
                carrinho1.Quantidade3.Text = "" + inteiros[2];
                carrinho1.Quantidade4.Text = "" + inteiros[3];
                carrinho1.Quantidade5.Text = "" + inteiros[4];
                carrinho1.Quantidade6.Text = "" + inteiros[5];
                carrinho1.Quantidade7.Text = "" + inteiros[6];
                carrinho1.Quantidade8.Text = "" + inteiros[7];

                carrinho1.Preço1.Text = (inteiros[0] * decimais[0]) + " €";
                carrinho1.Preço2.Text = (inteiros[1] * decimais[1]) + " €";
                carrinho1.Preço3.Text = (inteiros[2] * decimais[2]) + " €";
                carrinho1.Preço4.Text = (inteiros[3] * decimais[3]) + " €";
                carrinho1.Preço5.Text = (inteiros[4] * decimais[4]) + " €";
                carrinho1.Preço6.Text = (inteiros[5] * decimais[5]) + " €";
                carrinho1.Preço7.Text = (inteiros[6] * decimais[6]) + " €";
                carrinho1.Preço8.Text = (inteiros[7] * decimais[7]) + " €";

                carrinho1.Check1.Visible = true;
                carrinho1.Check2.Visible = true;
                carrinho1.Check3.Visible = true;
                carrinho1.Check4.Visible = true;
                carrinho1.Check5.Visible = true;
                carrinho1.Check6.Visible = true;
                carrinho1.Check7.Visible = true;
                carrinho1.Check8.Visible = true;

                carrinho1.Check1.Enabled = true;
                carrinho1.Check2.Enabled = true;
                carrinho1.Check3.Enabled = true;
                carrinho1.Check4.Enabled = true;
                carrinho1.Check5.Enabled = true;
                carrinho1.Check6.Enabled = true;
                carrinho1.Check7.Enabled = true;
                carrinho1.Check8.Enabled = true;

            }

        }

        public void CarrinhoDefault()
        {
            Carrinho PD = new Carrinho();

            carrinho1.Codigo1.Text = "";
            carrinho1.Codigo2.Text = "";
            carrinho1.Codigo3.Text = "";
            carrinho1.Codigo4.Text = "";
            carrinho1.Codigo5.Text = "";
            carrinho1.Codigo6.Text = "";
            carrinho1.Codigo7.Text = "";
            carrinho1.Codigo8.Text = "";

            carrinho1.Check1.Checked = false;
            carrinho1.Check2.Checked = false;
            carrinho1.Check3.Checked = false;
            carrinho1.Check4.Checked = false;
            carrinho1.Check5.Checked = false;
            carrinho1.Check6.Checked = false;
            carrinho1.Check7.Checked = false;
            carrinho1.Check8.Checked = false;

            carrinho1.CodigoProduto1.Text = "";
            carrinho1.CodigoProduto2.Text = "";
            carrinho1.CodigoProduto3.Text = "";
            carrinho1.CodigoProduto4.Text = "";
            carrinho1.CodigoProduto5.Text = "";
            carrinho1.CodigoProduto6.Text = "";
            carrinho1.CodigoProduto7.Text = "";
            carrinho1.CodigoProduto8.Text = "";

            carrinho1.Produto1.Text = "";
            carrinho1.Produto2.Text = "";
            carrinho1.Produto3.Text = "";
            carrinho1.Produto4.Text = "";
            carrinho1.Produto5.Text = "";
            carrinho1.Produto6.Text = "";
            carrinho1.Produto7.Text = "";
            carrinho1.Produto8.Text = "";

            carrinho1.Quantidade1.Text = "";
            carrinho1.Quantidade2.Text = "";
            carrinho1.Quantidade3.Text = "";
            carrinho1.Quantidade4.Text = "";
            carrinho1.Quantidade5.Text = "";
            carrinho1.Quantidade6.Text = "";
            carrinho1.Quantidade7.Text = "";
            carrinho1.Quantidade8.Text = "";

            carrinho1.Preço1.Text = "";
            carrinho1.Preço2.Text = "";
            carrinho1.Preço3.Text = "";
            carrinho1.Preço4.Text = "";
            carrinho1.Preço5.Text = "";
            carrinho1.Preço6.Text = "";
            carrinho1.Preço7.Text = "";
            carrinho1.Preço8.Text = "";

            Strings[0, 0] = "";
            Strings[0, 1] = "";
            Strings[0, 2] = "";

            Strings[1, 0] = "";
            Strings[1, 1] = "";
            Strings[1, 2] = "";

            Strings[2, 0] = "";
            Strings[2, 1] = "";
            Strings[2, 2] = "";

            Strings[3, 0] = "";
            Strings[3, 1] = "";
            Strings[3, 2] = "";

            Strings[4, 0] = "";
            Strings[4, 1] = "";
            Strings[4, 2] = "";

            Strings[5, 0] = "";
            Strings[5, 1] = "";
            Strings[5, 2] = "";

            Strings[6, 0] = "";
            Strings[6, 1] = "";
            Strings[6, 2] = "";

            Strings[7, 0] = "";
            Strings[7, 1] = "";
            Strings[7, 2] = "";

            inteiros[0] = 0;
            inteiros[1] = 0;
            inteiros[2] = 0;
            inteiros[3] = 0;
            inteiros[4] = 0;
            inteiros[5] = 0;
            inteiros[6] = 0;
            inteiros[7] = 0;

            decimais[0] = 0;
            decimais[1] = 0;
            decimais[2] = 0;
            decimais[3] = 0;
            decimais[4] = 0;
            decimais[5] = 0;
            decimais[6] = 0;
            decimais[7] = 0;
        }
    }
}
