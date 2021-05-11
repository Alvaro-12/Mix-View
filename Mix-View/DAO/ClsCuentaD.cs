using Mix_View.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_View.DAO
{
    class ClsCuentaD
    {    //comentario
        public void actualuzardatos(Users us)
        {
            using (MixViewDBEntities db = new MixViewDBEntities())
            {

                Users user = db.Users.Where(x => x.Id == us.Id).Select(x => x).FirstOrDefault();
                user.Nombre = us.Nombre;
                user.Gmail = us.Gmail;
                user.Edad = us.Edad;
                user.Genero = us.Genero;
                user.Pass = us.Pass;

                db.SaveChanges();

                MessageBox.Show("Se han realizado los cambios!!");
            }
        }


        public int Id;
        public string Nombre;
        public string Gmail;
        public int Edad;
        public int Genero;
        public string Pass;
        public void cargardatos(int id)
        {

            using (MixViewDBEntities db = new MixViewDBEntities())
            {

                Users users = db.Users.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
                Id = id;
                Nombre = users.Nombre;
                Gmail = users.Gmail;
                Edad = (int)users.Edad;
                if (users.Genero == 1)
                {
                    Genero = 1;
                }
                else
                {
                    Genero = 2;
                }
                Pass = users.Pass;


            }

        }

        public void Eliminar(int Id)
        {
            using (MixViewDBEntities db = new MixViewDBEntities())
            {
                Users users = db.Users.Where(x => x.Id == Id).Select(x => x).FirstOrDefault();

                db.Users.Remove(users);
                db.SaveChanges();
            }
        }
    }
}
