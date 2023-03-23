using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPN2.Entidades;

namespace TPN2.Entidades
{
    public class UserRecord : Entidad
    {
        public string Mail { get; set; }

        public DateTime FechaDeLogueo { get; set; }

        public UserRecord()
        {
            FechaDeLogueo= DateTime.Now;    
        }
    }
}
