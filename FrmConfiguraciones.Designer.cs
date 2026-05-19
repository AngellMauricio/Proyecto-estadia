namespace PROYECTO_ESTADIA
{
    partial class FrmConfiguraciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlConfiguraciones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEditarticket = new System.Windows.Forms.Label();
            this.lblagregrausuarios = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblEditarticket);
            this.panel1.Controls.Add(this.lblagregrausuarios);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 899);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuraciones";
            // 
            // pnlConfiguraciones
            // 
            this.pnlConfiguraciones.Location = new System.Drawing.Point(330, 132);
            this.pnlConfiguraciones.Name = "pnlConfiguraciones";
            this.pnlConfiguraciones.Size = new System.Drawing.Size(1578, 718);
            this.pnlConfiguraciones.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_ESTADIA.Properties.Resources.configuraciones;
            this.pictureBox1.Location = new System.Drawing.Point(417, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEditarticket
            // 
            this.lblEditarticket.AutoSize = true;
            this.lblEditarticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarticket.Image = global::PROYECTO_ESTADIA.Properties.Resources.boton_editar;
            this.lblEditarticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEditarticket.Location = new System.Drawing.Point(53, 260);
            this.lblEditarticket.Name = "lblEditarticket";
            this.lblEditarticket.Size = new System.Drawing.Size(215, 31);
            this.lblEditarticket.TabIndex = 5;
            this.lblEditarticket.Text = "       Editar Ticket";
            this.lblEditarticket.Click += new System.EventHandler(this.lblEditarticket_Click);
            // 
            // lblagregrausuarios
            // 
            this.lblagregrausuarios.AutoSize = true;
            this.lblagregrausuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagregrausuarios.Image = global::PROYECTO_ESTADIA.Properties.Resources.agregar_usuario__1_;
            this.lblagregrausuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblagregrausuarios.Location = new System.Drawing.Point(26, 158);
            this.lblagregrausuarios.Name = "lblagregrausuarios";
            this.lblagregrausuarios.Size = new System.Drawing.Size(262, 31);
            this.lblagregrausuarios.TabIndex = 4;
            this.lblagregrausuarios.Text = "      Agregar usuarios";
            this.lblagregrausuarios.Click += new System.EventHandler(this.lblagregrausuarios_Click);
            // 
            // FrmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 900);
            this.Controls.Add(this.pnlConfiguraciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfiguraciones";
            this.Text = "FrmConfiguraciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlConfiguraciones;
        private System.Windows.Forms.Label lblagregrausuarios;
        private System.Windows.Forms.Label lblEditarticket;
    }
}