using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCastilloAgendaContacto
{
    public partial class frmVerContactos : Form
    {
        public frmVerContactos()
        {
            InitializeComponent();
        }
        //declaracion de variables
        string[] vecNombre = new string[3];
        int indice = 0;
        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            lblDatos.Text = vecNombre[indice];

           
            
         
        }

        private void frmVerContactos_Load(object sender, EventArgs e)
        {
            vecNombre[0] = "Goku";
            vecNombre[1] = "Barbie";
            vecNombre[2] = "Megatron";

            lblDatos.Text = vecNombre[0];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++; //indice = indice + 1;
            lblDatos.Text = vecNombre[indice];

            if (vecNombre.Length <= (indice + 1))
            {
                btnSiguiente.Enabled = false;
            }
        }
    }
}
