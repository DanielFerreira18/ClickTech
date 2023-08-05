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
    public partial class Equipamentos : UserControl
    {
        //Propriedades do form
        public Equipamentos()
        {
            InitializeComponent();
        }


        //Variaveis para aceder a outras variaveis, definições e computadores
        Definições PD2 = new Definições();
        Computadores PD3 = new Computadores();


        //Metodos Mousehover
        private void Pic_Ratos_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Ratos.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Ratos.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Ratos.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Ratos.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_Ratos_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Ratos.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Ratos.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Ratos.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Ratos.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_Teclados_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Teclados.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Teclados.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Teclados.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Teclados.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_Teclados_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Teclados.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Teclados.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Teclados.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Teclados.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_Tapetes_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Tapetes.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Tapetes.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Tapetes.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Tapetes.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_Tapetes_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Tapetes.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Tapetes.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Tapetes.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Tapetes.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_Monitores_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Monitores.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Monitores.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Monitores.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Monitores.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_Monitores_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Monitores.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Monitores.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Monitores.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Monitores.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_HeadSetsFones_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_HeadSetsFones_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_PenCartoes_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_PenCartoes.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_PenCartoes.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_PenCartoes_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_PenCartoes.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_PenCartoes.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }


        //Metodos MouseLeave
        private void Pic_Ratos_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Ratos.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Ratos.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Ratos.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Ratos.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_Ratos_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;
            
            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Ratos.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Ratos.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Ratos.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Ratos.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_Teclados_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Teclados.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Teclados.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Teclados.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Teclados.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_Teclados_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Teclados.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Teclados.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Teclados.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Teclados.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_Tapetes_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Tapetes.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Tapetes.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Tapetes.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Tapetes.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_Tapetes_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Tapetes.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Tapetes.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Tapetes.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Tapetes.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_Monitores_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Monitores.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Monitores.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Monitores.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Monitores.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_Monitores_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Monitores.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Monitores.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Monitores.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Monitores.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_HeadSetsFones_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_HeadSetsFones.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_HeadSetsFones_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_HeadSetsFones.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_HeadSetsFones.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_PenCartoes_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_PenCartoes.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_PenCartoes_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a outras variaveis do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolha de cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_PenCartoes.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_PenCartoes.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        

        //Metodos Click
        private void L_Ratos_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Ratos1.Width = 815; //815
            PD.equipamento_Ratos1.Height = 575; //575

            PD.equipamento_Ratos1.Left = 242;
            PD.equipamento_Ratos1.Top = 66;

            PD.equipamento_Ratos1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 12;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_Ratos_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Ratos1.Width = 815; //815
            PD.equipamento_Ratos1.Height = 575; //575

            PD.equipamento_Ratos1.Left = 242;
            PD.equipamento_Ratos1.Top = 66;

            PD.equipamento_Ratos1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 12;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Teclados_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Teclados1.Width = 815; //815
            PD.equipamento_Teclados1.Height = 575; //575

            PD.equipamento_Teclados1.Left = 242;
            PD.equipamento_Teclados1.Top = 66;

            PD.equipamento_Teclados1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 13;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_Teclados_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Teclados1.Width = 815; //815
            PD.equipamento_Teclados1.Height = 575; //575

            PD.equipamento_Teclados1.Left = 242;
            PD.equipamento_Teclados1.Top = 66;

            PD.equipamento_Teclados1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 13;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Tapetes_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Tapetes1.Width = 815; //815
            PD.equipamento_Tapetes1.Height = 575; //575

            PD.equipamento_Tapetes1.Left = 242;
            PD.equipamento_Tapetes1.Top = 66;

            PD.equipamento_Tapetes1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 14;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_Tapetes_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Tapetes1.Width = 815; //815
            PD.equipamento_Tapetes1.Height = 575; //575

            PD.equipamento_Tapetes1.Left = 242;
            PD.equipamento_Tapetes1.Top = 66;

            PD.equipamento_Tapetes1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 14;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Monitores_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Monitores1.Width = 815; //815
            PD.equipamento_Monitores1.Height = 575; //575

            PD.equipamento_Monitores1.Left = 242;
            PD.equipamento_Monitores1.Top = 66;

            PD.equipamento_Monitores1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 15;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_Monitores_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Monitores1.Width = 815; //815
            PD.equipamento_Monitores1.Height = 575; //575

            PD.equipamento_Monitores1.Left = 242;
            PD.equipamento_Monitores1.Top = 66;

            PD.equipamento_Monitores1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 15;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_HeadSetsFones_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_HeadSetFones1.Width = 815; //815
            PD.equipamento_HeadSetFones1.Height = 575; //575

            PD.equipamento_HeadSetFones1.Left = 242;
            PD.equipamento_HeadSetFones1.Top = 66;

            PD.equipamento_HeadSetFones1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 16;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_HeadSetsFones_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_HeadSetFones1.Width = 815; //815
            PD.equipamento_HeadSetFones1.Height = 575; //575

            PD.equipamento_HeadSetFones1.Left = 242;
            PD.equipamento_HeadSetFones1.Top = 66;

            PD.equipamento_HeadSetFones1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 16;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Cadeiras_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Cadeiras1.Width = 815; //815
            PD.equipamento_Cadeiras1.Height = 575; //575

            PD.equipamento_Cadeiras1.Left = 242;
            PD.equipamento_Cadeiras1.Top = 66;

            PD.equipamento_Cadeiras1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 17;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_Cadeiras_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Cadeiras1.Width = 815; //815
            PD.equipamento_Cadeiras1.Height = 575; //575

            PD.equipamento_Cadeiras1.Left = 242;
            PD.equipamento_Cadeiras1.Top = 66;

            PD.equipamento_Cadeiras1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 17;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_Colunas_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Colunas1.Width = 815; //815
            PD.equipamento_Colunas1.Height = 575; //575

            PD.equipamento_Colunas1.Left = 242;
            PD.equipamento_Colunas1.Top = 66;

            PD.equipamento_Colunas1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 18;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_Colunas_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_Colunas1.Width = 815; //815
            PD.equipamento_Colunas1.Height = 575; //575

            PD.equipamento_Colunas1.Left = 242;
            PD.equipamento_Colunas1.Top = 66;

            PD.equipamento_Colunas1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 18;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void L_PenCartoes_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_PenCartoes1.Width = 815; //815
            PD.equipamento_PenCartoes1.Height = 575; //575

            PD.equipamento_PenCartoes1.Left = 242;
            PD.equipamento_PenCartoes1.Top = 66;

            PD.equipamento_PenCartoes1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 19;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void Pic_PenCartoes_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.equipamento_PenCartoes1.Width = 815; //815
            PD.equipamento_PenCartoes1.Height = 575; //575

            PD.equipamento_PenCartoes1.Left = 242;
            PD.equipamento_PenCartoes1.Top = 66;

            PD.equipamento_PenCartoes1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 19;

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

            PD.B_Equipamentos.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Equipamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
