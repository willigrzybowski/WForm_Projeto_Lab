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
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.txtUtilizador = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtUtilizadorProgramado = new System.Windows.Forms.TextBox();
            this.txtEventoProgramada = new System.Windows.Forms.TextBox();
            this.lblEventoProgramada = new System.Windows.Forms.Label();
            this.lblHorarioProgramada = new System.Windows.Forms.Label();
            this.lblUtilizadorProgramada = new System.Windows.Forms.Label();
            this.btnProgramarReserva = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.lblReserva = new System.Windows.Forms.Label();
            this.txtDiaSemana = new System.Windows.Forms.ListBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.maskHorario = new System.Windows.Forms.MaskedTextBox();
            this.mskHorarioReservado = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblUtilizador
            // 
            this.lblUtilizador.AutoSize = true;
            this.lblUtilizador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizador.Location = new System.Drawing.Point(172, 89);
            this.lblUtilizador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUtilizador.Name = "lblUtilizador";
            this.lblUtilizador.Size = new System.Drawing.Size(223, 27);
            this.lblUtilizador.TabIndex = 0;
            this.lblUtilizador.Text = "Nome do Utilizador:";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.Location = new System.Drawing.Point(725, 376);
            this.lblSemana.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(180, 27);
            this.lblSemana.TabIndex = 2;
            this.lblSemana.Text = "Dia da semana:";
            this.lblSemana.Click += new System.EventHandler(this.lblSemana_Click);
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrograma.Location = new System.Drawing.Point(172, 264);
            this.lblPrograma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(275, 33);
            this.lblPrograma.TabIndex = 3;
            this.lblPrograma.Text = "Programar Reserva\r\n";
            this.lblPrograma.Click += new System.EventHandler(this.lblPrograma_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(172, 196);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(96, 27);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horário:";
            this.lblHorario.Click += new System.EventHandler(this.lblHorario_Click);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(607, 146);
            this.lblEvento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(93, 27);
            this.lblEvento.TabIndex = 5;
            this.lblEvento.Text = "Evento:";
            this.lblEvento.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(172, 146);
            this.lblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(69, 27);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(708, 138);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(407, 35);
            this.txtEvento.TabIndex = 10;
            // 
            // txtUtilizador
            // 
            this.txtUtilizador.Location = new System.Drawing.Point(405, 81);
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.Size = new System.Drawing.Size(710, 35);
            this.txtUtilizador.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(125, 552);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(244, 74);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(513, 552);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(244, 74);
            this.btnReservar.TabIndex = 16;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(910, 552);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(244, 74);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtUtilizadorProgramado
            // 
            this.txtUtilizadorProgramado.Location = new System.Drawing.Point(405, 318);
            this.txtUtilizadorProgramado.Name = "txtUtilizadorProgramado";
            this.txtUtilizadorProgramado.Size = new System.Drawing.Size(710, 35);
            this.txtUtilizadorProgramado.TabIndex = 27;
            this.txtUtilizadorProgramado.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtEventoProgramada
            // 
            this.txtEventoProgramada.Location = new System.Drawing.Point(280, 368);
            this.txtEventoProgramada.Name = "txtEventoProgramada";
            this.txtEventoProgramada.Size = new System.Drawing.Size(249, 35);
            this.txtEventoProgramada.TabIndex = 25;
            this.txtEventoProgramada.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblEventoProgramada
            // 
            this.lblEventoProgramada.AutoSize = true;
            this.lblEventoProgramada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventoProgramada.Location = new System.Drawing.Point(175, 376);
            this.lblEventoProgramada.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEventoProgramada.Name = "lblEventoProgramada";
            this.lblEventoProgramada.Size = new System.Drawing.Size(93, 27);
            this.lblEventoProgramada.TabIndex = 20;
            this.lblEventoProgramada.Text = "Evento:";
            this.lblEventoProgramada.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblHorarioProgramada
            // 
            this.lblHorarioProgramada.AutoSize = true;
            this.lblHorarioProgramada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioProgramada.Location = new System.Drawing.Point(537, 376);
            this.lblHorarioProgramada.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorarioProgramada.Name = "lblHorarioProgramada";
            this.lblHorarioProgramada.Size = new System.Drawing.Size(96, 27);
            this.lblHorarioProgramada.TabIndex = 19;
            this.lblHorarioProgramada.Text = "Horário:";
            this.lblHorarioProgramada.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblUtilizadorProgramada
            // 
            this.lblUtilizadorProgramada.AutoSize = true;
            this.lblUtilizadorProgramada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizadorProgramada.Location = new System.Drawing.Point(172, 326);
            this.lblUtilizadorProgramada.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUtilizadorProgramada.Name = "lblUtilizadorProgramada";
            this.lblUtilizadorProgramada.Size = new System.Drawing.Size(223, 27);
            this.lblUtilizadorProgramada.TabIndex = 18;
            this.lblUtilizadorProgramada.Text = "Nome do Utilizador:";
            this.lblUtilizadorProgramada.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnProgramarReserva
            // 
            this.btnProgramarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProgramarReserva.Location = new System.Drawing.Point(455, 260);
            this.btnProgramarReserva.Name = "btnProgramarReserva";
            this.btnProgramarReserva.Size = new System.Drawing.Size(51, 37);
            this.btnProgramarReserva.TabIndex = 29;
            this.btnProgramarReserva.Text = ">";
            this.btnProgramarReserva.UseVisualStyleBackColor = false;
            this.btnProgramarReserva.Click += new System.EventHandler(this.btnProgramarReserva_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReserva.Location = new System.Drawing.Point(303, 18);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(51, 37);
            this.btnReserva.TabIndex = 31;
            this.btnReserva.Text = ">";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.Location = new System.Drawing.Point(171, 22);
            this.lblReserva.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(124, 33);
            this.lblReserva.TabIndex = 30;
            this.lblReserva.Text = "Reserva\r\n";
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.FormattingEnabled = true;
            this.txtDiaSemana.ItemHeight = 27;
            this.txtDiaSemana.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado",
            "Domingo"});
            this.txtDiaSemana.Location = new System.Drawing.Point(913, 376);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(202, 85);
            this.txtDiaSemana.TabIndex = 32;
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "dd/MM/yyyy";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(249, 140);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(350, 35);
            this.dtData.TabIndex = 33;
            this.dtData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // maskHorario
            // 
            this.maskHorario.Location = new System.Drawing.Point(271, 193);
            this.maskHorario.Mask = "00:00";
            this.maskHorario.Name = "maskHorario";
            this.maskHorario.Size = new System.Drawing.Size(98, 35);
            this.maskHorario.TabIndex = 35;
            // 
            // mskHorarioReservado
            // 
            this.mskHorarioReservado.Location = new System.Drawing.Point(631, 368);
            this.mskHorarioReservado.Mask = "00:00";
            this.mskHorarioReservado.Name = "mskHorarioReservado";
            this.mskHorarioReservado.Size = new System.Drawing.Size(86, 35);
            this.mskHorarioReservado.TabIndex = 36;
            this.mskHorarioReservado.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // hrReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.mskHorarioReservado);
            this.Controls.Add(this.maskHorario);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.txtDiaSemana);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.btnProgramarReserva);
            this.Controls.Add(this.txtUtilizadorProgramado);
            this.Controls.Add(this.txtEventoProgramada);
            this.Controls.Add(this.lblEventoProgramada);
            this.Controls.Add(this.lblHorarioProgramada);
            this.Controls.Add(this.lblUtilizadorProgramada);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtUtilizador);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblPrograma);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.lblUtilizador);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "hrReserva";
            this.Text = "Lab1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLab1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilizador;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.TextBox txtUtilizador;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtUtilizadorProgramado;
        private System.Windows.Forms.TextBox txtEventoProgramada;
        private System.Windows.Forms.Label lblEventoProgramada;
        private System.Windows.Forms.Label lblHorarioProgramada;
        private System.Windows.Forms.Label lblUtilizadorProgramada;
        private System.Windows.Forms.Button btnProgramarReserva;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.ListBox txtDiaSemana;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.MaskedTextBox maskHorario;
        private System.Windows.Forms.MaskedTextBox mskHorarioReservado;
    }
}