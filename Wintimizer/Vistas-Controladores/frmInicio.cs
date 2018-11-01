using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wintimizer.Vistas_Controladores;

namespace Wintimizer
{
    public partial class frmInicio : Form
    {

        public frmServicios frmServicios;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            if (frmServicios == null || !frmServicios.CanFocus)
            {
                this.frmServicios = new frmServicios();
                this.frmServicios.Show();
            }
        }
    }
}
