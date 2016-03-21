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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public bool UsuarioLogueado = false; 

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

            if (login.loguado == true)
            {
                this.Show();
                UsuarioLogueado = true;
            }
            else
            {
                this.Close();
            }


        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UsuarioLogueado == true)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Deseas salir del sistema?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;

                    
                }
                
            }
        }
    }
}
