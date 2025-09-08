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
    public partial class frmGestionAgenda : Form
    {
        public frmGestionAgenda()
        {
            InitializeComponent();
        }
        string vContacto = "";
        string vNumero = "";


        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "")
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                btnAgendar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                btnAgendar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;

            lstResumen.Items.Add("Contacto: " + vContacto
                + "Numero:" + vNumero);

            txtContacto.Text = "";
            mtbNumero.Text = "";
        }
    }
}
