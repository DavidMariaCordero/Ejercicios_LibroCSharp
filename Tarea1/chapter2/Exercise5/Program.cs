﻿using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el cambio: ");
            double euro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el monto en dolares que desea cambiar: ");
            double dolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La cantidad de " + dolar + " dolares en euros es: " + (dolar * euro));
            
        }
    }
}
