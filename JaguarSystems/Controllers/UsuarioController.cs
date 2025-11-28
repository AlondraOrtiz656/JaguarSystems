using JaguarSystems.Data;
using JaguarSystems.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarSystems.Controllers
{
    internal class UsuarioController
    {
        private UsuarioDAO dao = new UsuarioDAO();

        public Usuario Login(string user, string pass)
        {
            return dao.Login(user, pass);
        }   
    }

}
