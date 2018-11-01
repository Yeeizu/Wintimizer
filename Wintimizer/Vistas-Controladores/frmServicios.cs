using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wintimizer.Entidades;

namespace Wintimizer.Vistas_Controladores
{
    public partial class frmServicios : Form
    {
        private CServicios cServicios;

        public frmServicios()
        {
            InitializeComponent();
            cServicios = new CServicios(this);
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            cServicios.DesactivarClick();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            cServicios.ActivarClick();
        }
    }
}
