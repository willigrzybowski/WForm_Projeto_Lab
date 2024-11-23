using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wform_reserva_lab_E_ESSE_AQUI_.pages;

namespace wform_reserva_lab_E_ESSE_AQUI_
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            FormReserva fReserva = new FormReserva();
            fReserva.Show();
            Console.WriteLine("FormReserva Aberto");
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio fRelatorio = new FormRelatorio();
            fRelatorio.Show();
            
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            FormUpdateDelete fUpdateDel = new FormUpdateDelete();
            fUpdateDel.Show();
        }
    }
}
