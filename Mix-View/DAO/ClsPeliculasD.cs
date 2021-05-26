using Mix_View.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_View.DAO
{
    class ClsPeliculasD
    {
        public List<Peliculas_Y_Series> cargarcontenido(string filtro)
        {
            List<Peliculas_Y_Series> lista;
            using (MixViewDBEntities db = new MixViewDBEntities())
            {
                lista = (from peliculas in db.Peliculas_Y_Series
                         where peliculas.Nombre.Contains(filtro)
                         select peliculas).ToList();
            }

            return lista;
        }

        public List<Peliculas_Y_Series> cargarcontenidoporgenero(string filtro)
        {
            List<Peliculas_Y_Series> lista;
            using (MixViewDBEntities db = new MixViewDBEntities())
            {
                lista = (from peliculas in db.Peliculas_Y_Series
                         where peliculas.Genero.Contains(filtro)
                         select peliculas).ToList();
            }

            return lista;
        }

        public List<Peliculas_Y_Series> cargarcontenidoportipo(string filtro)
        {
            List<Peliculas_Y_Series> lista;
            using (MixViewDBEntities db = new MixViewDBEntities())
            {
                lista = (from peliculas in db.Peliculas_Y_Series
                         where peliculas.Tipo.Contains(filtro)
                         select peliculas).ToList();
            }

            return lista;
        }


    }
}
