using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    internal class Sesion
    {
        //Creamos la instancia para el patron

        private static Sesion instance = null;

        //Damos los atributos a la clase
        public Usuario usuario { get; set; }

        public DateTime FechaInicio { get; set; }


        public static Sesion Instance
        {
            get
            {
                //Instanciamos, y agregamos una excepcion
                if (instance == null) throw new Exception("Sesion no iniciada");



                return instance;

            }


        }

        //Creamos el metodo login para iniciar sesion
        public static void Login(Usuario usuario)
        {

            if (instance == null)
            {
                instance = new Sesion(); //

                instance.usuario = usuario; //Para que inicie sesion

                instance.FechaInicio = DateTime.Now; // Para saber a que hora ingreso sesion
            }
            else
            {
                throw new Exception("Sesion ya iniciada");
            }
        }

        public static void Logout(Usuario usuario)
        {



            if (instance != null)
            {
                instance = null; //Si instancia es diferente de null, entonces se cerrara sesion
            }
            else
            {
                throw new Exception("Sesion no iniciada");
            }


        }

        private Sesion()
        {

        }

    }
}

