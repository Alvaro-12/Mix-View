using Mix_View.Model;
using Mix_View.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            using (MixViewDBEntities db = new MixViewDBEntities())
            {

                var ls = from l in db.Users
                         where l.IdNombre == TxtUsuario.Text &&
                         l.Pass == TxtPassword.Text
                         select l;

                if (ls.Count() > 0)
                {
                    MessageBox.Show("Acceso Consedido");
                    FrmInicio frm = new FrmInicio();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado");
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmReg reg = new FrmReg();
            reg.Show();
            this.Hide();
        }
    }
}
