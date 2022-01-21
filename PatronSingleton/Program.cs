using System;

namespace PatronSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de objeto
            Usuario usuario = new Usuario();
            usuario.Username = "prueba";
            usuario.Password = "prueba";

            //Ejecucion de programa

            try
            {
                Sesion.Logout(usuario);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }



        }
    }
}