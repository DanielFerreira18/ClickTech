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
    public partial class Componentes : UserControl
    {
        //propriedades do form
        public Componentes()
        {
            InitializeComponent();
        }


        //Variaveis para aceder a outras variaveis, definições e computadores
        Definições PD2 = new Definições();
        Computadores PD3 = new Computadores();


        //Metodos Mousehover
        private void Pic_MotherBoard_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_MotherBoard.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_MotherBoard.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_MotherBoard_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_MotherBoard.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_MotherBoard.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_Processador_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Processador.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Processador.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Processador.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Processador.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_Processador_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Processador.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Processador.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Processador.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Processador.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_PlacaGrafica_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_PlacaGrafica_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_DiscoRigido_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_DiscoRigido.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_DiscoRigido.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_DiscoRigido_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_DiscoRigido.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_DiscoRigido.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }

        private void Pic_MemoriaRAM_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_MemoriaRAM_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }


        private void Pic_Fonte_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Fonte.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Fonte.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Fonte.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Fonte.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_Fonte_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Fonte.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Fonte.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Fonte.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Fonte.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        

        private void Pic_Caixa_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Caixa.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Caixa.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Caixa.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Caixa.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }
        private void L_Caixa_MouseHover(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Caixa.ForeColor = Color.FromArgb(PD2.Cor[0, 0], 0, 0);

                    break;

                case 2:
                    L_Caixa.ForeColor = Color.FromArgb(0, 0, PD2.Cor[0, 0]);

                    break;

                case 3:
                    L_Caixa.ForeColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);

                    break;

                case 4:
                    L_Caixa.ForeColor = Color.FromArgb(0, PD2.Cor[0, 0], 0);

                    break;
            }
        }


        //Metodos MouseLeave
        private void Pic_MotherBoard_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_MotherBoard.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_MotherBoard_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_MotherBoard.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_MotherBoard.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_Processador_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Processador.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Processador.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Processador.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Processador.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_Processador_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Processador.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Processador.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Processador.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Processador.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_PlacaGrafica_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_PlacaGrafica.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_PlacaGrafica_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_PlacaGrafica.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_PlacaGrafica.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_DiscoRigido_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_DiscoRigido.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_DiscoRigido_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_DiscoRigido.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_DiscoRigido.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_MemoriaRAM_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_MemoriaRAM.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_MemoriaRAM_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_MemoriaRAM.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_MemoriaRAM.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_Fonte_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Fonte.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Fonte.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Fonte.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Fonte.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_Fonte_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Fonte.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Fonte.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Fonte.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Fonte.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }

        private void Pic_Caixa_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Caixa.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Caixa.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Caixa.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Caixa.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }
        private void L_Caixa_MouseLeave(object sender, EventArgs e)
        {
            //Variaveis para aceder a objetos do form Flayout
            FLayout PD = (FLayout)this.Parent;

            //switch para escolher a cor
            switch (PD.VerMHD)
            {
                case 1:
                    L_Caixa.ForeColor = Color.FromArgb(PD3.CorLabels[0], PD3.CorLabels[1], PD3.CorLabels[1]);

                    break;

                case 2:
                    L_Caixa.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[1], PD3.CorLabels[0]);

                    break;

                case 3:
                    L_Caixa.ForeColor = Color.Gray;

                    break;

                case 4:
                    L_Caixa.ForeColor = Color.FromArgb(PD3.CorLabels[1], PD3.CorLabels[0], PD3.CorLabels[1]);

                    break;
            }
        }


        //Metodos Click
        private void Pic_MotherBoard_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_MotherBoard1.Width = 815; //815
            PD.componente_MotherBoard1.Height = 575; //575

            PD.componente_MotherBoard1.Left = 242;
            PD.componente_MotherBoard1.Top = 66;

            PD.componente_MotherBoard1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 22;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_MotherBoard_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_MotherBoard1.Width = 815; //815
            PD.componente_MotherBoard1.Height = 575; //575

            PD.componente_MotherBoard1.Left = 242;
            PD.componente_MotherBoard1.Top = 66;

            PD.componente_MotherBoard1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 22;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_Processador_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_Processador1.Width = 815; //815
            PD.componente_Processador1.Height = 575; //575

            PD.componente_Processador1.Left = 242;
            PD.componente_Processador1.Top = 66;

            PD.componente_Processador1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 23;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_Processador_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_Processador1.Width = 815; //815
            PD.componente_Processador1.Height = 575; //575

            PD.componente_Processador1.Left = 242;
            PD.componente_Processador1.Top = 66;

            PD.componente_Processador1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 23;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_PlacaGrafica_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_PlacaGrafica1.Width = 815; //815
            PD.componente_PlacaGrafica1.Height = 575; //575

            PD.componente_PlacaGrafica1.Left = 242;
            PD.componente_PlacaGrafica1.Top = 66;

            PD.componente_PlacaGrafica1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 24;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_PlacaGrafica_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_PlacaGrafica1.Width = 815; //815
            PD.componente_PlacaGrafica1.Height = 575; //575

            PD.componente_PlacaGrafica1.Left = 242;
            PD.componente_PlacaGrafica1.Top = 66;

            PD.componente_PlacaGrafica1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 24;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_DiscoRigido_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_DiscoRigido1.Width = 815; //815
            PD.componente_DiscoRigido1.Height = 575; //575

            PD.componente_DiscoRigido1.Left = 242;
            PD.componente_DiscoRigido1.Top = 66;

            PD.componente_DiscoRigido1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 25;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_DiscoRigido_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_DiscoRigido1.Width = 815; //815
            PD.componente_DiscoRigido1.Height = 575; //575

            PD.componente_DiscoRigido1.Left = 242;
            PD.componente_DiscoRigido1.Top = 66;

            PD.componente_DiscoRigido1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 25;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_MemoriaRAM_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_RAM1.Width = 815; //815
            PD.componente_RAM1.Height = 575; //575

            PD.componente_RAM1.Left = 242;
            PD.componente_RAM1.Top = 66;

            PD.componente_RAM1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 26;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_MemoriaRAM_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_RAM1.Width = 815; //815
            PD.componente_RAM1.Height = 575; //575

            PD.componente_RAM1.Left = 242;
            PD.componente_RAM1.Top = 66;

            PD.componente_RAM1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 26;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_PlacaRede_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_PlacaRede1.Width = 815; //815
            PD.componente_PlacaRede1.Height = 575; //575

            PD.componente_PlacaRede1.Left = 242;
            PD.componente_PlacaRede1.Top = 66;

            PD.componente_PlacaRede1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 27;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_PlacaRede_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_PlacaRede1.Width = 815; //815
            PD.componente_PlacaRede1.Height = 575; //575

            PD.componente_PlacaRede1.Left = 242;
            PD.componente_PlacaRede1.Top = 66;

            PD.componente_PlacaRede1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 27;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_LeitorCD_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_LeitorCD1.Width = 815; //815
            PD.componente_LeitorCD1.Height = 575; //575

            PD.componente_LeitorCD1.Left = 242;
            PD.componente_LeitorCD1.Top = 66;

            PD.componente_LeitorCD1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 28;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_LeitorCD_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_LeitorCD1.Width = 815; //815
            PD.componente_LeitorCD1.Height = 575; //575

            PD.componente_LeitorCD1.Left = 242;
            PD.componente_LeitorCD1.Top = 66;

            PD.componente_LeitorCD1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 28;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_Fonte_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_Fonte1.Width = 815; //815
            PD.componente_Fonte1.Height = 575; //575

            PD.componente_Fonte1.Left = 242;
            PD.componente_Fonte1.Top = 66;

            PD.componente_Fonte1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 29;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_Fonte_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_Fonte1.Width = 815; //815
            PD.componente_Fonte1.Height = 575; //575

            PD.componente_Fonte1.Left = 242;
            PD.componente_Fonte1.Top = 66;

            PD.componente_Fonte1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 29;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_Cooler_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_Cooler1.Width = 815; //815
            PD.componente_Cooler1.Height = 575; //575

            PD.componente_Cooler1.Left = 242;
            PD.componente_Cooler1.Top = 66;

            PD.componente_Cooler1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 30;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_Cooler_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_Cooler1.Width = 815; //815
            PD.componente_Cooler1.Height = 575; //575

            PD.componente_Cooler1.Left = 242;
            PD.componente_Cooler1.Top = 66;

            PD.componente_Cooler1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 30;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }

        private void Pic_Caixa_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_Caixa1.Width = 815; //815
            PD.componente_Caixa1.Height = 575; //575

            PD.componente_Caixa1.Left = 242;
            PD.componente_Caixa1.Top = 66;

            PD.componente_Caixa1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 31;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
        private void L_Caixa_Click(object sender, EventArgs e)
        {
            FLayout PD = (FLayout)this.Parent;

            //retira a cor permanente do botão
            PD.RetirarCor();

            //Fecha todas as abas que estiverem abertas
            PD.FecharTudo();

            //abre a aba dos computadores para venda
            PD.componente_Caixa1.Width = 815; //815
            PD.componente_Caixa1.Height = 575; //575

            PD.componente_Caixa1.Left = 242;
            PD.componente_Caixa1.Top = 66;

            PD.componente_Caixa1.Visible = true;

            //altera a cor das labels contidas no form
            PD.LabelCor();

            //altera as variaveis para retroceder
            PD.FormularioAnterior = PD.FormularioAtual;

            //altera a variavel
            PD.FormularioAtual = 31;

            switch (PD.VerMHD)
            {
                case 1:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[0, 2], 0, 0);
                    break;

                case 2:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, 0, PD2.Cor[0, 2]);
                    break;

                case 3:
                    PD.B_Componentes.BackColor = Color.FromArgb(PD2.Cor[1, 2], PD2.Cor[1, 2], PD2.Cor[1, 2]);
                    break;

                case 4:
                    PD.B_Componentes.BackColor = Color.FromArgb(0, PD2.Cor[0, 2], 0);
                    break;

            }

            PD.B_Componentes.MouseLeave += new EventHandler(PD.ControlAberto_Cor);
        }
    }
}
