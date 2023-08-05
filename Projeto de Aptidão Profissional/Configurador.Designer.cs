namespace Projeto_de_Aptidão_Profissional
{
    partial class Configurador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.C_Caixa = new System.Windows.Forms.ComboBox();
            this.C_Fonte = new System.Windows.Forms.ComboBox();
            this.C_MotherBoard = new System.Windows.Forms.ComboBox();
            this.C_Processador = new System.Windows.Forms.ComboBox();
            this.C_Grafica = new System.Windows.Forms.ComboBox();
            this.C_RAM = new System.Windows.Forms.ComboBox();
            this.C_Disco = new System.Windows.Forms.ComboBox();
            this.C_Disco2 = new System.Windows.Forms.ComboBox();
            this.B_Avançar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.L_ConfiguradorRetroceder = new System.Windows.Forms.Label();
            this.PreçoConta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // C_Caixa
            // 
            this.C_Caixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Caixa.FormattingEnabled = true;
            this.C_Caixa.Items.AddRange(new object[] {
            "Escolhe uma caixa...",
            "NOX - ATX HUMMER White",
            "NOX - ATX HUMMER Black",
            "NOX - Hummer TG RGB",
            "COOLER MASTER - MASTERBOX LITE 5 RGB",
            "COOLER MASTER - ATX MASTERBOX LITE 5 RGB",
            "COOLER MASTER - CX N300",
            "NOX - ATX PAX",
            "NOX - PAX"});
            this.C_Caixa.Location = new System.Drawing.Point(539, 175);
            this.C_Caixa.Margin = new System.Windows.Forms.Padding(2);
            this.C_Caixa.Name = "C_Caixa";
            this.C_Caixa.Size = new System.Drawing.Size(263, 21);
            this.C_Caixa.TabIndex = 26;
            this.C_Caixa.SelectedIndexChanged += new System.EventHandler(this.C_Caixa_SelectedIndexChanged);
            // 
            // C_Fonte
            // 
            this.C_Fonte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Fonte.FormattingEnabled = true;
            this.C_Fonte.Items.AddRange(new object[] {
            "NOX - Urano VX 750W",
            "NOX - Urano VX 500W",
            "NOX - NXS650 650W ",
            "NOX - Urano TX 850W",
            "CORSAIR - HX1000",
            "TOOQ - XGE-II 600W"});
            this.C_Fonte.Location = new System.Drawing.Point(539, 199);
            this.C_Fonte.Margin = new System.Windows.Forms.Padding(2);
            this.C_Fonte.Name = "C_Fonte";
            this.C_Fonte.Size = new System.Drawing.Size(263, 21);
            this.C_Fonte.TabIndex = 27;
            this.C_Fonte.SelectedIndexChanged += new System.EventHandler(this.C_Fonte_SelectedIndexChanged);
            // 
            // C_MotherBoard
            // 
            this.C_MotherBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_MotherBoard.FormattingEnabled = true;
            this.C_MotherBoard.Items.AddRange(new object[] {
            "ASUS - MB H110M-K",
            "ASUS - MAXIMUS VIII",
            "ASUS - MAXIMUS X",
            "ASROCK - H81M-DG4",
            "ASROCK - A320M",
            "ASROCK - J335B-ITX",
            "ASUS - H81M-K",
            "ASUS - PRIME B250M-K",
            "ASUS - H81M-P PLUS",
            "ASUS - H110M-D",
            "ASUS - EX-A320M-GAMING",
            "ASUS - STRIX B250G",
            "ASUS - TUF B360M-E",
            "ASUS - STRIX B250H"});
            this.C_MotherBoard.Location = new System.Drawing.Point(539, 223);
            this.C_MotherBoard.Margin = new System.Windows.Forms.Padding(2);
            this.C_MotherBoard.Name = "C_MotherBoard";
            this.C_MotherBoard.Size = new System.Drawing.Size(263, 21);
            this.C_MotherBoard.TabIndex = 28;
            this.C_MotherBoard.SelectedIndexChanged += new System.EventHandler(this.C_MotherBoard_SelectedIndexChanged);
            // 
            // C_Processador
            // 
            this.C_Processador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Processador.FormattingEnabled = true;
            this.C_Processador.Items.AddRange(new object[] {
            "INTEL - I3-7300",
            "INTEL - I7-8700",
            "AMD - FX-6300",
            "AMD - A10-7890K",
            "AMD - RYZEN 7 1700X",
            "AMD - RYZEN 7 1800X",
            "AMD - RYZEN 5 1500X",
            "INTEL - I3-8300",
            "INTEL - I5-7600",
            "INTEL - I5-8400",
            "INTEL - I5-8500",
            "INTEL - I7-6700",
            "INTEL - I7-6700K",
            "INTEL - I7-7700",
            "INTEL - I7-7700K"});
            this.C_Processador.Location = new System.Drawing.Point(539, 248);
            this.C_Processador.Margin = new System.Windows.Forms.Padding(2);
            this.C_Processador.Name = "C_Processador";
            this.C_Processador.Size = new System.Drawing.Size(263, 21);
            this.C_Processador.TabIndex = 29;
            this.C_Processador.SelectedIndexChanged += new System.EventHandler(this.C_Processador_SelectedIndexChanged);
            // 
            // C_Grafica
            // 
            this.C_Grafica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Grafica.FormattingEnabled = true;
            this.C_Grafica.Items.AddRange(new object[] {
            "AMD - FIREPRO W9100 32GB",
            "GIGABYTE - GTX 1050 TI OC 4GB",
            "AMD - FIREPRO W7100 8GB",
            "AMD - FIREPRO W4300 4GB",
            "ASUS - AMD RX560 4GB",
            "ASUS - AMD PH-RX550 4GB",
            "MSI - V330-011R GTX 1070 8GB",
            "GIGABYTE - GTX 1080 TI 11GB",
            "MSI - GTX 1060 GAMING X 3GB",
            "GIGABYTE - GTX 1050 2GB"});
            this.C_Grafica.Location = new System.Drawing.Point(539, 272);
            this.C_Grafica.Margin = new System.Windows.Forms.Padding(2);
            this.C_Grafica.Name = "C_Grafica";
            this.C_Grafica.Size = new System.Drawing.Size(263, 21);
            this.C_Grafica.TabIndex = 30;
            this.C_Grafica.SelectedIndexChanged += new System.EventHandler(this.C_Grafica_SelectedIndexChanged);
            // 
            // C_RAM
            // 
            this.C_RAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_RAM.FormattingEnabled = true;
            this.C_RAM.Items.AddRange(new object[] {
            "HYPERX - DDR4 8GB",
            "HYPERX - DDR4 16GB",
            "HYPERX - DDR4 4GB",
            "HYPERX - DDR4 32GBD",
            "KINGSTON - DDR4 8GB",
            "KINGSTON - DDR4 16GB",
            "KINGSTON - DDR4 4GB",
            "KINGSTON - DDR4 32GB"});
            this.C_RAM.Location = new System.Drawing.Point(539, 296);
            this.C_RAM.Margin = new System.Windows.Forms.Padding(2);
            this.C_RAM.Name = "C_RAM";
            this.C_RAM.Size = new System.Drawing.Size(263, 21);
            this.C_RAM.TabIndex = 31;
            this.C_RAM.SelectedIndexChanged += new System.EventHandler(this.C_RAM_SelectedIndexChanged);
            // 
            // C_Disco
            // 
            this.C_Disco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Disco.FormattingEnabled = true;
            this.C_Disco.Items.AddRange(new object[] {
            "SEAGATE - 3.5 6TB",
            "GOODRAM - SSD CX300 480GB",
            "SEAGATE - 2.5P 1TB",
            "SEAGATE - 3.5 3TB",
            "TOSHIBA - 3.5P 1TB",
            "SEAGATE - 3.5P 500GB",
            "GOODRAM - SSD CX300 240GB",
            "GOODRAM - SSD CX300 120GB",
            "KINGSTON - SSD 480GB",
            "KINGSTON - SSD 960GB"});
            this.C_Disco.Location = new System.Drawing.Point(539, 322);
            this.C_Disco.Margin = new System.Windows.Forms.Padding(2);
            this.C_Disco.Name = "C_Disco";
            this.C_Disco.Size = new System.Drawing.Size(263, 21);
            this.C_Disco.TabIndex = 33;
            this.C_Disco.SelectedIndexChanged += new System.EventHandler(this.C_Disco_SelectedIndexChanged);
            // 
            // C_Disco2
            // 
            this.C_Disco2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Disco2.FormattingEnabled = true;
            this.C_Disco2.Items.AddRange(new object[] {
            "SEAGATE - 3.5 6TB",
            "GOODRAM - SSD CX300 480GB",
            "SEAGATE - 2.5P 1TB",
            "SEAGATE - 3.5 3TB",
            "TOSHIBA - 3.5P 1TB",
            "SEAGATE - 3.5P 500GB",
            "GOODRAM - SSD CX300 240GB",
            "GOODRAM - SSD CX300 120GB",
            "KINGSTON - SSD 480GB",
            "KINGSTON - SSD 960GB"});
            this.C_Disco2.Location = new System.Drawing.Point(539, 347);
            this.C_Disco2.Margin = new System.Windows.Forms.Padding(2);
            this.C_Disco2.Name = "C_Disco2";
            this.C_Disco2.Size = new System.Drawing.Size(263, 21);
            this.C_Disco2.TabIndex = 34;
            this.C_Disco2.SelectedIndexChanged += new System.EventHandler(this.C_Disco2_SelectedIndexChanged);
            // 
            // B_Avançar
            // 
            this.B_Avançar.BackColor = System.Drawing.Color.LightGray;
            this.B_Avançar.FlatAppearance.BorderSize = 0;
            this.B_Avançar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Avançar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Avançar.Location = new System.Drawing.Point(656, 464);
            this.B_Avançar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Avançar.Name = "B_Avançar";
            this.B_Avançar.Size = new System.Drawing.Size(109, 42);
            this.B_Avançar.TabIndex = 39;
            this.B_Avançar.Text = "Comprar";
            this.B_Avançar.UseVisualStyleBackColor = false;
            this.B_Avançar.Click += new System.EventHandler(this.B_Avançar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "* Caixa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "* MotherBoard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "* Processador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "* Placa Grafica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "* Memoria RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "* Disco Rigido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 349);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Disco Rigido 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(424, 201);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 56;
            this.label13.Text = "* Fonte ";
            // 
            // L_ConfiguradorRetroceder
            // 
            this.L_ConfiguradorRetroceder.AutoSize = true;
            this.L_ConfiguradorRetroceder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.L_ConfiguradorRetroceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.L_ConfiguradorRetroceder.Location = new System.Drawing.Point(48, 32);
            this.L_ConfiguradorRetroceder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_ConfiguradorRetroceder.Name = "L_ConfiguradorRetroceder";
            this.L_ConfiguradorRetroceder.Size = new System.Drawing.Size(99, 19);
            this.L_ConfiguradorRetroceder.TabIndex = 58;
            this.L_ConfiguradorRetroceder.Text = "Retroceder";
            // 
            // PreçoConta
            // 
            this.PreçoConta.AutoSize = true;
            this.PreçoConta.Font = new System.Drawing.Font("Consolas", 14F);
            this.PreçoConta.Location = new System.Drawing.Point(542, 114);
            this.PreçoConta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreçoConta.Name = "PreçoConta";
            this.PreçoConta.Size = new System.Drawing.Size(100, 22);
            this.PreçoConta.TabIndex = 60;
            this.PreçoConta.Text = "3000.45 €";
            this.PreçoConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14F);
            this.label6.Location = new System.Drawing.Point(468, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 59;
            this.label6.Text = "Saldo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14F);
            this.label9.Location = new System.Drawing.Point(423, 426);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 22);
            this.label9.TabIndex = 61;
            this.label9.Text = "Preço Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 14F);
            this.label10.Location = new System.Drawing.Point(482, 473);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 22);
            this.label10.TabIndex = 62;
            this.label10.Text = "0 €";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(669, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 63;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configurador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PreçoConta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.L_ConfiguradorRetroceder);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Avançar);
            this.Controls.Add(this.C_Disco2);
            this.Controls.Add(this.C_Disco);
            this.Controls.Add(this.C_RAM);
            this.Controls.Add(this.C_Grafica);
            this.Controls.Add(this.C_Processador);
            this.Controls.Add(this.C_MotherBoard);
            this.Controls.Add(this.C_Fonte);
            this.Controls.Add(this.C_Caixa);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Configurador";
            this.Size = new System.Drawing.Size(816, 572);
            this.Load += new System.EventHandler(this.Configurador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox C_Caixa;
        private System.Windows.Forms.ComboBox C_Fonte;
        private System.Windows.Forms.ComboBox C_MotherBoard;
        private System.Windows.Forms.ComboBox C_Processador;
        private System.Windows.Forms.ComboBox C_Grafica;
        private System.Windows.Forms.ComboBox C_RAM;
        private System.Windows.Forms.ComboBox C_Disco;
        private System.Windows.Forms.ComboBox C_Disco2;
        private System.Windows.Forms.Button B_Avançar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label L_ConfiguradorRetroceder;
        public System.Windows.Forms.Label PreçoConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}
