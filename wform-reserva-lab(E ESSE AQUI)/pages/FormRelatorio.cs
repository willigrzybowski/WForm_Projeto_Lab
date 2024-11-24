using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wform_reserva_lab_E_ESSE_AQUI_
{
    public partial class FormRelatorio : Form
    {
        string data_source = "datasource=localhost; username=root; password=; database=projetomagalilabs";

        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            cmbTabela.Items.Add("Todos");
            cmbTabela.Items.Add("Laboratório 1");
            cmbTabela.Items.Add("Laboratório 2");
            cmbTabela.Items.Add("Laboratório 3");
            cmbTabela.Items.Add("Sibéria");
            cmbTabela.Items.Add("Sala Maker");
            cmbTabela.Items.Add("Auditório");
            cmbTabela.Items.Add("Laboratório de Química");

            cmbTabela.SelectedIndex = 0;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(data_source))
            {
                string query = "";

                string dataFiltro = "";

                string nomeUsuarioFiltro = "";

                try
                {
                    connection.Open();

                    string mes = txtMes.Text.Trim();
                    string dia = txtDia.Text.Trim();
                    string ano = txtAno.Text.Trim();
                    string nomeUsuario = txtNomeUti.Text.Trim();

                    if (!string.IsNullOrEmpty(ano))
                    {
                        dataFiltro = $"YEAR(data_reserva) = '{ano}'";
                    }

                    if (!string.IsNullOrEmpty(mes))
                    {
                        if (dataFiltro != "") dataFiltro += " AND ";
                        dataFiltro += $"MONTH(data_reserva) = '{mes.PadLeft(2, '0')}'";
                    }

                    if (!string.IsNullOrEmpty(dia))
                    {
                        if (dataFiltro != "") dataFiltro += " AND ";
                        dataFiltro += $"DAY(data_reserva) = '{dia.PadLeft(2, '0')}'";
                    }

                    if (!string.IsNullOrEmpty(nomeUsuario))
                    {
                        if (dataFiltro != "") dataFiltro += " AND ";
                        nomeUsuarioFiltro = $"nome_utilizador LIKE '%{nomeUsuario}%'";
                        dataFiltro += nomeUsuarioFiltro;
                    }
                    // Caso o filtro de data esteja vazio (nenhum campo foi preenchido)
                    if (string.IsNullOrEmpty(dataFiltro))
                    {
                        dataFiltro = "1 = 1"; // Seleciona todos os registros
                    }

                    switch (cmbTabela.SelectedItem.ToString())
                    {
                        case "Todos":
                            query = @"
                            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final
                            FROM tb_rlab1 WHERE " + dataFiltro + @"
                            UNION ALL
                            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final
                            FROM tb_rlab2 WHERE " + dataFiltro + @"
                            UNION ALL
                            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final
                            FROM tb_rlab3 WHERE " + dataFiltro + @"
                            UNION ALL
                            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final
                            FROM tb_rSiberia WHERE " + dataFiltro + @"
                            UNION ALL
                            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final
                            FROM tb_rSalaMaker WHERE " + dataFiltro + @"
                            UNION ALL
                            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final
                            FROM tb_rAuditorio WHERE " + dataFiltro + @"
                            UNION ALL
                            SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final
                            FROM tb_rLabQuimica WHERE " + dataFiltro;

                            break;
                        case "Laboratório 1":
                            query = "SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final FROM tb_rlab1 WHERE " + dataFiltro;
                            break;
                        case "Laboratório 2":
                            query = "SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final FROM tb_rlab2 WHERE " + dataFiltro;
                            break;
                        case "Laboratório 3":
                            query = "SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final FROM tb_rlab3 WHERE " + dataFiltro;
                            break;
                        case "Sibéria":
                            query = "SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final FROM tb_rsiberia WHERE " + dataFiltro;
                            break;
                        case "Sala Maker":
                            query = "SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final FROM tb_rsalamaker WHERE " + dataFiltro;
                            break;
                        case "Auditório":
                            query = "SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final FROM tb_rauditorio WHERE " + dataFiltro;
                            break;
                        case "Laboratório de Química":
                            query = "SELECT id_reserva, nome_utilizador, evento, data_reserva, horario, nome_local, horario_final FROM tb_rlabquimica WHERE " + dataFiltro;
                            break;
                        default:
                            MessageBox.Show("Tabela não encontrada.");
                            return;
                    }

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dGrdView.DataSource = dataTable;

                    dGrdView.Columns["horario_final"].HeaderText = "Horário Final";
                    dGrdView.Columns["horario_final"].Width = 100;



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

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMes.Clear();
            txtDia.Clear();
            txtAno.Clear();
            txtNomeUti.Clear();
            dGrdView.DataSource = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGrdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
