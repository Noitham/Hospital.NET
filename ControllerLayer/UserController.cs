
using DataLayer;
using System;

namespace ControllerLayer
{
    public class UserController
    {

        public String checkTypeOfUser(string nickname, string password)
        {
            //Inicializamos String result
            String result = "";
            User u = new User(nickname, password); //creamos el usuario (llamando al constructor).
            UserADO helper = new UserADO(); //llamamos a la clase que tiene el método.
            String profile = helper.checkUser(u);
            //Comparamos con los diferentes roles, y devolvemos en la variable result nuestro resultado(tipo de perfil obtenido).
            if (profile != null)
            {
                if (profile.Equals("administrador"))
                {
                    result = "Administrador";
                }
                else if (profile.Equals("direccio"))
                {
                    result = "Direccio";
                }
                else if (profile.Equals("personalsanitari"))
                {
                    result = "PersonalSanitari";
                }
                else if (profile.Equals("administratiu"))
                {
                    result = "Administratiu";
                }
            }
            //En caso de que no exista mostramos error
            else if (profile.Equals("no"))
            {
                result = "User does not exist";
            }
            else
            {
                result = "Unable to connect";
            }

            return result;

        }
    }
}
