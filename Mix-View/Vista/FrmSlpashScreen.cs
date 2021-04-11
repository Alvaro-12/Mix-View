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
    public partial class FrmSlpashScreen : Form
    {
        public FrmSlpashScreen()
        {
            InitializeComponent();
        }
        //funcion del reloj el cual controla la barra de inicio de la app
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Empieza a incrementar barra
            progressBar1.Increment(16);
            //Al llegar al maximo la barra se detiene
            if (progressBar1.Value == 100)
            {
                timer1.Stop();

            }
        }
    }
}
