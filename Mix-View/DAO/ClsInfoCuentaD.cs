using Mix_View.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_View.DAO
{
    class ClsInfoCuentaD
    {
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
    }
}
