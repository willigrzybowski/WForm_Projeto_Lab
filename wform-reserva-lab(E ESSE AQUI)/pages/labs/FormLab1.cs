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

                    // Determina a tabela a ser usada com base no laboratório selecionado
                    string tabela = "";
                    if (numero == 1) tabela = "tb_rlab1";
                    if (numero == 2) tabela = "tb_rlab2";
                    if (numero == 3) tabela = "tb_rlab3";
                    if (numero == 4) tabela = "tb_rauditorio";
                    if (numero == 5) tabela = "tb_rsala_maker";
                    if (numero == 6) tabela = "tb_rsiberia";
                    if (numero == 7) tabela = "tb_rlab_quimica";

                    // Limpa qualquer espaço extra no horário
                    string horarioLimpo = mskHorario.Text.Trim();

                    // Verificação de conflitos na reserva
                    string verificationSql = "SELECT COUNT(*) FROM " + tabela + " WHERE horario = @horario AND data_reserva = @data_reserva";

                    using (MySqlCommand verification = new MySqlCommand(verificationSql, connection))
                    {
                        verification.Parameters.AddWithValue("@horario", horarioLimpo); // Usando o horário limpo
                        verification.Parameters.AddWithValue("@data_reserva", dtData.Value.ToString("yyyy-MM-dd")); // Convertendo data para o formato correto

                        // Depuração para verificar os valores passados
                        MessageBox.Show($"Verificando: Horário = {horarioLimpo}, Data = {dtData.Value.ToString("yyyy-MM-dd")}");

                        int count = Convert.ToInt32(verification.ExecuteScalar()); // Executa a contagem de reservas existentes

                        // Se já houver uma reserva para o mesmo horário e data, mostra a mensagem de erro
                        if (count > 0)
                        {
                            MessageBox.Show("Já existe uma reserva para esse horário e data no laboratório selecionado!");
                            return;
                        }
                        else
                        {
                            // Caso não haja conflito, insere a nova reserva
                            string insertSql = "INSERT INTO " + tabela + "(nome_utilizador, evento, data_reserva, horario) VALUES (@nome_utilizador, @evento, @data_reserva, @horario)";

                            using (MySqlCommand command = new MySqlCommand(insertSql, connection))
                            {
                                command.Parameters.AddWithValue("@nome_utilizador", txtUtilizador.Text);
                                command.Parameters.AddWithValue("@evento", txtEvento.Text);
                                command.Parameters.AddWithValue("@data_reserva", dtData.Value.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@horario", horarioLimpo);

                                command.ExecuteNonQuery(); // Executa a inserção no banco de dados
                            }

                            // Mostra a mensagem de sucesso
                            MessageBox.Show("Reserva feita com sucesso!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Exibe erros que possam ocorrer durante a execução do código
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    // Fecha a conexão com o banco de dados caso ela esteja aberta
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

        private void lblReserva_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
