namespace PROYECTO_ESTADIA
{
    partial class FrmVentas
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
            this.label3 = new System.Windows.Forms.Label();
            this.pnlcentro = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlinferior = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btncobrar = new System.Windows.Forms.Button();
            this.pnlsuperior = new System.Windows.Forms.Panel();
            this.btnagregarproducto = new System.Windows.Forms.Button();
            this.btnReporteventas = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlcentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlinferior.SuspendLayout();
            this.pnlsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1425, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 101;
            // 
            // pnlcentro
            // 
            this.pnlcentro.Controls.Add(this.dataGridView1);
            this.pnlcentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcentro.Location = new System.Drawing.Point(0, 0);
            this.pnlcentro.Name = "pnlcentro";
            this.pnlcentro.Size = new System.Drawing.Size(1246, 601);
            this.pnlcentro.TabIndex = 111;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1246, 601);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // pnlinferior
            // 
            this.pnlinferior.Controls.Add(this.textBox1);
            this.pnlinferior.Controls.Add(this.btncobrar);
            this.pnlinferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlinferior.Location = new System.Drawing.Point(0, 499);
            this.pnlinferior.Name = "pnlinferior";
            this.pnlinferior.Size = new System.Drawing.Size(1246, 102);
            this.pnlinferior.TabIndex = 112;
            this.pnlinferior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlinferior_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(1049, -3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 71);
            this.textBox1.TabIndex = 119;
            this.textBox1.Text = "$0.00";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // btncobrar
            // 
            this.btncobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncobrar.ForeColor = System.Drawing.Color.Black;
            this.btncobrar.Image = global::PROYECTO_ESTADIA.Properties.Resources.ingreso__1_;
            this.btncobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncobrar.Location = new System.Drawing.Point(769, 10);
            this.btncobrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(272, 45);
            this.btncobrar.TabIndex = 118;
            this.btncobrar.Text = "F12 Cobrar.";
            this.btncobrar.UseVisualStyleBackColor = true;
            // 
            // pnlsuperior
            // 
            this.pnlsuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlsuperior.Controls.Add(this.btnagregarproducto);
            this.pnlsuperior.Controls.Add(this.btnReporteventas);
            this.pnlsuperior.Controls.Add(this.btnborrar);
            this.pnlsuperior.Controls.Add(this.textBox3);
            this.pnlsuperior.Controls.Add(this.btnbuscar);
            this.pnlsuperior.Controls.Add(this.label7);
            this.pnlsuperior.Location = new System.Drawing.Point(4, 2);
            this.pnlsuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlsuperior.Name = "pnlsuperior";
            this.pnlsuperior.Size = new System.Drawing.Size(1246, 110);
            this.pnlsuperior.TabIndex = 114;
            this.pnlsuperior.TabStop = true;
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.Black;
            this.btnagregarproducto.Image = global::PROYECTO_ESTADIA.Properties.Resources.agregar_p16;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregarproducto.Location = new System.Drawing.Point(942, 31);
            this.btnagregarproducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(180, 31);
            this.btnagregarproducto.TabIndex = 115;
            this.btnagregarproducto.Text = "ENTER - Agr. Prod\r\n";
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            // 
            // btnReporteventas
            // 
            this.btnReporteventas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReporteventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteventas.ForeColor = System.Drawing.Color.Black;
            this.btnReporteventas.Image = global::PROYECTO_ESTADIA.Properties.Resources.beneficio_financiero;
            this.btnReporteventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteventas.Location = new System.Drawing.Point(765, 69);
            this.btnReporteventas.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteventas.Name = "btnReporteventas";
            this.btnReporteventas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnReporteventas.Size = new System.Drawing.Size(200, 31);
            this.btnReporteventas.TabIndex = 114;
            this.btnReporteventas.Text = "Reporte de Ventas.";
            this.btnReporteventas.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            this.btnborrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.Black;
            this.btnborrar.Image = global::PROYECTO_ESTADIA.Properties.Resources.borrar;
            this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrar.Location = new System.Drawing.Point(557, 69);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnborrar.Size = new System.Drawing.Size(200, 31);
            this.btnborrar.TabIndex = 113;
            this.btnborrar.Text = "DEL Borrar Art.";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(350, 33);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(585, 26);
            this.textBox3.TabIndex = 111;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Image = global::PROYECTO_ESTADIA.Properties.Resources.busqueda;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(340, 69);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnbuscar.Size = new System.Drawing.Size(200, 31);
            this.btnbuscar.TabIndex = 112;
            this.btnbuscar.Tag = "  ";
            this.btnbuscar.Text = "   F10 Buscar.";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(159, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 110;
            this.label7.Text = "Codigo del producto :";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 601);
            this.Controls.Add(this.pnlsuperior);
            this.Controls.Add(this.pnlinferior);
            this.Controls.Add(this.pnlcentro);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.pnlcentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlinferior.ResumeLayout(false);
            this.pnlinferior.PerformLayout();
            this.pnlsuperior.ResumeLayout(false);
            this.pnlsuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlcentro;
        private System.Windows.Forms.Panel pnlinferior;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Panel pnlsuperior;
        private System.Windows.Forms.Button btnagregarproducto;
        private System.Windows.Forms.Button btnReporteventas;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label7;
    }
}