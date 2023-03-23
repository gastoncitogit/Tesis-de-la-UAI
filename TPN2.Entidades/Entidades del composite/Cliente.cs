using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    [Serializable]
    public class Cliente : Usuario
    {
        
        #region "Constructores"
        public Cliente()
        {
            
        }
        public Cliente(string mail, string contraseña, string apellido, string nombre)
        {
            Mail = mail;
            Contraseña = contraseña;
            Apellido = apellido;
            Nombre = nombre;
        }

        #endregion

        #region "Propiedades"
        

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public int PerfilAsignado { get; set; }

        #endregion
    }



}
