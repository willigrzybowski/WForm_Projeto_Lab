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
            this.btnReserva = new System.Windows.Forms.Button();
            this.lblReserva = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.mskHorario = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblUtilizador
            // 
            this.lblUtilizador.AutoSize = true;
            this.lblUtilizador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizador.Location = new System.Drawing.Point(211, 166);
            this.lblUtilizador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUtilizador.Name = "lblUtilizador";
            this.lblUtilizador.Size = new System.Drawing.Size(145, 18);
            this.lblUtilizador.TabIndex = 0;
            this.lblUtilizador.Text = "Nome do Utilizador:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(211, 273);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(64, 18);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "Horário:";
            this.lblHorario.Click += new System.EventHandler(this.lblHorario_Click);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(679, 218);
            this.lblEvento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(60, 18);
            this.lblEvento.TabIndex = 5;
            this.lblEvento.Text = "Evento:";
            this.lblEvento.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(211, 223);
            this.lblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(46, 18);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(747, 215);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(407, 26);
            this.txtEvento.TabIndex = 10;
            // 
            // txtUtilizador
            // 
            this.txtUtilizador.Location = new System.Drawing.Point(444, 158);
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.Size = new System.Drawing.Size(710, 26);
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
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReserva.Location = new System.Drawing.Point(342, 95);
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
            this.lblReserva.Location = new System.Drawing.Point(210, 99);
            this.lblReserva.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(86, 22);
            this.lblReserva.TabIndex = 30;
            this.lblReserva.Text = "Reserva\r\n";
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "yyyy/MM/dd";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(288, 217);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(350, 26);
            this.dtData.TabIndex = 33;
            this.dtData.Value = new System.DateTime(2024, 11, 23, 0, 0, 0, 0);
            this.dtData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // mskHorario
            // 
            this.mskHorario.Location = new System.Drawing.Point(310, 270);
            this.mskHorario.Mask = "00:00";
            this.mskHorario.Name = "mskHorario";
            this.mskHorario.Size = new System.Drawing.Size(46, 26);
            this.mskHorario.TabIndex = 35;
            // 
            // hrReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.mskHorario);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.btnReserva);
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
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.TextBox txtUtilizador;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.MaskedTextBox mskHorario;
    }
}