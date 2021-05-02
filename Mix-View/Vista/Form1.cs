using Mix_View.DAO;
using Mix_View.Model;
using Mix_View.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            ClsLoginD logD = new ClsLoginD();
            logD.entrar(TxtUsuario.Text,TxtPassword.Text);
            if(ClsAlmacenId.Id != 0)
            {
                FrmInicio ini = new FrmInicio();
                ini.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto"); 
            }
            

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmReg reg = new FrmReg();
            reg.Show(this);
            this.Hide();
        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
