using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
  
    public partial class Form1 : Form
    {
        public event EventHandler<AgregarComidaArgs> AgregarComida2;

        public Form1() => InitializeComponent();

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (AgregarComida2 != null)
            {
                AgregarComidaArgs comidaArgs = new AgregarComidaArgs();
                comidaArgs.nombre = nombreTextBox.Text;
                comidaArgs.proteinas = proteTextBox.Text;
                comidaArgs.grasas = grasaTextBox.Text;
                comidaArgs.carbohidratos = carboTextBox.Text;
                AgregarComida2.Invoke(sender, comidaArgs);
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {

        }

        public void AgregarComidaItem(Comida comida)
        {
            listaComidas.Items.Add(comida);
        }
    }
}
