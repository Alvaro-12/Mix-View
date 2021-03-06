using Mix_View.DAO;
using Mix_View.Model;
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
    public partial class FrmReg : Form
    {
        public FrmReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClsLoginD Logind = new ClsLoginD();
                Users user = new Users();
                user.Nombre = TxtNombre.Text;
                user.Gmail = TxtGmail.Text;
                user.Edad = Convert.ToInt32(TxtEdad.Text);
                user.Genero = RdM.Checked == true ? 1 : 2; ;
                user.Pass = TxtPass.Text;
                Logind.GuardarUser(user);

                this.Owner.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Se ha producido un error comprueba los datos o intenta con otro nombre de usuario");
                TxtNombre.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Owner.Show(); 
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        
        }
        int m, mx, my;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X-mx,MousePosition.Y-my);

            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;

        }
    }
}
