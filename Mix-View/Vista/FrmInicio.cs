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
            Application.Exit();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
