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
    public partial class FrmCuenta : Form
    {
        public FrmCuenta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCuenta_Load(object sender, EventArgs e)
        {
            ClsCuentaD cls = new ClsCuentaD();
            cls.cargardatos(ClsAlmacenId.Id);
            TxtId.Text = cls.Id.ToString();
            TxtUsuario.Text = cls.Nombre;
            TxtEmail.Text = cls.Gmail;
            Txtedad.Text = cls.Edad.ToString();
            LbId.Text = cls.Id.ToString();
            LbUsuario.Text = cls.Nombre;
            LbEmail.Text = cls.Gmail;
            LbEdad.Text = cls.Edad.ToString();
            if (cls.Genero == 1)
            {
                LbGenero.Text = "Masculino";
                RbMsculino.Checked = true;
            }
            else
            {
                LbGenero.Text = "Femenina";
                RbFemenino.Checked = true;
            }
            LbPass.Text = cls.Pass;
            TxtPass.Text = cls.Pass;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ClsCuentaD clsInfo = new ClsCuentaD();
            Users users = new Users();
            users.Id = Convert.ToInt32(TxtId.Text);
            users.Nombre = TxtUsuario.Text;
            users.Gmail = TxtEmail.Text;
            users.Edad = Convert.ToInt32(Txtedad.Text);
            users.Genero = RbMsculino.Checked == true ? 1 : 2;
            users.Pass = TxtPass.Text;
            clsInfo.actualuzardatos(users);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsCuentaD clsInfo = new ClsCuentaD();
            clsInfo.Eliminar(Convert.ToInt32(TxtId.Text));
            this.Dispose();
        }

        private void LbGenero_Click(object sender, EventArgs e)
        {

        }

        private void LbEmail_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
