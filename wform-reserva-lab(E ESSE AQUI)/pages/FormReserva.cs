using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wform_reserva_lab_E_ESSE_AQUI_.pages.labs;

namespace wform_reserva_lab_E_ESSE_AQUI_
{
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }

        private void btnLab1_Click(object sender, EventArgs e)
        {
            hrReserva fLab = new hrReserva(1);
            fLab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hrReserva fLab = new hrReserva(4);
            fLab.Show();
        }

        private void FormReserva_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            hrReserva fLab = new hrReserva(5);
            fLab.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hrReserva fLab = new hrReserva(6);
            fLab.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hrReserva fLab = new hrReserva(7);
            fLab.Show();
        }

        private void lblLab1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hrReserva fLab = new hrReserva(2);
            fLab.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            hrReserva fLab = new hrReserva(3);
            fLab.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblLab7_Click(object sender, EventArgs e)
        {

        }

        private void lblLab6_Click(object sender, EventArgs e)
        {

        }

        private void lblLab5_Click(object sender, EventArgs e)
        {

        }

        private void lblLab3_Click(object sender, EventArgs e)
        {

        }

        private void lblLab2_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
