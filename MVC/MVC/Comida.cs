using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class Comida
    {
        string nombre;
        string carbohidratos;
        string proteinas;
        string grasas;

        public Comida(string n, string p, string g, string c)
        {
            nombre = n;
            carbohidratos = c;
            proteinas = p;
            grasas = g;
        }

        public double calculoCalorias()
        {
            var pro = Convert.ToInt32(proteinas);
            var car = Convert.ToInt32(carbohidratos);
            var gra = Convert.ToInt32(grasas);


            int calorias = 4 * car + 4 * pro + 9 * gra;

            return calorias;
        }

        public override string ToString()
        {
            return $"{nombre} (proteinas: {proteinas}, grasas: {grasas}, carbohidratos: {carbohidratos}) calorias: {calculoCalorias()}>";
        }

    }
}
