using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CargarEmpleados()
        {
            CN_Empleados objetoCN = new CN_Empleados();
            comboBox1.DataSource = objetoCN.MostrarEmpleados();
            comboBox1.DisplayMember = "NombreCompleto";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;

        }
    }
}
