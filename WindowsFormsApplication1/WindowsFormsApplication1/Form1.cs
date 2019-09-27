using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cuerpo = new cuerpo();
            MessageBox.Show("Ha sido creado");

            var edificio = new Edficio();
            var propietario = new propietario();
            edificio.propietario = propietario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pizza = new Pizza();

            var bebidas = new bebida();
            pizza.bebida = bebidas;
        }
    }
}
