using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wintimizer.Entidades;

namespace Wintimizer.Vistas_Controladores
{
    class CServicios
    {
        public frmServicios FrmServicios{get; set;}
        EServicio[] servicioLista = {};

        public CServicios(frmServicios frmServicios)
        {
            FrmServicios = frmServicios;
            cargarListaServicios();
        }

        private EServicio[] generarLista()
        {
            EServicio[] servicioLista = {
                new EServicio("Themes", "Temas", "El gestor de temas de Windows consume RAM y rendimiento gráfico."),
                new EServicio("WSearch", "Indexador de Búsqueda", "Este servicio consume Disco y RAM, mientras va indexando archivos para proporcionarle busquedas instantáneas."),
                new EServicio("mpssvc", "Firewall", "Este servicio escucha las conexiones de Red para garantizar la seguridad."),
                new EServicio("Fax", "Fax", "Si utilizas algún Fax, es recomendable dejarlo activado."),
                new EServicio("SecurityHealthService", "Centro de Seguridad", "Puedes desactivar el servicio de centro de seguridad de Windows, si no usas el antivirus del sistema."),
                new EServicio("BITS", "Transferencia en segundo plano", "Este servicio utiliza Disco para trasnferir archivos en segundo plano."),
                new EServicio("wuauserv", "Actualizaciones", "Consume Disco, Red y RAM en segundo plano mientras busca, descarga y actualiza Windows.")
            };
            return servicioLista;
        }

        public void DesactivarClick()
        {
            foreach (ListViewItem nombreServicio in FrmServicios.lvServicios.CheckedItems)
            {
                EServicio servicioObjeto = new EServicio(nombreServicio.Name);
                if (servicioObjeto.Estado == true)
                    servicioObjeto.desactivar();

            }
            cargarListaServicios();
        }
        public void ActivarClick()
        {
            foreach (ListViewItem nombreServicio in FrmServicios.lvServicios.CheckedItems)
            {
                EServicio servicioObjeto = new EServicio(nombreServicio.Name);
                if (servicioObjeto.Estado == false)
                    servicioObjeto.activar();
            }
            cargarListaServicios();
        }

        public void cargarListaServicios()
        {
            servicioLista = generarLista();

            FrmServicios.lvServicios.Items.Clear();

            foreach (EServicio item in servicioLista)
            {
                string[] fila = { item.EstadoTexto, item.Nombre, item.Descripcion };
                ListViewItem lvFila = new ListViewItem(fila);
                lvFila.Name = item.NombreServicio;
                FrmServicios.lvServicios.Items.Add(lvFila);
            }

            for (int x = 0; x < FrmServicios.lvServicios.Columns.Count; x++)
            {
                FrmServicios.lvServicios.Columns[x].Width = -2;
            }
        }
    }
}
