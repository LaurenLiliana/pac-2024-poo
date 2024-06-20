using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    class Bebida
    {
        //Propiedades: Donde se almacena la informacion
        public string Nombre { get; set; }

        public int Cantidad { get; set; }   

        //Constructor: Establece la informacion guardada en este caso Nombre
        public Bebida(string Nombre, int Cantidad) 
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
        public void Beberse(int CuantoBebio) 
        {
            this.Cantidad -= CuantoBebio;
        }
    }
}
