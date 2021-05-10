using Mix_View.DAO;
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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PnlEmergente.Visible == false)
            {
                PnlEmergente.Visible = true;
            }else
            {
                PnlEmergente.Visible = false;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PnlMenu2.Visible == false)
            {
                PnlMenu2.Visible = true;
            }
            else
            {
                PnlMenu2.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (PnlMenu3.Visible == false)
            {
                PnlMenu3.Visible = true;
            }
            else
            {
                PnlMenu3.Visible = false;
            }
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            FrmCuenta cuenta = new FrmCuenta();
            cuenta.TxtId.Enabled = false;
            cuenta.LbId.Visible = false;
            cuenta.LbUsuario.Visible = false;
            cuenta.LbEmail.Visible = false;
            cuenta.LbEdad.Visible = false;
            cuenta.LbGenero.Visible = false;
            cuenta.LbPass.Visible = false;
            cuenta.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmCuenta cuenta = new FrmCuenta();
            cuenta.TxtId.Visible = false;
            cuenta.TxtUsuario.Visible = false;
            cuenta.TxtEmail.Visible = false;
            cuenta.Txtedad.Visible = false;
            cuenta.groupBox1.Visible = false;
            cuenta.TxtPass.Visible = false;
            cuenta.BtnModificar.Visible = false;
            cuenta.BtnEliminar.Visible = false;
            cuenta.Show();
           
        }
    }
}
