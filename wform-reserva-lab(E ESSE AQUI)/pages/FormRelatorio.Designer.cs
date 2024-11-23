namespace wform_reserva_lab_E_ESSE_AQUI_
{
    partial class FormRelatorio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dGrdView = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNomeUti = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.cmbTabela = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(802, 85);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 56);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Relatório";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dGrdView
            // 
            this.dGrdView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(223)))), ((int)(((byte)(196)))));
            this.dGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdView.Location = new System.Drawing.Point(523, 156);
            this.dGrdView.Name = "dGrdView";
            this.dGrdView.Size = new System.Drawing.Size(790, 383);
            this.dGrdView.TabIndex = 2;
            this.dGrdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrdView_CellContentClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(84)))));
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(1103, 573);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(210, 52);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(84)))));
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(523, 573);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(210, 52);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNomeUti
            // 
            this.txtNomeUti.Location = new System.Drawing.Point(204, 215);
            this.txtNomeUti.Name = "txtNomeUti";
            this.txtNomeUti.Size = new System.Drawing.Size(245, 20);
            this.txtNomeUti.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(84)))));
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(822, 573);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(210, 52);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Gerar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(179, 417);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(270, 20);
            this.txtAno.TabIndex = 23;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(179, 368);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(270, 20);
            this.txtMes.TabIndex = 22;
            // 
            // cmbTabela
            // 
            this.cmbTabela.FormattingEnabled = true;
            this.cmbTabela.Location = new System.Drawing.Point(108, 262);
            this.cmbTabela.Name = "cmbTabela";
            this.cmbTabela.Size = new System.Drawing.Size(341, 21);
            this.cmbTabela.TabIndex = 5;
            this.cmbTabela.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(149, 127);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(206, 37);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "Informações";
            this.lblInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(48, 215);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(159, 19);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome do utilizador:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblLocal.Location = new System.Drawing.Point(49, 264);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(57, 19);
            this.lblLocal.TabIndex = 27;
            this.lblLocal.Text = "Local:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDia.Location = new System.Drawing.Point(49, 316);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(124, 19);
            this.lblDia.TabIndex = 28;
            this.lblDia.Text = "Dia da reserva:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            this.lblMes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMes.Location = new System.Drawing.Point(48, 368);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(130, 19);
            this.lblMes.TabIndex = 29;
            this.lblMes.Text = "Mês da reserva:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ano da reserva:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(179, 316);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(270, 20);
            this.txtDia.TabIndex = 21;
            this.txtDia.TextChanged += new System.EventHandler(this.txtDia_TextChanged);
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wform_reserva_lab_E_ESSE_AQUI_.Properties.Resources.Relatorio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtNomeUti);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbTabela);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dGrdView);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dGrdView;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNomeUti;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.ComboBox cmbTabela;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDia;
    }
}