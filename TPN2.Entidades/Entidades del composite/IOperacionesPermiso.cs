using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades.Entidades_del_composite
{
    public interface IOperacionesPermiso
    {
        void Add(Permiso pPermiso);

        void Remove(Permiso pPermiso);

        void Clear();

        List<Permiso> GetAll();

    }
}
