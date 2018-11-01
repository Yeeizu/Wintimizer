using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;

namespace Wintimizer.Entidades
{
    class EServicio
    {
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        public string NombreServicio { get; set; }
        public string Descripcion { get; set; }
        public string EstadoTexto { get; set; }
        public RegistryKey RegistroKey { get; }

        public EServicio(string servicio,string nombre,string descripcion)
        {
            NombreServicio = servicio;
            RegistroKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\"+ NombreServicio, true);
            Descripcion = descripcion;
            Nombre = nombre;
            estadoActual();
            Descripcion = descripcion;
        }

        public EServicio(string servicio)
        {
            NombreServicio = servicio;
            RegistroKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\" + NombreServicio, true);
            estadoActual();
        }

        private void estadoActual()
        {
            int estado = (int)RegistroKey.GetValue("Start");

            switch (estado)
            {
                case 2:
                    activarSoloTexto();
                    break;
                case 3:
                    activarSoloTexto();
                    break;
                case 4:
                    desactivarSoloTexto();
                    break;
            }
        }

        public void desactivar()
        {
            desactivarSoloTexto();
            RegistroKey.SetValue("Start", 4);
            ServiceController service = new ServiceController(NombreServicio);
            service.Stop();
        }

        public void activar()
        {
            activarSoloTexto();
            RegistroKey.SetValue("Start", 3);
            ServiceController service = new ServiceController(NombreServicio);
            service.Start();
        }

        public void desactivarSoloTexto()
        {
            Estado = false;
            EstadoTexto = "Desactivado";
        }

        public void activarSoloTexto()
        {
            Estado = true;
            EstadoTexto = "Activado";
        }

        public void toggle()
        {
            if (Estado)
                desactivar();
            else
                activar();
        }

    }
}
