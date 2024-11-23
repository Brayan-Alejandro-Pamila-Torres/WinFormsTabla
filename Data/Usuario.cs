using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsTabla.Modelo;

namespace WinFormsTabla.Data
{
    public class Usuario
    {
        List<UsuarioModel > lista = new List<UsuarioModel>();
       //Guarda los usuarios con el parametro de usuario
        public void Guardar(UsuarioModel modelo)
        {
            lista.Add(modelo);
        }
        public List<UsuarioModel> Consultar()
        {
            return lista; 
        }
    }
}
