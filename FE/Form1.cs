using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = Convert.ToInt32(txtDia.Text);
            int mes = Convert.ToInt32(txtMes.Text);
            int ano = Convert.ToInt32(txtAno.Text);
            Fecha f = new Fecha(dia, mes, ano);
            lblMostrarFecha.Text = f.MostrarFecha(f);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
