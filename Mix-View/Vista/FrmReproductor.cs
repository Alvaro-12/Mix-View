using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_View.Vista
{
    public partial class FrmReproductor : Form
    {
        public FrmReproductor()
        {
            InitializeComponent();
        }

        public void video(string url)
        {
            Player.URL = url;
        }

    }
}
