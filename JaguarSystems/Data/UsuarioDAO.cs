using JaguarSystems.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarSystems.Data
{
    internal class UsuarioDAO
    {
        private Database db = new Database(); 
        public Usuario Login(string usuario, string clave)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                SELECT *
                FROM usuarios
                WHERE usuario = @usuario
                  AND clave = @clave
                  AND activo = 1";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.Read())
                    return null;

                Usuario u = new Usuario
                {
                    IdUsuarios = (long)dr["id_usuarios"],
                    Nombre = dr["nombre"].ToString(),
                    UsuarioLogin = dr["usuario"].ToString(),
                    Clave = dr["clave"].ToString(),
                    IdRol = (long)dr["id_rol"],
                    Activo = (bool)dr["activo"],

                    InvProductos = (bool)dr["inv_productos"],
                    InvAlmacenes = (bool)dr["inv_almacenes"],
                    InvUbicaciones = (bool)dr["inv_ubicaciones"],
                    InvDepartamentos = (bool)dr["inv_departamentos"],
                    InvGrupos = (bool)dr["inv_grupos"],
                    InvCotizaciones = (bool)dr["inv_cotizaciones"],
                    InvCompras = (bool)dr["inv_compras"],
                    InvMovimientos = (bool)dr["inv_movimientos"],
                    InvDevoluciones = (bool)dr["inv_devoluciones"],
                    InvFacturacion = (bool)dr["inv_facturacion"],
                    InvConsultas = (bool)dr["inv_consultas"],
                    InvReportes = (bool)dr["inv_reportes"],

                    CxcClientes = (bool)dr["cxc_clientes"],
                    CxcCobros = (bool)dr["cxc_cobros"],

                    CxpProveedores = (bool)dr["cxp_proveedores"],
                    CxpPagos = (bool)dr["cxp_pagos"],

                    ConfUsuario = (bool)dr["conf_usuario"],
                    ConfRoles = (bool)dr["conf_roles"],
                    ConfEmpresa = (bool)dr["conf_empresa"],
                    ConfMoneda = (bool)dr["conf_moneda"],
                    ConfCondicion = (bool)dr["conf_condicion"],
                };

                return u;
            }
        }
    }
}
