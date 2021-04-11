
namespace Mix_View.Vista
{
    partial class FrmReg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReg));
            this.label1 = new System.Windows.Forms.Label();
            this.Gmail = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdM = new System.Windows.Forms.RadioButton();
            this.Rdf = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtGmail = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario";
            // 
            // Gmail
            // 
            this.Gmail.AutoSize = true;
            this.Gmail.Location = new System.Drawing.Point(42, 136);
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(33, 13);
            this.Gmail.TabIndex = 1;
            this.Gmail.Text = "Gmail";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(42, 205);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdM);
            this.groupBox1.Controls.Add(this.Rdf);
            this.groupBox1.Location = new System.Drawing.Point(45, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RdM
            // 
            this.RdM.AutoSize = true;
            this.RdM.Location = new System.Drawing.Point(160, 48);
            this.RdM.Name = "RdM";
            this.RdM.Size = new System.Drawing.Size(73, 17);
            this.RdM.TabIndex = 1;
            this.RdM.TabStop = true;
            this.RdM.Text = "Masculino";
            this.RdM.UseVisualStyleBackColor = true;
            // 
            // Rdf
            // 
            this.Rdf.AutoSize = true;
            this.Rdf.Location = new System.Drawing.Point(48, 48);
            this.Rdf.Name = "Rdf";
            this.Rdf.Size = new System.Drawing.Size(71, 17);
            this.Rdf.TabIndex = 0;
            this.Rdf.TabStop = true;
            this.Rdf.Text = "Femenino";
            this.Rdf.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(146, 59);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(227, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtGmail
            // 
            this.TxtGmail.Location = new System.Drawing.Point(146, 136);
            this.TxtGmail.Name = "TxtGmail";
            this.TxtGmail.Size = new System.Drawing.Size(227, 20);
            this.TxtGmail.TabIndex = 7;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(146, 202);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(227, 20);
            this.TxtEdad.TabIndex = 8;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(146, 271);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(227, 20);
            this.TxtPass.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtGmail);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Gmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReg";
            this.Text = "FrmReg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReg_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Gmail;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtGmail;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.RadioButton RdM;
        private System.Windows.Forms.RadioButton Rdf;
        private System.Windows.Forms.Button button1;
    }
}