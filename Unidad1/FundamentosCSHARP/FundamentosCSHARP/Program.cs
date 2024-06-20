using System;
using System.Security.Cryptography.X509Certificates;
using FundamentosCSHARP.Models;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Coca Cola", 1000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);

        }

    }
}