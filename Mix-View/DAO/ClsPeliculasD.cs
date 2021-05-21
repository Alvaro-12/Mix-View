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
        public List<Peliculas_Y_Series> cargarpeliculas(string filtro)
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

        public List<Peliculas_Y_Series> cargarpeliculasgenero(string filtro)
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
        public List<Peliculas_Y_Series> cargarpeliculastipo(string filtro)
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
