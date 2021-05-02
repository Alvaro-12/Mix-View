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
        public int reference;
        public void GuardarUser(Users user)
        {
            Users users = new Users();
            using (MixViewDBEntities db = new MixViewDBEntities())
            {
                var ls = from l in db.Users
                         where l.Nombre == user.Nombre
                         select l;
                if (ls.Count() > 0)
                {
                    reference = 1;
                }
                else
                {
                    users.Nombre = user.Nombre;
                    users.Gmail = user.Gmail;
                    users.Pass = user.Pass;
                    users.Edad = user.Edad;
                    users.Genero = user.Genero;

                    db.Users.Add(users);
                    db.SaveChanges();

                    MessageBox.Show("Se ah Registrado a " + user.Nombre);
                }
            }
        }
            public void entrar(string user, string pass)
        {
            using (MixViewDBEntities db = new MixViewDBEntities())
            {
                var ls = from l in db.Users
                         where l.Nombre == user &&
                         l.Pass == pass
                         select l.Id;
                ClsAlmacenId.Id = ls.FirstOrDefault();
                if (ls.Count() > 0)
                {
                    MessageBox.Show("Bienvenido a Mix-View " + user);

                }
            }
        }
    }

   
}
