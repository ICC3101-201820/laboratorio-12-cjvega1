using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Controlador
    {
        public Form1 form12;
        public ListaComida comidas;

        public Controlador()
        {
            comidas = new ListaComida();
        }

        public void AgregarComidaLista(object sender, AgregarComidaArgs args)
        {
            Comida comida = new Comida(args.nombre, args.proteinas, args.grasas, args.carbohidratos);
            comidas.Agregar(comida);
            form12.AgregarComidaItem(comida);
        }

    }
}
