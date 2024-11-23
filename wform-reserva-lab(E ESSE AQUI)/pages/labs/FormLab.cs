using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
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
        private string nome_laboratorio;
        public hrReserva(int numRecebido)
        {
            InitializeComponent();
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
                string data_source = "datasource=localhost; username=root; password=; database=reserva_laboratorio";

                using (MySqlConnection connection = new MySqlConnection(data_source))
                {
                    try
                    {
                        connection.Open();

                        string verificationSql = "SELECT COUNT(*) FROM tb_rlab1 WHERE nome_utilizador = @nome_utilizador AND horario = @horario AND data_reserva = @data_reserva";

                        using (MySqlCommand verification = new MySqlCommand(verificationSql, connection))
                        {
                            verification.Parameters.AddWithValue("@nome_utilizador", txtUtilizador.Text);
                            verification.Parameters.AddWithValue("@horario", mskHorario.Text);
                            verification.Parameters.AddWithValue("@data_reserva", dtData.Value.ToString("yyyy-MM-dd"));

                            int count = Convert.ToInt32(verification.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show("Já existe uma reserva com este nome e horário!");
                                return;
                            }

                            else 
                            {
                            string insertSql = "INSERT INTO tb_rlab1(nome_utilizador, evento, data_reserva, horario) VALUES (@nome_utilizador, @evento, @data_reserva, @horario)";

                            using (MySqlCommand command = new MySqlCommand(insertSql, connection))
                            {
                                command.Parameters.AddWithValue("@nome_utilizador", txtUtilizador.Text);
                                command.Parameters.AddWithValue("@evento", txtEvento.Text);
                                command.Parameters.AddWithValue("@data_reserva", dtData.Value.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@horario", mskHorario.Text);

                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Reserva feita com sucesso!");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    
                    }
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
            txtEvento.Text = string.Empty;
            txtUtilizador.Text = string.Empty;
            mskHorario.Text = string.Empty;
            dtData.Value = DateTime.Now;
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {

           ShowReserva();
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
