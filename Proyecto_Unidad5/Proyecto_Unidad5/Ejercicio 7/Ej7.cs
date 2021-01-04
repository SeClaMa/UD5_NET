using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej7
    {
        public void convertidor()
        {
            Console.WriteLine("!Ejercicio 7!\n" +
                              "======================================");
            double libras = 0.91;

            double dolares = 1.23;

            double yenes = 126.84;

            Console.WriteLine("Introduzca la cantidad de EUR a convertir en LIB, DOL y YEN: ");

            double eur = Convert.ToDouble(Console.ReadLine());

            libras *= eur;

            dolares *= eur;

            yenes *= eur;

            Console.WriteLine("La conversion ha transformado {0} EUR en: {1} LIB - {2} DOL - {3} YEN",eur,libras,dolares,yenes);

            Menu menu = new Menu();
            menu.Ejercicios();
        }


    }
}
