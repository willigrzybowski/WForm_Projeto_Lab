using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace wform_reserva_lab_E_ESSE_AQUI_.pages
{
    public partial class FormUpdateDelete : Form
    {
        string data_source = "datasource=localhost; username=root; password=; database=projetomagalilabs";

        public FormUpdateDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormUpdateDelete_Load(object sender, EventArgs e)
        {
            dGrdView.Columns.Add("id_reserva", "ID Reserva");
            dGrdView.Columns.Add("nome_utilizador", "Nome do Utilizador");
            dGrdView.Columns.Add("evento", "Evento");
            dGrdView.Columns.Add("data_reserva", "Data Reserva");
            dGrdView.Columns.Add("horario", "Horário");
            dGrdView.Columns.Add("nome_local", "Local");

        }

        private void txtNomeUti_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgnReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dGrdView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGrdView.SelectedRows[0];

                txtNomeUti.Text = selectedRow.Cells["nome_utilizador"].Value.ToString();
                txtEvento.Text = selectedRow.Cells["evento"].Value.ToString();
                dtData.Text = selectedRow.Cells["data_reserva"].Value.ToString();
                mskHorario.Text = selectedRow.Cells["horario"].Value.ToString();
                txtLocal.Text = selectedRow.Cells["nome_local"].Value.ToString();

            }
        }

        private void RefreshDataGridView()
        {
            dGrdView.Rows.Clear();

            using (MySqlConnection connection = new MySqlConnection(data_source))
            {
                connection.Open();
                string query = @"
            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rlab1
            UNION ALL
            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rlab2
            UNION ALL
            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rlab3
            UNION ALL
            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rsiberia
            UNION ALL
            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rsalamaker
            UNION ALL
            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rauditorio
            UNION ALL
            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rlabquimica";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dGrdView.Rows.Add(
                        reader["id_reserva"].ToString(),
                        reader["nome_utilizador"].ToString(),
                        reader["evento"].ToString(),
                        Convert.ToDateTime(reader["data_reserva"]).ToString("yyyy-MM-dd"),
                        reader["horario"].ToString(),
                        reader["nome_local"].ToString()
                    ) ;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeUti.Text))
            {
                MessageBox.Show("Por favor, insira um nome para buscar.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(data_source))
            {
                connection.Open();
                string query = @"
                    SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rlab1 WHERE nome_utilizador LIKE @nome_utilizador
                    UNION ALL
                    SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rlab2 WHERE nome_utilizador LIKE @nome_utilizador
                    UNION ALL
                    SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rlab3 WHERE nome_utilizador LIKE @nome_utilizador
                    UNION ALL
                    SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rsiberia WHERE nome_utilizador LIKE @nome_utilizador
                    UNION ALL
                    SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rsalamaker WHERE nome_utilizador LIKE @nome_utilizador
                    UNION ALL
                    SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rauditorio WHERE nome_utilizador LIKE @nome_utilizador
                    UNION ALL
                    SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local FROM tb_rlabquimica WHERE nome_utilizador LIKE @nome_utilizador";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nome_utilizador", "%" + txtNomeUti.Text + "%");
                dGrdView.Rows.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    dGrdView.Rows.Add(
                        reader["id_reserva"].ToString(),
                        reader["nome_utilizador"].ToString(),
                        reader["evento"].ToString(),
                        Convert.ToDateTime(reader["data_reserva"]).ToString("yyyy-MM-dd"),
                        reader["horario"].ToString(),
                        reader["nome_local"].ToString()
                        );
                }
            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dGrdView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva para atualizar.");
                return;
            }

            DialogResult result = MessageBox.Show("Você tem certeza que deseja atualizar esta reserva?", "Confirmar Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            DataGridViewRow selectedRow = dGrdView.SelectedRows[0];

            int idReserva = Convert.ToInt32(selectedRow.Cells["id_reserva"].Value);
            string tabela = GetTabelaByIdReserva(idReserva);

            if (tabela == null)
            {
                MessageBox.Show("Reserva não encontrada em nenhuma tabela.");
                return;
            }

            string horario = mskHorario.Text;

            if (horario.Length == 5)
            {

            }
            else
            {
                MessageBox.Show("Formato de horário inválido. Use HH:mm (exemplo: 14:30).");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(data_source))
            {
                connection.Open();
                string query = $"UPDATE `{tabela}` SET `nome_utilizador` = @nome_utilizador, `evento` = @evento, `data_reserva` = @data_reserva, `horario` = @horario, `nome_local` = @nome_local WHERE `id_reserva` = @id_reserva";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nome_utilizador", txtNomeUti.Text);
                cmd.Parameters.AddWithValue("@evento", txtEvento.Text);
                cmd.Parameters.AddWithValue("@data_reserva", dtData.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horario", mskHorario.Text);
                cmd.Parameters.AddWithValue("@id_reserva", idReserva);
                cmd.Parameters.AddWithValue("@nome_local", txtLocal.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva atualizada com sucesso!");

            }
            RefreshDataGridView();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dGrdView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva para excluir.");
                return;
            }

            DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir esta reserva?", "Confirmar Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            DataGridViewRow selectedRow = dGrdView.SelectedRows[0];
            int idReserva = Convert.ToInt32(selectedRow.Cells["id_reserva"].Value);
            string tabela = GetTabelaByIdReserva(idReserva);

            if (tabela == null)
            {
                MessageBox.Show("Reserva não encontrada em nenhuma tabela.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(data_source))
            {
                connection.Open();
                string query = $"DELETE FROM {tabela} WHERE id_reserva = @id_reserva";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_reserva", idReserva);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva deletada com sucesso!");

            }
        }

        private string GetTabelaByIdReserva(int idReserva)
        {
            string[] tabelas = new string[] { "tb_rlab1", "tb_rlab2", "tb_rlab3", "tb_rsiberia", "tb_rsalamaker", "tb_rauditorio", "tb_rlabquimica" };
            foreach (var tabela in tabelas)
            {
                if (ReservaExisteNaTabela(tabela, idReserva))
                {
                    return tabela;
                }
            }
            return null;
        }

        private bool ReservaExisteNaTabela(string tabela, int idReserva)
        {
            using (MySqlConnection connection = new MySqlConnection(data_source))
            {
                connection.Open();
                string query = $"SELECT COUNT(1) FROM {tabela} WHERE id_reserva = @id_reserva";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_reserva", idReserva);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeUti.Clear();
            txtEvento.Clear();
            dtData.ResetText();
            mskHorario.Clear();
            dGrdView.Rows.Clear();

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dGrdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

        }

        private void txtLocal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

