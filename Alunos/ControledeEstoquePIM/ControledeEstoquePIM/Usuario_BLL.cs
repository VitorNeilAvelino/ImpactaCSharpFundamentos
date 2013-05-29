using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ControledeEstoquePIM
{
    class Usuario_BLL
    {
        Usuario_DAL usuario_dal = null;

        public void CadastrarUsuario_DAL(Usuario_MODEL obj_usuario)
        {
            usuario_dal = new Usuario_DAL();
            usuario_dal.CadastrarFuncionario(obj_usuario);

        }

    }
}
