using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private int numero;
        private string conn = "Server= ;Database= ;Trusted_Connection= ;";
        private string nome_laboratorio;
        public hrReserva(int numRecebido)
        {
            InitializeComponent();
            HideProgramarReserva();
            numero = numRecebido;

            
        }

        private void FormLab1_Load(object sender, EventArgs e)
        {
            if (numero == 1)
            {
                nome_laboratorio = "Laboratório 1";
            }
            if (numero == 2)
            {
                ;
                nome_laboratorio = "Laboratorio 2";
            }
            if (numero == 3)
            {
                nome_laboratorio = "Laboratorio 3";
            }
            if (numero == 4)
            {
                nome_laboratorio = "Auditório";
            }
            if (numero == 5)
            {
                nome_laboratorio = "Sala Maker";
            }
            if (numero == 6)
            {
                nome_laboratorio = "Sibéria";
            }
            if (numero == 7)
            {
                nome_laboratorio = "Laboratório de Química";
            }

            MessageBox.Show("Você está fazendo reserva para o(a): " + nome_laboratorio);
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

            try
            {
                using (SqlConnection connection = new SqlConnection(conn)) {
                    string sqlVerificator = "SELECT COUNT(*) FROM tb_reserva WHERE nome_reserva = @nome_reserva";
                    SqlCommand verification = new SqlCommand(sqlVerificator, connection);
                    verification.Parameters.AddWithValue("@nome_reserva", nome_laboratorio);

                    connection.Open();
                    int count = (int)verification.ExecuteScalar();
                    connection.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Já existe uma reserva com este nome!");
                        return;
                    }

                    string sql = "INSERT INTO tb_reserva(nome_reseva, nome_utilizador, evento, data_reserva, data_utilizacao, horario) VALUES (@nome_reseva, @nome_utilizador, @evento, @data_reserva, @data_utilizacao, @horario)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@nome_utilizador", txtUtilizador.Text);
                    command.Parameters.AddWithValue("@evento", txtEvento.Text);
                    command.Parameters.AddWithValue("@data_reserva", DateTime.Now.Date);
                    command.Parameters.AddWithValue("@data_utilizacao", dtData.Value);
                    command.Parameters.AddWithValue("@horario", mskHorario);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            } 
            catch (Exception ex) {
                MessageBox.Show("Erro ao inserir dados: " + ex.Message);
            }


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
            mskHorario.Text = string.Empty;
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
