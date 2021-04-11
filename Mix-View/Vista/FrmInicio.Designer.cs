
namespace Mix_View.Vista
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlEmergente = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.Button();
            this.Informacion = new System.Windows.Forms.Button();
            this.PnlBtn1 = new System.Windows.Forms.Panel();
            this.BtnInfoCuenta = new System.Windows.Forms.Button();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            this.PnlEmergente.SuspendLayout();
            this.PnlBtn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.PnlEmergente);
            this.PnlMenu.Controls.Add(this.PnlBtn1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(305, 661);
            this.PnlMenu.TabIndex = 0;
            // 
            // PnlEmergente
            // 
            this.PnlEmergente.Controls.Add(this.Salir);
            this.PnlEmergente.Controls.Add(this.Informacion);
            this.PnlEmergente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEmergente.Location = new System.Drawing.Point(0, 33);
            this.PnlEmergente.Name = "PnlEmergente";
            this.PnlEmergente.Size = new System.Drawing.Size(305, 55);
            this.PnlEmergente.TabIndex = 1;
            this.PnlEmergente.Visible = false;
            // 
            // Salir
            // 
            this.Salir.Dock = System.Windows.Forms.DockStyle.Top;
            this.Salir.Location = new System.Drawing.Point(0, 23);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(305, 23);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir ";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Informacion
            // 
            this.Informacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Informacion.Location = new System.Drawing.Point(0, 0);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(305, 23);
            this.Informacion.TabIndex = 0;
            this.Informacion.Text = "Informacion ";
            this.Informacion.UseVisualStyleBackColor = true;
            // 
            // PnlBtn1
            // 
            this.PnlBtn1.Controls.Add(this.BtnInfoCuenta);
            this.PnlBtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBtn1.Location = new System.Drawing.Point(0, 0);
            this.PnlBtn1.Name = "PnlBtn1";
            this.PnlBtn1.Size = new System.Drawing.Size(305, 33);
            this.PnlBtn1.TabIndex = 0;
            // 
            // BtnInfoCuenta
            // 
            this.BtnInfoCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInfoCuenta.Location = new System.Drawing.Point(0, 0);
            this.BtnInfoCuenta.Name = "BtnInfoCuenta";
            this.BtnInfoCuenta.Size = new System.Drawing.Size(305, 27);
            this.BtnInfoCuenta.TabIndex = 0;
            this.BtnInfoCuenta.Text = "Informacion Cuenta ";
            this.BtnInfoCuenta.UseVisualStyleBackColor = true;
            this.BtnInfoCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(305, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(670, 661);
            this.PnlContenedor.TabIndex = 1;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 661);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlEmergente.ResumeLayout(false);
            this.PnlBtn1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlEmergente;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Informacion;
        private System.Windows.Forms.Panel PnlBtn1;
        private System.Windows.Forms.Button BtnInfoCuenta;
        private System.Windows.Forms.Panel PnlContenedor;
    }
}