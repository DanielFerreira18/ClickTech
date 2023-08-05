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
    public partial class Home : UserControl
    {
        //propriedades do form
        public Home()
        {
            InitializeComponent();
        }

        //Metodo load do form
        private void Home_Load(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            try
            { 
                PD.query = "Select Count(*) as Conta from acessos";

                MySqlCommand cmd = new MySqlCommand(PD.query, PD.ola);

                MySqlDataReader ler = cmd.ExecuteReader();

                string conta = "";

                while (ler.Read())
                {
                    conta = ler.GetString(ler.GetOrdinal("Conta"));
                }

                ler.Close();

                L_UsersHome.Text = conta;

                PD.query = "Select * from cliente where Username = '" + PD.Username + "'";

                cmd = new MySqlCommand(PD.query, PD.ola);

                ler = cmd.ExecuteReader();

                while (ler.Read())
                {
                    label8.Text = ler.GetString(ler.GetOrdinal("NomeCliente"));
                    label7.Text = ler.GetString(ler.GetOrdinal("Apelido"));
                    label6.Text = ler.GetInt32(ler.GetOrdinal("Idade")) + "";
                    label4.Text = ler.GetString(ler.GetOrdinal("Pais"));
                    label3.Text = ler.GetString(ler.GetOrdinal("Cidade"));
                }

                ler.Close();
            }
            catch (Exception a)
            {
              
            }
                
        }

        //Metodos Click
        private void HomeAdmin2_Click(object sender, EventArgs e)
        {

        }
    }
}
