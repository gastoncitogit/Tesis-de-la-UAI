using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TPN2.Servicios
{
    public static class ExpresionesRegulares
    {
        public static string PatternPrecio = @"^[0-9]+$";

        public static string PatternMail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        public static string PatternPassword = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";

        public static string PatternNombre = @"^[A-Z][a-zA-Z]*$";

        public static string PatternDescripcion = @"[A-Z]([a-z]+|[A-Z]+)";
        public static bool PrecioEsValido(string precioSinValidar)
        {
            if (Regex.IsMatch(precioSinValidar, PatternPrecio))
            {
                return true;
            }
            else return false;
        }
        public static bool DescripcionEsValida(string descripcionSinValidar)
        {
            if (Regex.IsMatch(descripcionSinValidar, PatternDescripcion))
            {
                return true;
            }
            else return false;
        }
        public static bool MailEsValido(string mailSinValidar)
        {
            if (Regex.IsMatch(mailSinValidar, PatternMail))
            {
                return true;
            }
            else return false;
        }

        public static bool ContraseñaEsValida(string contraseñaSinValidar)
        {
            if (Regex.IsMatch(contraseñaSinValidar, PatternPassword))
            {
                return true;
            }
            else return false;
        }
        public static bool NombreEsValido(string nombreSinValidar)
        {
            if (Regex.IsMatch(nombreSinValidar, PatternNombre))
            {
                return true;
            }
            else return false;
        }

    }
}
