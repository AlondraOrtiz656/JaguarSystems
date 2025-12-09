using JaguarSystems.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarSystems.Controllers
{
    internal class ProductoController
    {
        private readonly string connectionString;

        public ProductoController(string conn)
        {
            connectionString = conn;
        }

        public List<Producto> GetAll()
        {
            var lista = new List<Producto>();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM productos", conn);

                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new Producto
                        {
                            IdProductos = rd.GetInt64(0),
                            Sku = rd.GetString(1),
                            Nombre = rd.GetString(2),
                            DepartamentoId = rd.GetInt64(3),
                            GrupoId = rd.GetInt64(4),
                            Unidad = rd.GetString(5),
                            PrecioVenta = rd.GetDecimal(6),
                            Costo = rd.GetDecimal(7),
                            Stock = rd.GetDecimal(8),
                            StockMin = rd.GetDecimal(9),
                            UbicacionId = rd.GetInt64(10),
                            Activo = rd.GetBoolean(11)
                        });
                    }
                }
            }
            return lista;
        }

        public void Insert(Producto p)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(@"
                    INSERT INTO productos
                    (sku, nombre, departamento_id, grupo_id, unidad, precio_venta, costo, stock, stock_min, ubicacion_id, activo)
                    VALUES (@sku, @nombre, @dept, @grupo, @unidad, @pventa, @costo, @stock, @stockmin, @ubicacion, @activo)
                ", conn);

                cmd.Parameters.AddWithValue("@sku", p.Sku);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@dept", p.DepartamentoId);
                cmd.Parameters.AddWithValue("@grupo", p.GrupoId);
                cmd.Parameters.AddWithValue("@unidad", p.Unidad);
                cmd.Parameters.AddWithValue("@pventa", p.PrecioVenta);
                cmd.Parameters.AddWithValue("@costo", p.Costo);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@stockmin", p.StockMin);
                cmd.Parameters.AddWithValue("@ubicacion", p.UbicacionId);
                cmd.Parameters.AddWithValue("@activo", p.Activo);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
