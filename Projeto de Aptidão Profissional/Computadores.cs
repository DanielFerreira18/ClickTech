using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_de_Aptidão_Profissional
{
    public partial class Computadores : UserControl
    {
        //propriedades do form
        public Computadores()
        {
            InitializeComponent();
        }

        //variavel de cores das labels
        public int[] CorLabels = new int[2] {225, 100};


        //metodos click
        private void L_Portateis_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.pC_Portateis1.Width = 815; //815
            PD.pC_Portateis1.Height = 575; //575

            PD.pC_Portateis1.Left = 242;
            PD.pC_Portateis1.Top = 66;

            PD.pC_Portateis1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 10;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Computadores.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Computadores.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Computadores.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Computadores.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Computadores.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_Portateis_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.pC_Portateis1.Width = 815; //815
            PD.pC_Portateis1.Height = 575; //575

            PD.pC_Portateis1.Left = 242;
            PD.pC_Portateis1.Top = 66;

            PD.pC_Portateis1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 10;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Computadores.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Computadores.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Computadores.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Computadores.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Computadores.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Fixos_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.pC_Fixos1.Width = 815; //815
            PD.pC_Fixos1.Height = 575; //575

            PD.pC_Fixos1.Left = 242;
            PD.pC_Fixos1.Top = 66;

            PD.pC_Fixos1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 11;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Computadores.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Computadores.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Computadores.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Computadores.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Computadores.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_Fixos_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.pC_Fixos1.Width = 815; //815
            PD.pC_Fixos1.Height = 575; //575

            PD.pC_Fixos1.Left = 242;
            PD.pC_Fixos1.Top = 66;

            PD.pC_Fixos1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 11;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Computadores.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Computadores.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Computadores.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Computadores.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Computadores.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }


        //metodos de mousehover
        private void L_Laptops_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout, definições
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Laptops.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Laptops.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Laptops.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Laptops.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void Pic_Laptops_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout, definições
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Laptops.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Laptops.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Laptops.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Laptops.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void L_Desktops_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout, definições
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Desktops.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Desktops.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Desktops.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Desktops.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void Pic_Desktops_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout, definições
            FLayout PD = (FLayout)this.Parent;
            Definições PD2 = new Definições();

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Desktops.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Desktops.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Desktops.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Desktops.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
    

        //metodos de mouseleave
        private void L_Laptops_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Laptops.ForeColor = Color.FromArgb(CorLabels[0], CorLabels[1], CorLabels[1]);

                    break;

                case 2:
                    L_Laptops.ForeColor = Color.FromArgb(CorLabels[1], CorLabels[1], CorLabels[0]);

                    break;

                case 3:
                    L_Laptops.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Laptops.ForeColor = Color.FromArgb(CorLabels[1], CorLabels[0], CorLabels[1]);

                    break;
            }
        }
        private void Pic_Laptops_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Laptops.ForeColor = Color.FromArgb(CorLabels[0], CorLabels[1], CorLabels[1]);

                    break;

                case 2:
                    L_Laptops.ForeColor = Color.FromArgb(CorLabels[1], CorLabels[1], CorLabels[0]);

                    break;

                case 3:
                    L_Laptops.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Laptops.ForeColor = Color.FromArgb(CorLabels[1], CorLabels[0], CorLabels[1]);

                    break;
            }
        }

        private void L_Desktops_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Desktops.ForeColor = Color.FromArgb(CorLabels[0], CorLabels[1], CorLabels[1]);

                    break;

                case 2:
                    L_Desktops.ForeColor = Color.FromArgb(CorLabels[1], CorLabels[1], CorLabels[0]);

                    break;

                case 3:
                    L_Desktops.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Desktops.ForeColor = Color.FromArgb(CorLabels[1], CorLabels[0], CorLabels[1]);

                    break;
            }
        }
        private void Pic_Desktops_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Desktops.ForeColor = Color.FromArgb(CorLabels[0], CorLabels[1], CorLabels[1]);

                    break;

                case 2:
                    L_Desktops.ForeColor = Color.FromArgb(CorLabels[1], CorLabels[1], CorLabels[0]);

                    break;

                case 3:
                    L_Desktops.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Desktops.ForeColor = Color.FromArgb(CorLabels[1], CorLabels[0], CorLabels[1]);

                    break;
            }
        }


        //metodo Load
        private void Computadores_Load(object sender, EventArgs e)
        {
            Pic_Laptops.Image = Properties.Resources.Pic_Portateis;
            Pic_Desktops.Image = Properties.Resources.Pic_Fixos;
        }
    }
}
