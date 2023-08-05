namespace Projeto_de_Aptidão_Profissional
{
    partial class Computadores
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_ComputadoresRetroceder = new System.Windows.Forms.Label();
            this.L_Desktops = new System.Windows.Forms.Label();
            this.L_Laptops = new System.Windows.Forms.Label();
            this.L_ComputadoresAvançar = new System.Windows.Forms.Label();
            this.Pic_Laptops = new System.Windows.Forms.PictureBox();
            this.Pic_Desktops = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Laptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Desktops)).BeginInit();
            this.SuspendLayout();
            // 
            // L_ComputadoresRetroceder
            // 
            this.L_ComputadoresRetroceder.AutoSize = true;
            this.L_ComputadoresRetroceder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.L_ComputadoresRetroceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.L_ComputadoresRetroceder.Location = new System.Drawing.Point(50, 20);
            this.L_ComputadoresRetroceder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_ComputadoresRetroceder.Name = "L_ComputadoresRetroceder";
            this.L_ComputadoresRetroceder.Size = new System.Drawing.Size(99, 19);
            this.L_ComputadoresRetroceder.TabIndex = 24;
            this.L_ComputadoresRetroceder.Text = "Retroceder";
            // 
            // L_Desktops
            // 
            this.L_Desktops.AutoSize = true;
            this.L_Desktops.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.L_Desktops.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.L_Desktops.Location = new System.Drawing.Point(531, 431);
            this.L_Desktops.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Desktops.Name = "L_Desktops";
            this.L_Desktops.Size = new System.Drawing.Size(108, 26);
            this.L_Desktops.TabIndex = 27;
            this.L_Desktops.Text = "Desktops";
            this.L_Desktops.Click += new System.EventHandler(this.L_Fixos_Click);
            this.L_Desktops.MouseLeave += new System.EventHandler(this.L_Desktops_MouseLeave);
            this.L_Desktops.MouseHover += new System.EventHandler(this.L_Desktops_MouseHover);
            // 
            // L_Laptops
            // 
            this.L_Laptops.AutoSize = true;
            this.L_Laptops.BackColor = System.Drawing.Color.White;
            this.L_Laptops.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.L_Laptops.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.L_Laptops.Location = new System.Drawing.Point(179, 431);
            this.L_Laptops.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Laptops.Name = "L_Laptops";
            this.L_Laptops.Size = new System.Drawing.Size(96, 26);
            this.L_Laptops.TabIndex = 28;
            this.L_Laptops.Text = "Laptops";
            this.L_Laptops.Click += new System.EventHandler(this.L_Portateis_Click);
            this.L_Laptops.MouseLeave += new System.EventHandler(this.L_Laptops_MouseLeave);
            this.L_Laptops.MouseHover += new System.EventHandler(this.L_Laptops_MouseHover);
            // 
            // L_ComputadoresAvançar
            // 
            this.L_ComputadoresAvançar.AutoSize = true;
            this.L_ComputadoresAvançar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.L_ComputadoresAvançar.ForeColor = System.Drawing.Color.Gray;
            this.L_ComputadoresAvançar.Location = new System.Drawing.Point(694, 20);
            this.L_ComputadoresAvançar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_ComputadoresAvançar.Name = "L_ComputadoresAvançar";
            this.L_ComputadoresAvançar.Size = new System.Drawing.Size(72, 19);
            this.L_ComputadoresAvançar.TabIndex = 29;
            this.L_ComputadoresAvançar.Text = "Avançar";
            // 
            // Pic_Laptops
            // 
            this.Pic_Laptops.Location = new System.Drawing.Point(99, 152);
            this.Pic_Laptops.Margin = new System.Windows.Forms.Padding(2);
            this.Pic_Laptops.Name = "Pic_Laptops";
            this.Pic_Laptops.Size = new System.Drawing.Size(260, 236);
            this.Pic_Laptops.TabIndex = 26;
            this.Pic_Laptops.TabStop = false;
            this.Pic_Laptops.Click += new System.EventHandler(this.Pic_Portateis_Click);
            this.Pic_Laptops.MouseLeave += new System.EventHandler(this.Pic_Laptops_MouseLeave);
            this.Pic_Laptops.MouseHover += new System.EventHandler(this.Pic_Laptops_MouseHover);
            // 
            // Pic_Desktops
            // 
            this.Pic_Desktops.Location = new System.Drawing.Point(405, 103);
            this.Pic_Desktops.Margin = new System.Windows.Forms.Padding(2);
            this.Pic_Desktops.Name = "Pic_Desktops";
            this.Pic_Desktops.Size = new System.Drawing.Size(300, 300);
            this.Pic_Desktops.TabIndex = 25;
            this.Pic_Desktops.TabStop = false;
            this.Pic_Desktops.Click += new System.EventHandler(this.Pic_Fixos_Click);
            this.Pic_Desktops.MouseLeave += new System.EventHandler(this.Pic_Desktops_MouseLeave);
            this.Pic_Desktops.MouseHover += new System.EventHandler(this.Pic_Desktops_MouseHover);
            // 
            // Computadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.L_ComputadoresAvançar);
            this.Controls.Add(this.L_Laptops);
            this.Controls.Add(this.L_Desktops);
            this.Controls.Add(this.Pic_Laptops);
            this.Controls.Add(this.Pic_Desktops);
            this.Controls.Add(this.L_ComputadoresRetroceder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Computadores";
            this.Size = new System.Drawing.Size(816, 572);
            this.Load += new System.EventHandler(this.Computadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Laptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Desktops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Desktops;
        private System.Windows.Forms.PictureBox Pic_Laptops;
        public System.Windows.Forms.Label L_ComputadoresRetroceder;
        public System.Windows.Forms.Label L_Desktops;
        public System.Windows.Forms.Label L_Laptops;
        public System.Windows.Forms.Label L_ComputadoresAvançar;
    }
}
