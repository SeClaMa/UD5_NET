using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej6
    {

        public void cifrasPov()
        {
            Console.WriteLine("!Ejercicio 6!\n" +
                              "======================================");
            Console.WriteLine("Introduzca un numero entero positivo: ");
            long num1 = Convert.ToInt64(Console.ReadLine());

            if (num1 > 0)
            {
                long num2 = Convert.ToInt64(Math.Floor(1 + Math.Log10(num1)));

                Console.WriteLine("La cantidad de numeros son: {0}", num2);
            }
            else
            {
                Console.WriteLine("El numero indicado es menor a 0, numero negativo, vuelva a ejecutar el programa\n Solo se aceptan numeros positivos");
            }
            

            Menu menu = new Menu();
            menu.Ejercicios();
        }

    }
}
