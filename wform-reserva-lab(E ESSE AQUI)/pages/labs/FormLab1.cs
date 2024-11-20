using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wform_reserva_lab_E_ESSE_AQUI_.pages.labs
{
    public partial class hrReserva : Form
    {
        public hrReserva()
        {
            InitializeComponent();
            HideProgramarReserva();
        }

        private void FormLab1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblSemana_Click(object sender, EventArgs e)
        {

        }

        private void lblPrograma_Click(object sender, EventArgs e)
        {

        }

        private void lblTurma_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorario1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUtilizadorProgramado.Text = string.Empty;
            txtEventoProgramada.Text = string.Empty;
            txtDiaSemana.Text = string.Empty;
            txtEvento.Text = string.Empty;
            txtUtilizador.Text = string.Empty;
            maskHorario.Text = string.Empty;
            mskHorarioReservado.Text = string.Empty;
            dtData.Value = DateTime.Now;
        }

        private void btnProgramarReserva_Click(object sender, EventArgs e)
        {
            ShowProgramarReserva();
            HideReserva();

        }

        private void btnReserva_Click(object sender, EventArgs e)
        {

           HideProgramarReserva();
           ShowReserva();
        }


        //Métodos:
        public void HideProgramarReserva()
        {
            lblUtilizadorProgramada.Hide();
            lblEventoProgramada.Hide();
            lblHorarioProgramada.Hide();
            lblSemana.Hide();

            txtUtilizadorProgramado.Hide();
            txtEventoProgramada.Hide();
            txtDiaSemana.Hide();
        }

        public void ShowProgramarReserva()
        {
            lblUtilizadorProgramada.Show();
            lblEventoProgramada.Show();
            lblHorarioProgramada.Show();
            lblSemana.Show();

            txtEventoProgramada.Show();
            txtUtilizadorProgramado.Show();
            txtDiaSemana.Show();
        }

        public void HideReserva()
        {
            lblUtilizador.Hide();
            lblEvento.Hide();
            lblHorario.Hide();
            lblData.Hide();

            txtEvento.Hide();
            txtUtilizador.Hide();

        }

        public void ShowReserva() {
            lblUtilizador.Show();
            lblEvento.Show();
            lblHorario.Show();
            lblData.Show();

            txtEvento.Show();
            txtUtilizador.Show();

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
