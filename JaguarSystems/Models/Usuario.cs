using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarSystems.Models
{
    internal class Usuario
    {
        public long IdUsuarios { get; set; }
        public string Nombre { get; set; }
        public string UsuarioLogin { get; set; }
        public string Clave { get; set; }
        public long IdRol { get; set; }
        public bool Activo { get; set; }

        public bool InvProductos { get; set; }
        public bool InvAlmacenes { get; set; }
        public bool InvUbicaciones { get; set; }
        public bool InvDepartamentos { get; set; }
        public bool InvGrupos { get; set; }
        public bool InvCotizaciones { get; set; }
        public bool InvCompras { get; set; }
        public bool InvMovimientos { get; set; }
        public bool InvDevoluciones { get; set; }
        public bool InvFacturacion { get; set; }
        public bool InvConsultas { get; set; }
        public bool InvReportes { get; set; }

        public bool CxcClientes { get; set; }
        public bool CxcCobros { get; set; }

        public bool CxpProveedores { get; set; }
        public bool CxpPagos { get; set; }

        public bool ConfUsuario { get; set; }
        public bool ConfRoles { get; set; }
        public bool ConfEmpresa { get; set; }
        public bool ConfMoneda { get; set; }
        public bool ConfCondicion { get; set; }
    }

    
}
