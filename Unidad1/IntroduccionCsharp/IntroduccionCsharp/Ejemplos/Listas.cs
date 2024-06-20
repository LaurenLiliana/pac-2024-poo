using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCsharp.Ejemplos
{
	public class Listas
	{
        public Listas()
        {
            List<string> perros = new();

            perros.Add("Ranger");
            perros.Add("Firulais");
            perros.Insert(0, "Lassie");

            foreach (var perro in perros)
            {
                Console.WriteLine(perro);
            }
        }
    }
}
