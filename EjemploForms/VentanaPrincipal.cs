﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        //Metodo para cerrar la aplicación al cerrar el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void botonVentana1(object sender, EventArgs e)
        {
            Ventana1 ventana = new Ventana1();
            ventana.Show();
        }

        private void botonVentana2(object sender, EventArgs e)
        {
            Ventana2 ventana = new Ventana2();
            ventana.Show();
        }
    }
}
