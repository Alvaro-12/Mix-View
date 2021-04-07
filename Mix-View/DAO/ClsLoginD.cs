using Mix_View.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_View.DAO
{
    class ClsLoginD
    {
        public void GuardarUser(Users user)
        {
            try
            {
                Users users = new Users();
                using (MixViewDBEntities db = new MixViewDBEntities())
                {
                    users.IdNombre = user.IdNombre;
                    users.Gmail = user.Gmail;
                    users.Pass = user.Pass;
                    users.Edad = user.Edad;
                    users.Genero = user.Genero;

                    db.Users.Add(users);
                    db.SaveChanges();

                    MessageBox.Show("Se ah Registrado a " + user.IdNombre);
                }
            }
            catch
            {
                MessageBox.Show("Nombre de usuario ya registrado intenta con otro");
            }
        }
    }

   
}
