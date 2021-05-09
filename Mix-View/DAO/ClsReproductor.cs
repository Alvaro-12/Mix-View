using Mix_View.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_View.DAO
{
    class ClsReproductor
    {
        public void Reproducir(string url)
        {
            FrmReproductor video = new FrmReproductor();
            video.video(url);
            video.Show();
        }
    }
}
