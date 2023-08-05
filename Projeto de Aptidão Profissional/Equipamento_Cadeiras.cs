using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Aptidão_Profissional
{
    public partial class Equipamento_Cadeiras : UserControl
    {
        public Equipamento_Cadeiras()
        {
            InitializeComponent();
        }


        //variavel
        private int Numero_Painel;


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

            if (CB_Alphagamer.Checked == true)
            {
                Numero_Painel = 1;

                P_EquipamentosAlphagamer.Width = 620;
                P_EquipamentosAlphagamer.Height = 430;

                P_EquipamentosAlphagamer.Location = new Point(193, 80);

                P_EquipamentosAlphagamer.Visible = true;

            }
            else if (CB_Txracer.Checked == true)
            {
                Numero_Painel = 2;

                P_EquipamentosTxracer.Width = 620;
                P_EquipamentosTxracer.Height = 430;

                P_EquipamentosTxracer.Location = new Point(193, 80);

                P_EquipamentosTxracer.Visible = true;

            }
            else if (CB_Akracing.Checked == true)
            {
                Numero_Painel = 3;

                P_EquipamentosAkracing.Width = 620;
                P_EquipamentosAkracing.Height = 430;

                P_EquipamentosAkracing.Location = new Point(193, 80);

                P_EquipamentosAkracing.Visible = true;

            }
            else if (CB_Drift.Checked == true)
            {
                Numero_Painel = 4;

                P_EquipamentosDrift.Width = 620;
                P_EquipamentosDrift.Height = 430;

                P_EquipamentosDrift.Location = new Point(193, 80);

                P_EquipamentosDrift.Visible = true;

            }
            else if (CB_Alphagamer.Checked == false && CB_Txracer.Checked == false && CB_Akracing.Checked == false && CB_Drift.Checked == false)
            {
                Numero_Painel = 1;

                P_EquipamentosAlphagamer.Width = 620;
                P_EquipamentosAlphagamer.Height = 430;

                P_EquipamentosAlphagamer.Location = new Point(193, 80);

                P_EquipamentosAlphagamer.Visible = true;

            }
        }

        private void L_Paineis2_Click(object sender, EventArgs e)
        {
            FecharPaineis();

            Numero_Painel = 2;

            P_EquipamentosTxracer.Width = 620;
            P_EquipamentosTxracer.Height = 430;

            P_EquipamentosTxracer.Location = new Point(193, 80);

            P_EquipamentosTxracer.Visible = true;
        }

        private void L_Paineis3_Click(object sender, EventArgs e)
        {
            FecharPaineis();

            Numero_Painel = 3;

            P_EquipamentosAkracing.Width = 620;
            P_EquipamentosAkracing.Height = 430;

            P_EquipamentosAkracing.Location = new Point(193, 80);

            P_EquipamentosAkracing.Visible = true;
        }

        private void L_Paineis4_Click(object sender, EventArgs e)
        {
            FecharPaineis();

            Numero_Painel = 4;

            P_EquipamentosDrift.Width = 620;
            P_EquipamentosDrift.Height = 430;

            P_EquipamentosDrift.Location = new Point(193, 80);

            P_EquipamentosDrift.Visible = true;
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

        private void L_Paineis4_MouseHover(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            switch (PD.VerMHD)
            {
                case 1:
                    L_Paineis4.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);
                    break;

                case 2:
                    L_Paineis4.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);
                    break;

                case 3:
                    L_Paineis4.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    L_Paineis4.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);
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

        private void L_Paineis4_MouseLeave(object sender, EventArgs e)
        {
            L_Paineis4.ForeColor = Color.Gray;
        }


        //Metodo CheckedChange
        private void CB_Alphagamer_ChackedChange(object sender, EventArgs e)
        {
            if (CB_Alphagamer.Checked == true)
            {
                CB_Txracer.Enabled = false;
                CB_Akracing.Enabled = false;
                CB_Drift.Enabled = false;

                L_Paineis2.Enabled = false;
                L_Paineis3.Enabled = false;
                L_Paineis4.Enabled = false;

                L_Paineis2.Visible = false;
                L_Paineis3.Visible = false;
                L_Paineis4.Visible = false;

                L_Paineis1.Location = new Point(470, 528);

                FecharPaineis();

                Numero_Painel = 1;

                P_EquipamentosAlphagamer.Width = 620;
                P_EquipamentosAlphagamer.Height = 430;

                P_EquipamentosAlphagamer.Location = new Point(193, 80);

                P_EquipamentosAlphagamer.Visible = true;

            }
            else
            {
                CB_Txracer.Enabled = true;
                CB_Akracing.Enabled = true;
                CB_Drift.Enabled = true;

                L_Paineis2.Enabled = true;
                L_Paineis3.Enabled = true;
                L_Paineis4.Enabled = true;

                L_Paineis2.Visible = true;
                L_Paineis3.Visible = true;
                L_Paineis4.Visible = true;

                L_Paineis1.Location = new Point(477, 528);

            }
        }

        private void CB_Txracer_CheckedChange(object sender, EventArgs e)
        {
            if (CB_Txracer.Checked == true)
            {
                CB_Alphagamer.Enabled = false;
                CB_Akracing.Enabled = false;
                CB_Drift.Enabled = false;

                L_Paineis2.Enabled = false;
                L_Paineis3.Enabled = false;
                L_Paineis4.Enabled = false;

                L_Paineis2.Visible = false;
                L_Paineis3.Visible = false;
                L_Paineis4.Visible = false;

                L_Paineis1.Location = new Point(470, 528);

                FecharPaineis();

                Numero_Painel = 2;

                P_EquipamentosTxracer.Width = 620;
                P_EquipamentosTxracer.Height = 430;

                P_EquipamentosTxracer.Location = new Point(193, 80);

                P_EquipamentosTxracer.Visible = true;

            }
            else
            {
                CB_Alphagamer.Enabled = true;
                CB_Akracing.Enabled = true;
                CB_Drift.Enabled = true;

                L_Paineis2.Enabled = true;
                L_Paineis3.Enabled = true;
                L_Paineis4.Enabled = true;

                L_Paineis2.Visible = true;
                L_Paineis3.Visible = true;
                L_Paineis4.Visible = true;

                L_Paineis1.Location = new Point(477, 528);
            }
        }

        private void CB_Akracing_CheckedChange(object sender, EventArgs e)
        {
            if (CB_Akracing.Checked == true)
            {
                CB_Txracer.Enabled = false;
                CB_Alphagamer.Enabled = false;
                CB_Drift.Enabled = false;

                L_Paineis2.Enabled = false;
                L_Paineis3.Enabled = false;
                L_Paineis4.Enabled = false;

                L_Paineis2.Visible = false;
                L_Paineis3.Visible = false;
                L_Paineis4.Visible = false;

                L_Paineis1.Location = new Point(470, 528);

                FecharPaineis();

                Numero_Painel = 3;

                P_EquipamentosAkracing.Width = 620;
                P_EquipamentosAkracing.Height = 430;

                P_EquipamentosAkracing.Location = new Point(193, 80);

                P_EquipamentosAkracing.Visible = true;

            }
            else
            {
                CB_Txracer.Enabled = true;
                CB_Alphagamer.Enabled = true;
                CB_Drift.Enabled = true;

                L_Paineis2.Enabled = true;
                L_Paineis3.Enabled = true;
                L_Paineis4.Enabled = true;

                L_Paineis2.Visible = true;
                L_Paineis3.Visible = true;
                L_Paineis4.Visible = true;

                L_Paineis1.Location = new Point(477, 528);
            }
        }

        private void CB_Drift_CheckedChange(object sender, EventArgs e)
        {
            if (CB_Drift.Checked == true)
            {
                CB_Txracer.Enabled = false;
                CB_Akracing.Enabled = false;
                CB_Alphagamer.Enabled = false;

                L_Paineis2.Enabled = false;
                L_Paineis3.Enabled = false;
                L_Paineis4.Enabled = false;

                L_Paineis2.Visible = false;
                L_Paineis3.Visible = false;
                L_Paineis4.Visible = false;

                L_Paineis1.Location = new Point(470, 528);

                FecharPaineis();

                Numero_Painel = 4;

                P_EquipamentosDrift.Width = 620;
                P_EquipamentosDrift.Height = 430;

                P_EquipamentosDrift.Location = new Point(193, 80);

                P_EquipamentosDrift.Visible = true;

            }
            else
            {
                CB_Txracer.Enabled = true;
                CB_Akracing.Enabled = true;
                CB_Alphagamer.Enabled = true;

                L_Paineis2.Enabled = true;
                L_Paineis3.Enabled = true;
                L_Paineis4.Enabled = true;

                L_Paineis2.Visible = true;
                L_Paineis3.Visible = true;
                L_Paineis4.Visible = true;

                L_Paineis1.Location = new Point(477, 528);

            }
        }


        //Metodo para fechar os paineis
        private void FecharPaineis()
        {
            switch (Numero_Painel)
            {
                case 1:
                    P_EquipamentosAlphagamer.Width = 20;
                    P_EquipamentosAlphagamer.Height = 20;

                    P_EquipamentosAlphagamer.Location = new Point(230, 20);

                    P_EquipamentosAlphagamer.Visible = false;
                    break;

                case 2:
                    P_EquipamentosTxracer.Width = 20;
                    P_EquipamentosTxracer.Height = 20;

                    P_EquipamentosTxracer.Location = new Point(230, 20);

                    P_EquipamentosTxracer.Visible = false;
                    break;

                case 3:
                    P_EquipamentosAkracing.Width = 20;
                    P_EquipamentosAkracing.Height = 20;

                    P_EquipamentosAkracing.Location = new Point(230, 20);

                    P_EquipamentosAkracing.Visible = false;
                    break;

                case 4:
                    P_EquipamentosDrift.Width = 20;
                    P_EquipamentosDrift.Height = 20;

                    P_EquipamentosDrift.Location = new Point(230, 20);

                    P_EquipamentosDrift.Visible = false;
                    break;
            }
        }
    }
}
