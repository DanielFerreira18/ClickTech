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
    public partial class Configurador : UserControl
    {
        //propriedades do form
        public Configurador()
        {
            InitializeComponent();
        }

        string query;
        double contatotal;
        int contacaixa;
        int contafonte;
        int contamother;
        int contacpu;
        int contagrafica;
        int contaram;
        int contadisco1;
        int contadisco2;

        double contaatualcaixa;
        double contaatualfonte;
        double contaatualmother;
        double contaatualcpu;
        double contaatualgrafica;
        double contaatualram;
        double contaatualdisco1;
        double contaatualdisco2;

        //metodo load do form
        private void Configurador_Load(object sender, EventArgs e)
        {
            contatotal = 0;
        }

        private void C_Caixa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Caixa.SelectedItem == null)
            {
                contacaixa = 0;
            }
            else
            {
                if (contacaixa == 0)
                {
                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Caixa.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualcaixa = contaatual;

                    label10.Text = contatotal + " €";

                    contacaixa = contacaixa + 1;
                }
                else
                {
                    contatotal = contatotal - contaatualcaixa;

                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Caixa.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualcaixa = contaatual;

                    label10.Text = contatotal + " €";

                    contacaixa = contacaixa + 1;
                }

            }

        }

        private void C_Fonte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Fonte.SelectedItem == null)
            {
                contafonte = 0;
            }
            else
            {
                if (contafonte == 0)
                {
                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Fonte.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualfonte = contaatual;

                    label10.Text = contatotal + " €";

                    contafonte = contafonte + 1;
                }
                else
                {
                    contatotal = contatotal - contaatualfonte;

                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Fonte.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualfonte = contaatual;

                    label10.Text = contatotal + " €";

                    contafonte = contafonte + 1;
                }

            }
        }

        private void C_MotherBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_MotherBoard.SelectedItem == null)
            {
                contamother = 0;
            }
            else
            {
                if (contamother == 0)
                {
                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_MotherBoard.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualmother = contaatual;

                    label10.Text = contatotal + " €";

                    contamother = contamother + 1;
                }
                else
                {
                    contatotal = contatotal - contaatualmother;

                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_MotherBoard.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualmother = contaatual;

                    label10.Text = contatotal + " €";

                    contamother = contamother + 1;
                }

            }
        }

        private void C_Processador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Processador.SelectedItem == null)
            {
                contacpu = 0;
            }
            else
            {
                if (contacpu == 0)
                {
                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Processador.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualcpu = contaatual;

                    label10.Text = contatotal + " €";

                    contacpu = contacpu + 1;
                }
                else
                {
                    contatotal = contatotal - contaatualcpu;

                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Processador.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualcpu = contaatual;

                    label10.Text = contatotal + " €";

                    contacpu = contacpu + 1;
                }

            }
        }

        private void C_Grafica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Grafica.SelectedItem == null)
            {
                contagrafica = 0;
            }
            else
            {
                if (contagrafica == 0)
                {
                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Grafica.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualgrafica = contaatual;

                    label10.Text = contatotal + " €";

                    contagrafica = contagrafica + 1;
                }
                else
                {
                    contatotal = contatotal - contaatualgrafica;

                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Grafica.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualgrafica = contaatual;

                    label10.Text = contatotal + " €";

                    contagrafica = contagrafica + 1;
                }

            }
        }

        private void C_RAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_RAM.SelectedItem == null)
            {
                contaram = 0;
            }
            else
            {
                if (contaram == 0)
                {
                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_RAM.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualram = contaatual;

                    label10.Text = contatotal + " €";

                    contaram = contaram + 1;
                }
                else
                {
                    contatotal = contatotal - contaatualram;

                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_RAM.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualram = contaatual;

                    label10.Text = contatotal + " €";

                    contaram = contaram + 1;
                }

            }
        }

        private void C_Disco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Disco.SelectedItem == null)
            {
                contadisco1 = 0;
            }
            else
            {
                if (contadisco1 == 0)
                {
                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Disco.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualdisco1 = contaatual;

                    label10.Text = contatotal + " €";

                    contadisco1 = contadisco1 + 1;
                }
                else
                {
                    contatotal = contatotal - contaatualdisco1;

                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Disco.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualdisco1 = contaatual;

                    label10.Text = contatotal + " €";

                    contadisco1 = contadisco1 + 1;
                }

            }
        }

        private void C_Disco2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_Disco2.SelectedItem == null)
            {
                contadisco2 = 0;
            }
            else
            {
                if (contadisco2 == 0)
                {
                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Disco2.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualdisco2 = contaatual;

                    label10.Text = contatotal + " €";

                    contadisco2 = contadisco2 + 1;
                }
                else
                {
                    contatotal = contatotal - contaatualdisco2;

                    FLayout PD = (FLayout)this.Parent;

                    double contaatual;
                    string preco = "";

                    query = "Select Preco from stock where NomeProduto = '" + C_Disco2.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                    MySqlDataReader ler = cmd.ExecuteReader();

                    while (ler.Read())
                    {
                        preco = ler.GetDecimal(ler.GetOrdinal("Preco")) + "";

                    }

                    ler.Close();

                    preco = preco.ToString().Replace(".", ",");
                    contaatual = Double.Parse(preco);

                    contatotal = contatotal + contaatual;

                    contaatualdisco2 = contaatual;

                    label10.Text = contatotal + " €";

                    contadisco2 = contadisco2 + 1;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contatotal = 0;

            C_Caixa.SelectedItem = null;
            C_Fonte.SelectedItem = null;
            C_MotherBoard.SelectedItem = null;
            C_Processador.SelectedItem = null;
            C_Grafica.SelectedItem = null;
            C_RAM.SelectedItem = null;
            C_Disco.SelectedItem = null;
            C_Disco2.SelectedItem = null;

            label10.Text = "0 €";
        }

        private void B_Avançar_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            if (C_Caixa.Text != "")
            {
                if (C_Fonte.Text != "")
                {
                    if (C_MotherBoard.Text != "")
                    {
                        if (C_Processador.Text != "")
                        {
                            if (C_Grafica.Text != "")
                            {
                                if (C_RAM.Text != "")
                                {
                                    if (C_Disco.Text != "")
                                    {
                                        int quantidade = 0;

                                        query = "Select Quantidade from stock where NomeProduto = '" + C_Caixa.Text +"'";

                                        MySqlCommand cmd = new MySqlCommand(query, PD.ola);

                                        MySqlDataReader ler = cmd.ExecuteReader();

                                        while (ler.Read())
                                        {
                                            quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                        }

                                        ler.Close();

                                        if (quantidade != 0)
                                        {
                                            query = "Select Quantidade from stock where NomeProduto = '" + C_Fonte.Text + "'";

                                            cmd = new MySqlCommand(query, PD.ola);

                                            ler = cmd.ExecuteReader();

                                            while (ler.Read())
                                            {
                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                            }

                                            ler.Close();

                                            if (quantidade != 0)
                                            {
                                                query = "Select Quantidade from stock where NomeProduto = '" + C_MotherBoard.Text + "'";

                                                cmd = new MySqlCommand(query, PD.ola);

                                                ler = cmd.ExecuteReader();

                                                while (ler.Read())
                                                {
                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                }

                                                ler.Close();

                                                if (quantidade != 0)
                                                {
                                                    query = "Select Quantidade from stock where NomeProduto = '" + C_Processador.Text + "'";

                                                    cmd = new MySqlCommand(query, PD.ola);

                                                    ler = cmd.ExecuteReader();

                                                    while (ler.Read())
                                                    {
                                                        quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                    }

                                                    ler.Close();

                                                    if (quantidade != 0)
                                                    {
                                                        query = "Select Quantidade from stock where NomeProduto = '" + C_Grafica.Text + "'";

                                                        cmd = new MySqlCommand(query, PD.ola);

                                                        ler = cmd.ExecuteReader();

                                                        while (ler.Read())
                                                        {
                                                            quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                        }

                                                        ler.Close();

                                                        if (quantidade != 0)
                                                        {
                                                            query = "Select Quantidade from stock where NomeProduto = '" + C_RAM.Text + "'";

                                                            cmd = new MySqlCommand(query, PD.ola);

                                                            ler = cmd.ExecuteReader();

                                                            while (ler.Read())
                                                            {
                                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                            }

                                                            ler.Close();

                                                            if (quantidade != 0)
                                                            {
                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_Disco.Text + "'";

                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                ler = cmd.ExecuteReader();

                                                                while (ler.Read())
                                                                {
                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                }

                                                                ler.Close();

                                                                string preçoatual;
                                                                string preçoatual2;
                                                                double precoatual;
                                                                double precoatual2;

                                                                if (quantidade != 0)
                                                                {
                                                                    if (C_Disco2.Text != "")
                                                                    {
                                                                        query = "Select Quantidade from stock where NomeProduto = '" + C_Disco2.Text + "'";

                                                                        cmd = new MySqlCommand(query, PD.ola);

                                                                        ler = cmd.ExecuteReader();

                                                                        while (ler.Read())
                                                                        {
                                                                            quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                        }

                                                                        ler.Close();

                                                                        if (quantidade != 0)
                                                                        {
                                                                            //fazer codigo para retirar dinheiro e quantidade com o segundo disco

                                                                            preçoatual = label10.Text.ToString().Replace(".", ",");
                                                                            preçoatual = preçoatual.ToString().Replace("€", "");
                                                                            precoatual = Double.Parse(preçoatual);

                                                                            preçoatual2 = PreçoConta.Text.ToString().Replace(".", ",");
                                                                            preçoatual2 = preçoatual2.ToString().Replace("€", "");
                                                                            precoatual2 = Double.Parse(preçoatual2);

                                                                            if (precoatual2 >= precoatual)
                                                                            {
                                                                                double conta;
                                                                                string contastr;

                                                                                conta = precoatual2 - precoatual;

                                                                                contastr = conta.ToString().Replace(",", ".");

                                                                                string query;

                                                                                query = "Update cliente set Dinheiro = " + contastr + " where Username = '" + PD.Username + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                PreçoConta.Text = contastr + " €";
                                                                                label10.Text = "0 €";
                                                                                contatotal = 0;

                                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_Caixa.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                ler = cmd.ExecuteReader();

                                                                                while (ler.Read())
                                                                                {
                                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                                }

                                                                                ler.Close();

                                                                                quantidade = quantidade - 1;

                                                                                query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Caixa.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                ////

                                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_Fonte.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                ler = cmd.ExecuteReader();

                                                                                while (ler.Read())
                                                                                {
                                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                                }

                                                                                ler.Close();

                                                                                quantidade = quantidade - 1;

                                                                                query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Fonte.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                //////

                                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_MotherBoard.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                ler = cmd.ExecuteReader();

                                                                                while (ler.Read())
                                                                                {
                                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                                }

                                                                                ler.Close();

                                                                                quantidade = quantidade - 1;

                                                                                query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_MotherBoard.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                ///////

                                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_Processador.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                ler = cmd.ExecuteReader();

                                                                                while (ler.Read())
                                                                                {
                                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                                }

                                                                                ler.Close();

                                                                                quantidade = quantidade - 1;

                                                                                query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Processador.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                //////

                                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_Grafica.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                ler = cmd.ExecuteReader();

                                                                                while (ler.Read())
                                                                                {
                                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                                }

                                                                                ler.Close();

                                                                                quantidade = quantidade - 1;

                                                                                query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Grafica.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                //////

                                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_RAM.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                ler = cmd.ExecuteReader();

                                                                                while (ler.Read())
                                                                                {
                                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                                }

                                                                                ler.Close();

                                                                                quantidade = quantidade - 1;

                                                                                query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_RAM.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                //////

                                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_Disco.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                ler = cmd.ExecuteReader();

                                                                                while (ler.Read())
                                                                                {
                                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                                }

                                                                                ler.Close();

                                                                                quantidade = quantidade - 1;

                                                                                query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Disco.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                //////

                                                                                query = "Select Quantidade from stock where NomeProduto = '" + C_Disco2.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                ler = cmd.ExecuteReader();

                                                                                while (ler.Read())
                                                                                {
                                                                                    quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                                }

                                                                                ler.Close();

                                                                                quantidade = quantidade - 1;

                                                                                query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Disco2.Text + "'";

                                                                                cmd = new MySqlCommand(query, PD.ola);

                                                                                cmd.ExecuteNonQuery();

                                                                                //////

                                                                                MessageBox.Show("Compra Realizada com Sucesso!!");

                                                                                C_Caixa.SelectedItem = null;
                                                                                C_Fonte.SelectedItem = null;
                                                                                C_MotherBoard.SelectedItem = null;
                                                                                C_Processador.SelectedItem = null;
                                                                                C_Grafica.SelectedItem = null;
                                                                                C_RAM.SelectedItem = null;
                                                                                C_Disco.SelectedItem = null;
                                                                                C_Disco2.SelectedItem = null;
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("Saldo Insuficiente!!");
                                                                            }

                                                                            ////////////
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Segundo disco fora de stock!!");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        //fazer codigo para retirar dinheiro e quantidade sem o segundo disco

                                                                        preçoatual = label10.Text.ToString().Replace(".", ",");
                                                                        preçoatual = preçoatual.ToString().Replace("€", "");
                                                                        precoatual = Double.Parse(preçoatual);

                                                                        preçoatual2 = PreçoConta.Text.ToString().Replace(".", ",");
                                                                        preçoatual2 = preçoatual2.ToString().Replace("€", "");
                                                                        precoatual2 = Double.Parse(preçoatual2);

                                                                        if (precoatual2 >= precoatual)
                                                                        {
                                                                            double conta;
                                                                            string contastr;

                                                                            conta = precoatual2 - precoatual;

                                                                            contastr = conta.ToString().Replace(",", ".");

                                                                            string query;

                                                                            query = "Update cliente set Dinheiro = " + contastr + " where Username = '" + PD.Username + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            cmd.ExecuteNonQuery();

                                                                            PreçoConta.Text = contastr + " €";
                                                                            label10.Text = "0 €";
                                                                            contatotal = 0;

                                                                            query = "Select Quantidade from stock where NomeProduto = '" + C_Caixa.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            ler = cmd.ExecuteReader();

                                                                            while (ler.Read())
                                                                            {
                                                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                            }

                                                                            ler.Close();

                                                                            quantidade = quantidade - 1;

                                                                            query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Caixa.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            cmd.ExecuteNonQuery();

                                                                            ////

                                                                            query = "Select Quantidade from stock where NomeProduto = '" + C_Fonte.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            ler = cmd.ExecuteReader();

                                                                            while (ler.Read())
                                                                            {
                                                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                            }

                                                                            ler.Close();

                                                                            quantidade = quantidade - 1;

                                                                            query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Fonte.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            cmd.ExecuteNonQuery();

                                                                            //////

                                                                            query = "Select Quantidade from stock where NomeProduto = '" + C_MotherBoard.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            ler = cmd.ExecuteReader();

                                                                            while (ler.Read())
                                                                            {
                                                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                            }

                                                                            ler.Close();

                                                                            quantidade = quantidade - 1;

                                                                            query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_MotherBoard.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            cmd.ExecuteNonQuery();

                                                                            ///////

                                                                            query = "Select Quantidade from stock where NomeProduto = '" + C_Processador.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            ler = cmd.ExecuteReader();

                                                                            while (ler.Read())
                                                                            {
                                                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                            }

                                                                            ler.Close();

                                                                            quantidade = quantidade - 1;

                                                                            query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Processador.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            cmd.ExecuteNonQuery();

                                                                            //////

                                                                            query = "Select Quantidade from stock where NomeProduto = '" + C_Grafica.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            ler = cmd.ExecuteReader();

                                                                            while (ler.Read())
                                                                            {
                                                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                            }

                                                                            ler.Close();

                                                                            quantidade = quantidade - 1;

                                                                            query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Grafica.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            cmd.ExecuteNonQuery();

                                                                            //////

                                                                            query = "Select Quantidade from stock where NomeProduto = '" + C_RAM.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            ler = cmd.ExecuteReader();

                                                                            while (ler.Read())
                                                                            {
                                                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                            }

                                                                            ler.Close();

                                                                            quantidade = quantidade - 1;

                                                                            query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_RAM.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            cmd.ExecuteNonQuery();

                                                                            //////

                                                                            query = "Select Quantidade from stock where NomeProduto = '" + C_Disco.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            ler = cmd.ExecuteReader();

                                                                            while (ler.Read())
                                                                            {
                                                                                quantidade = ler.GetInt32(ler.GetOrdinal("Quantidade"));

                                                                            }

                                                                            ler.Close();

                                                                            quantidade = quantidade - 1;

                                                                            query = "update stock set Quantidade = " + quantidade + " where NomeProduto = '" + C_Disco.Text + "'";

                                                                            cmd = new MySqlCommand(query, PD.ola);

                                                                            cmd.ExecuteNonQuery();

                                                                            //////

                                                                            MessageBox.Show("Compra Realizada com Sucesso!!");

                                                                            C_Caixa.SelectedItem = null;
                                                                            C_Fonte.SelectedItem = null;
                                                                            C_MotherBoard.SelectedItem = null;
                                                                            C_Processador.SelectedItem = null;
                                                                            C_Grafica.SelectedItem = null;
                                                                            C_RAM.SelectedItem = null;
                                                                            C_Disco.SelectedItem = null;
                                                                            C_Disco2.SelectedItem = null;
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Saldo Insuficiente!!");
                                                                        }

                                                                        ////////////
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Primeiro disco fora de stock!!");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("RAM fora de stock!!");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Grafica fora de stock!!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Processador fora de stock!!");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("MotherBoard fora de stock!!");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Fonte fora de stock!!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Caixa fora de stock!!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Necessita de escolher um disco!!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Necessita de escolher uma RAM!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Necessita de escolher uma Grafica!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Necessita de escolher um Processador!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Necessita de escolher uma MotherBoard!!");
                    }
                }
                else
                {
                    MessageBox.Show("Necessita de escolher uma Fonte de alimentação!!");
                }
            }
            else
            {
                MessageBox.Show("Necessita de escolher uma Caixa!!");
            }
        }
    }
}
