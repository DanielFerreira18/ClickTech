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

namespace Projeto_de_Aptidão_Profissional
{
    public partial class Clientes : Form
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

        public Clientes()
        {
            InitializeComponent();

            //desenha os cantos
            Region = System.Drawing.Region.FromHrgn(Cantos(0, 0, Width, Height, 50, 50));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            panel2.Width = 20;
            panel2.Height = 20;

            panel2.Location = new Point(0, 80);

            panel3.Width = 20;
            panel3.Height = 20;

            panel3.Location = new Point(0, 80);

            panel4.Width = 20;
            panel4.Height = 20;

            panel4.Location = new Point(0, 80);

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.Silver;
            label3.ForeColor = Color.Silver;
            label4.ForeColor = Color.Silver;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
            label2.ForeColor = Color.White;

            panel2.Width = 520;
            panel2.Height = 485;

            panel2.Location = new Point(0, 107);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.Silver;

            panel2.Width = 20;
            panel2.Height = 20;

            panel2.Location = new Point(0, 80);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
            label2.ForeColor = Color.Silver;
            label3.ForeColor = Color.White;

            panel2.Width = 20;
            panel2.Height = 20;

            panel2.Location = new Point(0, 80);

            panel3.Width = 520;
            panel3.Height = 485;

            panel3.Location = new Point(0, 107);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.Silver;

            panel2.Width = 520;
            panel2.Height = 485;

            panel2.Location = new Point(0, 107);

            panel3.Width = 20;
            panel3.Height = 20;

            panel3.Location = new Point(0, 80);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
            label2.ForeColor = Color.Silver;
            label3.ForeColor = Color.Silver;
            label4.ForeColor = Color.White;

            panel2.Width = 20;
            panel2.Height = 20;

            panel2.Location = new Point(0, 80);

            panel3.Width = 20;
            panel3.Height = 20;

            panel3.Location = new Point(0, 80);

            panel4.Width = 520;
            panel4.Height = 485;

            panel4.Location = new Point(0, 107);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //inicia o form Flyout
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
            label2.ForeColor = Color.Silver;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.Silver;

            panel2.Width = 20;
            panel2.Height = 20;

            panel2.Location = new Point(0, 80);

            panel3.Width = 520;
            panel3.Height = 485;

            panel3.Location = new Point(0, 107);

            panel4.Width = 20;
            panel4.Height = 20;

            panel4.Location = new Point(0, 80);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox6.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
}
