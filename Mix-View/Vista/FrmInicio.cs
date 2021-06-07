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

        void cargarcontenido()
        {
            ClsPeliculasD peliculasD = new ClsPeliculasD();
            dataGridView1.Rows.Clear();

            foreach (var peliculas in peliculasD.cargarcontenido(txtFiltro.Text))
            {
                dataGridView1.Rows.Add(peliculas.Nombre, peliculas.Genero, peliculas.Tipo, peliculas.Urls);
            }
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            cargarcontenido();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargarcontenido();
        }

        void cargarcontenidoportipo(string filtro)
        {
            ClsPeliculasD peliculasD = new ClsPeliculasD();
            dataGridView1.Rows.Clear();

            foreach (var peliculas in peliculasD.cargarcontenidoportipo(filtro))
            {
                dataGridView1.Rows.Add(peliculas.Nombre, peliculas.Genero, peliculas.Tipo, peliculas.Urls);
            }
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            cargarcontenidoportipo("Pelicula");
        }

        private void BtnSeries_Click(object sender, EventArgs e)
        {
            cargarcontenidoportipo("Serie");
        }

        void cargarcontenidoporgenero(string filtro)
        {
            ClsPeliculasD peliculasD = new ClsPeliculasD();
            dataGridView1.Rows.Clear();

            foreach (var peliculas in peliculasD.cargarcontenidoporgenero(filtro))
            {
                dataGridView1.Rows.Add(peliculas.Nombre, peliculas.Genero, peliculas.Tipo, peliculas.Urls);
            }
        }

        private void BtnTerror_Click(object sender, EventArgs e)
        {
            cargarcontenidoporgenero("terror");
        }

        private void BtnComedia_Click(object sender, EventArgs e)
        {
            cargarcontenidoporgenero("comedia");
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            FrmCuenta cuenta = new FrmCuenta();
            cuenta.TxtId.Enabled = false;
            cuenta.LbId.Visible = false;
            cuenta.LbUsuario.Visible = false;
            cuenta.LbEmail.Visible = false;
            cuenta.LbEdad.Visible = false;
            cuenta.lbg.Visible = false;
            cuenta.lbPs.Visible = false;
            cuenta.label7.Visible = false;
            cuenta.Show();
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
            cuenta.Show();
           
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string urls = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            ClsReproductor cls = new ClsReproductor();
            cls.Reproducir(urls);
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
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PnlEmergente.Visible == false)
            {
                PnlEmergente.Visible = true;
            }
            else
            {
                PnlEmergente.Visible = false;
            }
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

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
