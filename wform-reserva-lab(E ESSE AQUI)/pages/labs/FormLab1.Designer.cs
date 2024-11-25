namespace wform_reserva_lab_E_ESSE_AQUI_.pages.labs
{
    partial class hrReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUtilizador = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.txtUtilizador = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblReserva = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.mskHorario = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mskHorarioFinal = new System.Windows.Forms.MaskedTextBox();
            this.lblHorarioFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUtilizador
            // 
            this.lblUtilizador.AutoSize = true;
            this.lblUtilizador.BackColor = System.Drawing.Color.Transparent;
            this.lblUtilizador.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizador.Location = new System.Drawing.Point(98, 266);
            this.lblUtilizador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUtilizador.Name = "lblUtilizador";
            this.lblUtilizador.Size = new System.Drawing.Size(191, 22);
            this.lblUtilizador.TabIndex = 0;
            this.lblUtilizador.Text = "Nome do Utilizador:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHorario.Location = new System.Drawing.Point(98, 413);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(86, 22);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horário:";
            this.lblHorario.Click += new System.EventHandler(this.lblHorario_Click);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblEvento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEvento.Location = new System.Drawing.Point(573, 340);
            this.lblEvento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(82, 22);
            this.lblEvento.TabIndex = 5;
            this.lblEvento.Text = "Evento:";
            this.lblEvento.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblData.Location = new System.Drawing.Point(99, 339);
            this.lblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(59, 22);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(663, 336);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(531, 26);
            this.txtEvento.TabIndex = 10;
            // 
            // txtUtilizador
            // 
            this.txtUtilizador.Location = new System.Drawing.Point(297, 262);
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.Size = new System.Drawing.Size(897, 26);
            this.txtUtilizador.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(84)))));
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(356, 549);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(164, 53);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(84)))));
            this.btnReservar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(577, 549);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(164, 53);
            this.btnReservar.TabIndex = 16;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(84)))));
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(800, 549);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(164, 53);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblReserva.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.Location = new System.Drawing.Point(163, 166);
            this.lblReserva.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(141, 37);
            this.lblReserva.TabIndex = 30;
            this.lblReserva.Text = "Reserva\r\n";
            this.lblReserva.Click += new System.EventHandler(this.lblReserva_Click);
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "yyyy/MM/dd";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(166, 336);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(373, 26);
            this.dtData.TabIndex = 33;
            this.dtData.Value = new System.DateTime(2024, 11, 23, 0, 0, 0, 0);
            this.dtData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // mskHorario
            // 
            this.mskHorario.Location = new System.Drawing.Point(192, 409);
            this.mskHorario.Mask = "00:00";
            this.mskHorario.Name = "mskHorario";
            this.mskHorario.Size = new System.Drawing.Size(347, 26);
            this.mskHorario.TabIndex = 35;
            this.mskHorario.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::wform_reserva_lab_E_ESSE_AQUI_.Properties.Resources.seta2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(102, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 44);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // mskHorarioFinal
            // 
            this.mskHorarioFinal.Location = new System.Drawing.Point(986, 413);
            this.mskHorarioFinal.Mask = "00:00";
            this.mskHorarioFinal.Name = "mskHorarioFinal";
            this.mskHorarioFinal.Size = new System.Drawing.Size(208, 26);
            this.mskHorarioFinal.TabIndex = 39;
            this.mskHorarioFinal.ValidatingType = typeof(System.DateTime);
            this.mskHorarioFinal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblHorarioFinal
            // 
            this.lblHorarioFinal.AutoSize = true;
            this.lblHorarioFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioFinal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHorarioFinal.Location = new System.Drawing.Point(842, 417);
            this.lblHorarioFinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorarioFinal.Name = "lblHorarioFinal";
            this.lblHorarioFinal.Size = new System.Drawing.Size(136, 22);
            this.lblHorarioFinal.TabIndex = 38;
            this.lblHorarioFinal.Text = "Horário Final:";
            this.lblHorarioFinal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // hrReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wform_reserva_lab_E_ESSE_AQUI_.Properties.Resources.FundoFazerReserva3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.mskHorarioFinal);
            this.Controls.Add(this.lblHorarioFinal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mskHorario);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtUtilizador);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblUtilizador);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "hrReserva";
            this.Text = "Lab1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLab1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilizador;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.TextBox txtUtilizador;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.MaskedTextBox mskHorario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox FundoVerde;
        private System.Windows.Forms.MaskedTextBox mskHorarioFinal;
        private System.Windows.Forms.Label lblHorarioFinal;
    }
}