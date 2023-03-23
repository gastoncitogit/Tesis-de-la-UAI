using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TPN2.Abstraccion;
using TPN2.Entidades;
using TPN2.Mapper;

namespace TPN2.LogicaDeNegocio
{
    public class BLLPermiso : IGestor<Permiso>
    {
        public BLLPermiso()
        {
            permisoMapper = new MPPPermiso();
        }
        MPPPermiso permisoMapper;
        public void Alta(Permiso Objeto)
        {
            permisoMapper.Alta(Objeto);
        }

        public void Baja(Permiso Objeto)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Permiso Objeto)
        {
            throw new NotImplementedException();
        }

        public List<Permiso> TraerTodos()
        {
            return permisoMapper.TraerTodos();
        }
        public List<Perfil> TraerTodosPerfiles()
        {
            return permisoMapper.TraerTodos().OfType<Perfil>().ToList();
        }
        public List<PuntosDeMenu> TraerTodosPuntosDeMenu()
        {
            return permisoMapper.TraerTodos().OfType<PuntosDeMenu>().ToList();
        }

        public bool PermisoYaExiste(Permiso pPermiso)
        {
            List<Permiso> lista = TraerTodos();
            return lista.Exists(x => x.Nombre == pPermiso.Nombre);          
        }

        public List<string> TrearPermisosPorPerfil(int idPerfil)
        {
            Perfil perfilDelUsuario = (Perfil)TraerPermisoPorId(idPerfil);
            CargarPermisosDelPerfilSeleccionado(perfilDelUsuario, idPerfil);
            return perfilDelUsuario.GetPermisos().Split(';').OfType<string>().ToList(); 
        }

        

        public void AsignarPermisoAPerfil(Perfil pPerfil, Permiso pPermiso)
        {
            permisoMapper.AsignarPermisoAPerfil(pPerfil, pPermiso);
        }

        //funcion para verificar si el permiso es padre del perfil, como parametro es el perfilSeleccionado en la grilla y el permiso en el combo
        public bool PermisoEsPadreDelPerfil(Perfil pPerfil, Permiso pPermiso)
        {
            List<PermisoPorPerfil> listaPermisosPorPerfil = permisoMapper.TraerTodosLosPermisosPorPerfil();
            if (PermisoEsPadreDelPerfilRecursivo(listaPermisosPorPerfil, pPerfil.ID, pPermiso.ID))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool PermisoEsPadreDelPerfilRecursivo(List<PermisoPorPerfil> listaPermisosPorPerfil,int IdPadreParametro, int IdHijoParametro)
        {
            
            if (listaPermisosPorPerfil.Exists(x => x.IdHijo == IdPadreParametro)) //Se verifica si el idPadre existe como idHijo en algun elemento de la lista
            {
                int nuevoIdPadre = listaPermisosPorPerfil.Find(x => x.IdHijo == IdPadreParametro).IdPadre; //se asigna al nuevoidPadre si se cumple la condicion
                if (nuevoIdPadre == IdHijoParametro)//se pregunta lo mismo para seguir desglosando, si es true llegamos a la hoja
                    return true;
                else
                    return PermisoEsPadreDelPerfilRecursivo(listaPermisosPorPerfil, nuevoIdPadre, IdHijoParametro); //sino se repite
            }
            else
                return false;
          
        }
        //funcion para recorrer el arbol
        public void CargarPermisosDelPerfilSeleccionado(Perfil pPerfilSeleccionado, int pId)
        {
            //se busca donde el parametro sea padre en toda la lista
            List<PermisoPorPerfil> listaDePermisosPorPerfil = permisoMapper.TraerTodosLosPermisosPorPerfil().FindAll(x => x.IdPadre == pId);
            //por cada permiso en la nueva lista
            foreach(PermisoPorPerfil permisoPorPerfil in listaDePermisosPorPerfil)
            {
                //se verifica si el idhijo existe como el "idpadre" de algun otro elemento en la lista, si idhijo es padre de otro significa que es un perfil
                if (permisoMapper.TraerTodosLosPermisosPorPerfil().Exists(x => x.IdPadre == permisoPorPerfil.IdHijo))
                {
                    //si es cierto,se crea un perfil y se vuelve a llamar a la funcion con el perfil anidado, y con el id para seguir recorriendo
                    Perfil perfilAnidado = (Perfil)TraerPermisoPorId(permisoPorPerfil.IdHijo);
                    //Como el Idhijo del perfil puede ser otro perfil, se llama otra vez
                    CargarPermisosDelPerfilSeleccionado(perfilAnidado, permisoPorPerfil.IdHijo); 
                    pPerfilSeleccionado.Add(perfilAnidado);
                }
                else
                    pPerfilSeleccionado.Add(TraerPermisoPorId(permisoPorPerfil.IdHijo)); //llegar a la hoja
            }
        }

        public void RemoverPermisosDelPerfilSeleccionado(Perfil pPerfilSeleccionado)
        {
            permisoMapper.RemoverPermisosDelPerfilSeleccionado(pPerfilSeleccionado);
        }

        //Funcion para verificar si el permiso ya esta asignado a un perfil
        public bool PermisoYaEstaAsignadoAPerfil(Perfil pPerfil, Permiso pPermiso)
        {
            //Instancio una lista, y la igualo a una lista de permisosPorPerfil donde el ID padre sea igual al ID del perfil del parametro
            List<PermisoPorPerfil> listaDePermisosPorPerfil = permisoMapper.TraerTodosLosPermisosPorPerfil().FindAll(x => x.IdPadre == pPerfil.ID);
            //Por cada permiso en la lista de permisosPorPerfil se verifica si los ids son iguales, si lo son termina la rama ahi 
            foreach (PermisoPorPerfil permisoPorPerfil in listaDePermisosPorPerfil)
            {
                if (permisoPorPerfil.IdHijo == pPermiso.ID)
                {
                    return true;
                }
                //caso contrario, se sigue desglosando,diversificando la rama
                else
                {
                    if(permisoMapper.TraerTodosLosPermisosPorPerfil().Exists(x => x.IdPadre == permisoPorPerfil.IdHijo))
                    {
                        Perfil perfilAnidado = (Perfil)TraerPermisoPorId(permisoPorPerfil.IdHijo);
                        return PermisoYaEstaAsignadoAPerfil(perfilAnidado,pPermiso);
                    }
                    
                }
                
            }
            return false;
        }

        
            
        public List<PermisoPorPerfil> TraerTodosLosPermisosPorPerfil()
        {
            return permisoMapper.TraerTodosLosPermisosPorPerfil();
        }

        public Permiso TraerPermisoPorId(int pId)
        {
            return permisoMapper.TraerTodos().Find(x => x.ID == pId);
            
        }
    }
}
