using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JaguarSystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(
            "Server=localhost\\SQLEXPRESS; Database=InventarioDB; Integrated Security=True;"
        );

        private void Form1_Load(object sender, EventArgs e)
        {
            ProbarConexion();
        }

        private void ProbarConexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión exitosa ✔", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

