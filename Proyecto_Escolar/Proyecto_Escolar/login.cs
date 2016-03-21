using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escolar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public bool loguado = false;

        private void button1_Click(object sender, EventArgs e)
        {
            loguado = true;

            if (loguado == true)
            {
                MessageBox.Show("Bienbenido usuario", "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aceeso denegado, intente nueva mente","Error",MessageBoxButtons.OK);
                textNombre.Text = "";
                textContraseña.Text = "";
                textNombre.Focus();
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
