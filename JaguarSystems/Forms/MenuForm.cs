using JaguarSystems.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaguarSystems.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            CargarPermisos();
        }

        private void CargarPermisos()
        {
            var u = Sesion.UsuarioActual;

            // Inventario
            btnProductos.Enabled = u.InvProductos;
            btnAlmacenes.Enabled = u.InvAlmacenes;
            btnUbicaciones.Enabled = u.InvUbicaciones;
            btnDepartamentos.Enabled = u.InvDepartamentos;
            btnGrupos.Enabled = u.InvGrupos;
            btnCotizaciones.Enabled = u.InvCotizaciones;
            btnCompras.Enabled = u.InvCompras;
            btnMovimientos.Enabled = u.InvMovimientos;
            btnDevoluciones.Enabled = u.InvDevoluciones;
            btnFacturacion.Enabled = u.InvFacturacion;
            btnConsultas.Enabled = u.InvConsultas;
            btnReportes.Enabled = u.InvReportes;

            // Cuentas por Cobrar
            btnClientes.Enabled = u.CxcClientes;
            btnCobros.Enabled = u.CxcCobros;

            // Cuentas por Pagar
            btnProveedores.Enabled = u.CxpProveedores;
            btnPagos.Enabled = u.CxpPagos;

            // Configuración
            btnUsuarios.Enabled = u.ConfUsuario;
            btnRoles.Enabled = u.ConfRoles;
            btnEmpresa.Enabled = u.ConfEmpresa;
            btnMoneda.Enabled = u.ConfMoneda;
            btnCondicion.Enabled = u.ConfCondicion;

            // Mostrar nombre del usuario logueado
            lblUsuario.Text = "Usuario: " + u.Nombre;
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void condiciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void entradasSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
