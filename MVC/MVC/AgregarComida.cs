using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class AgregarComidaArgs: EventArgs
    {
        public string nombre;
        public string proteinas;
        public string grasas;
        public string carbohidratos;

    }
}
