using System;
using System.Security.Cryptography;
using System.Text;

namespace TPN2.Servicios
{
    public static class Encriptacion
    {
        public static string EncriptarClave(string rawData)
        {
            byte[] encryted = Encoding.Unicode.GetBytes(rawData);
            string result = Convert.ToBase64String(encryted);
            return result;
        }

        public static string Desencriptar(this string _cadenaAdesencriptar)
        {
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            string result = Encoding.Unicode.GetString(decryted);
            return result;
        }
    }

}

