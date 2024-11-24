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
        
        public void FormLab1_Load(object sender, EventArgs e)
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
            string data_source = "datasource=localhost; username=root; password=; database=projetomagalilabs";

            using (MySqlConnection connection = new MySqlConnection(data_source))
            {
                try
                {
                    connection.Open();

                    string tabela = "";
                    if (numero == 1) tabela = "tb_rlab1";
                    if (numero == 2) tabela = "tb_rlab2";
                    if (numero == 3) tabela = "tb_rlab3";
                    if (numero == 4) tabela = "tb_rauditorio";
                    if (numero == 5) tabela = "tb_rsalamaker";
                    if (numero == 6) tabela = "tb_rsiberia";
                    if (numero == 7) tabela = "tb_rlabquimica";

                    string horarioLimpo = mskHorario.Text.Trim();

                    string verificationSql = "SELECT COUNT(*) FROM " + tabela +
                                             " WHERE data_reserva = @data_reserva AND " +
                                             "((@horario BETWEEN horario AND horario_final) OR " +
                                             "(@horario_final BETWEEN horario AND horario_final) OR " +
                                             "(horario BETWEEN @horario AND @horario_final))";

                    using (MySqlCommand verification = new MySqlCommand(verificationSql, connection))
                    {
                        verification.Parameters.AddWithValue("@data_reserva", dtData.Value.ToString("yyyy-MM-dd"));
                        verification.Parameters.AddWithValue("@horario", mskHorario.Text.Trim());
                        verification.Parameters.AddWithValue("@horario_final", mskHorarioFinal.Text.Trim());

                        int count = Convert.ToInt32(verification.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Já existe uma reserva para esse intervalo de horário no laboratório selecionado!");
                            Limpar();
                            return;
                        }

                        else
                    {
                            string insertSql = "INSERT INTO " + tabela + "(nome_utilizador, evento, data_reserva, horario, nome_local, horario_final) " +
                    "VALUES (@nome_utilizador, @evento, @data_reserva, @horario, @nome_local, @horario_final)";

                            using (MySqlCommand command = new MySqlCommand(insertSql, connection))
                            {
                                command.Parameters.AddWithValue("@nome_utilizador", txtUtilizador.Text);
                                command.Parameters.AddWithValue("@evento", txtEvento.Text);
                                command.Parameters.AddWithValue("@data_reserva", dtData.Value.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@horario", mskHorario.Text.Trim());
                                command.Parameters.AddWithValue("@nome_local", nome_laboratorio);
                                command.Parameters.AddWithValue("@horario_final", mskHorarioFinal.Text.Trim());

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
            Limpar();
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

        public void Limpar()
        {
            txtEvento.Text = string.Empty;
            txtUtilizador.Text = string.Empty;
            mskHorario.Text = string.Empty;
            mskHorarioFinal.Text = string.Empty;
            dtData.Value = DateTime.Now;
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

        private void lblReserva_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
