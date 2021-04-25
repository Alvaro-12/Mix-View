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
            //mantiene el comportamiento en splascreen
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(200);
            InitializeComponent();
            t.Abort();

           
        }
        public void SplashStart()
        {
            Application.Run(new FrmSlpashScreen());
        }
        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

            ClsLoginD logD = new ClsLoginD();
            logD.entrar(TxtUsuario.Text,TxtPassword.Text);
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmReg reg = new FrmReg();
            reg.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Funciona para presentar el formulario con normalidad 
            WindowState = FormWindowState.Normal;
            TopMost = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
