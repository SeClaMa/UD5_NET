using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej5
    {
        public void binario()
        {
            int n, i;
            int[] a = new int[10];
            Console.WriteLine("Introduzca el numero a transformar en binario: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("Binario del numero introducido: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }

            Menu menu = new Menu();
            menu.Ejercicios();


        }


    }
}
