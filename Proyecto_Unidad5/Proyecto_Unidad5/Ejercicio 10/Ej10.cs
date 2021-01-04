using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej10
    {
        public void tabla()
        {
            Console.WriteLine("!Ejercicio 10!\n" +
                              "======================================");

            Console.WriteLine("Escriba el numero que desea multiplicar: ");

            int num = Convert.ToInt32(Console.ReadLine());

            int[] multi = {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("===Tabla de multiplicar de {0} ===",num);
            for (int i = 0; i < multi.Length; i++)
            {
                Console.WriteLine(num*multi[i]);
            }

            Menu menu = new Menu();
            menu.Ejercicios();
        }
    }
}
