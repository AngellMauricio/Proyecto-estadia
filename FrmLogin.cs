using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_ESTADIA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtUsuario.Text = ""; // Borra el texto de indicación
                txtUsuario.ForeColor = Color.Black; // Cambia el color de la letra a negro para el usuario
            }
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtUsuario.Text = ""; // Borra el texto de indicación
                txtUsuario.ForeColor = Color.Black; // Cambia el color de la letra a negro para el usuario
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal  = new FrmPrincipal();
            principal.Show();

        }
    }
}
