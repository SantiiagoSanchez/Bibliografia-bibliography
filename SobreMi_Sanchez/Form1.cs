using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SobreMi_Sanchez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEspañol_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "SOBRE MI";
            lblNombre.Text = "Hola! Mi nombre es Santiago Sanchez\r\n";
            lblEdad.Text = "Actualmente (2023) tengo 18 años!";
            lblArgentina.Text = "Vivo en Argentina, Cordoba Capital.";
            lblFutbol.Text = "Me gusta el Futbol, mi jugador favorito es Messi!";
            lblidioma.Text = "Cambia el idioma";
            lblSalir.Text = " CERRAR PROGRAMA";
            btEspañol.Text = "ESPAÑOL";
            btIngles.Text = "INGLES";
            btSalir.Text = "SALIR";
        }

        private void btIngles_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "ABOUT ME";
            lblNombre.Text = "Hi! My name is Santiago Sanchez\r\n";
            lblEdad.Text = "At the moment (2023) Im 18 old";
            lblArgentina.Text = "I live in Argentina, Cordoba Capital";
            lblFutbol.Text = "I like Football, my favorite player is Messi!";
            lblidioma.Text = "Change the language";
            lblSalir.Text = " CLOSE PROGRAM";
            btEspañol.Text = "SPANISH";
            btIngles.Text = "ENGLISH";
            btSalir.Text = "EXIT";
                
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
