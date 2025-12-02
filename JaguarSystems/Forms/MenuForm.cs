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
            
        }


        private void MenuForm_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }
        private void AplicarPermisos()
        {
            var u = Sesion.UsuarioActual;

            // Inventario
            MantProductos.Enabled = u.InvProductos;
            MantAlmacenes.Enabled = u.InvAlmacenes;
            MantUbicaciones.Enabled = u.InvUbicaciones;
            MantDepartamentos.Enabled = u.InvDepartamentos;
            MantGrupos.Enabled = u.InvGrupos;
            ProCotizacion.Enabled = u.InvCotizaciones;
            ProCompras.Enabled = u.InvCompras;
            MantTipoMovimiento.Enabled = u.InvMovimientos;
            ProDevoluciones.Enabled = u.InvDevoluciones;
            ProFacturacion.Enabled = u.InvFacturacion;
            btnInvConsultas.Enabled = u.InvConsultas;
            btnInvReportes.Enabled = u.InvReportes;

            // CXC
            MantClientes.Enabled = u.CxcClientes;
            ConsClientes.Enabled = u.CxcClientes;
            RepoClientes.Enabled = u.CxcClientes;
            ProCobro.Enabled = u.CxcCobros;
            ConsCobros.Enabled = u.CxcCobros;
            RepoCobros.Enabled = u.CxcCobros;

            // CXP
            MantProveedores.Enabled = u.CxpProveedores;
            ConsProveedores.Enabled = u.CxpProveedores;
            RepoProveedores.Enabled = u.CxpProveedores;
            ProPago.Enabled = u.CxpPagos;
            ConsPagos.Enabled = u.CxpPagos;
            RepoPagos.Enabled = u.CxpPagos;

            // Configuración
            MantUsuario.Enabled = u.ConfUsuario;
            ConsUsuario.Enabled = u.ConfUsuario;
            RepoUsuario.Enabled = u.ConfUsuario;
            MantRoles.Enabled = u.ConfRoles;
            ConsRoles.Enabled = u.ConfRoles;
            RepoRoles.Enabled = u.ConfRoles;
            MantEmpresa.Enabled = u.ConfEmpresa;
            ConsEmpresa.Enabled = u.ConfEmpresa;
            RepoEmpresa.Enabled = u.ConfEmpresa;
            MantMoneda.Enabled = u.ConfMoneda;
            ConsMoneda.Enabled = u.ConfMoneda;
            RepoMoneda.Enabled = u.ConfMoneda;
            MantCondicion.Enabled = u.ConfCondicion;
            ConsCondicion.Enabled = u.ConfCondicion;
            RepoCondicion.Enabled = u.ConfCondicion;
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
