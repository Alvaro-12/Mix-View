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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsLoginD Logind = new ClsLoginD();
            Users user = new Users();
            user.Nombre = TxtNombre.Text;
            user.Gmail = TxtGmail.Text;
            user.Edad = Convert.ToInt32(TxtEdad.Text);
            user.Genero = RdM.Checked == true ? 1 : 2; ;
            user.Pass = TxtPass.Text;
            Logind.GuardarUser(user);
            if (Logind.reference == 1)
            {
                MessageBox.Show("Usuario ya registrado intenta con otro");
            }
            else
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void FrmReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
    }
}
