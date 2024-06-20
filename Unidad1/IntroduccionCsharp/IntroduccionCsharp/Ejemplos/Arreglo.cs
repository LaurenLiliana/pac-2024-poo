using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntroduccionCsharp.Ejemplos
{
	public class Arreglo
	{
        private int ver { get; set; } // Declarar variable

        public Arreglo(int ver) 
		{
			this.ver = ver;
		}

		public void PrintArray()
		{
			string[] nombres = {
				"Juan",
				"Maria",
				"Ruperto",
				"Petronila", 
				"Ramon"
			};

            foreach (var nombre in nombres)
            {
				Console.WriteLine("Hola " + nombre);
            }
        }

		public void PrintArrayLimit()
		{
			string[] nombres = {
				"Juan",
				"Maria",
				"Ruperto",
				"Petronila",
				"Ramon"
			};

			//int x = 0;
			//foreach (var nombre in nombres)
			//{
			//	if (x < ver)
			//	{
			//		Console.WriteLine("Hola " + nombre);
			//	}
			//	x++;
			//}

            for (int i = 0; i < ver; i++)
            {
				Console.WriteLine("Hola " + nombres[i]);
			}
        }
	}
}
