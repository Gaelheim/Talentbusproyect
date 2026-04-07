using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class WF_Posiciones : Form
    {
        public WF_Posiciones()
        {
            InitializeComponent();
            CargarDptos();
            CargarPosiciones();
        }


        private void CargarDptos()
        {
            CN_Posiciones objetoCN = new CN_Posiciones();
            comboBox1.DataSource = objetoCN.MostrarDptos();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
        }
        
        private void CargarPosiciones()
        {
            CN_Posiciones objetoCN = new CN_Posiciones();
            dataGridView1.DataSource = objetoCN.MostrarPosiciones();
        }



    }
}
