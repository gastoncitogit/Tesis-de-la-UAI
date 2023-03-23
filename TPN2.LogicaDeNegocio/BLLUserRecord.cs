using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPN2.Mapper;
using TPN2.Entidades;
using TPN2.Abstraccion;

namespace TPN2.LogicaDeNegocio
{
    public class BLLUserRecord
    {
        MPPUserRecord mppUserRecord = new MPPUserRecord();
        public void GuardarDatos(UserRecord Clientexml)
        {
            mppUserRecord.GuardarDatos(Clientexml);
        }
        public List<UserRecord> TraerDatos()
        {
            return mppUserRecord.TraerDatos();  
        } 


    }
}
