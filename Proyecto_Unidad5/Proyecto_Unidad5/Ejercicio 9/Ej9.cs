using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej9
    {
        public void arrayUser()
        {
            Console.WriteLine("!Ejercicio 9!\n" +
                              "======================================");

            int[] nums = new int[4];

            int aux = 0;

            Console.WriteLine("Inserte 4 numeros enteros:");

            while (aux < 4)
            {
                if (int.TryParse(Console.ReadLine(), out nums[aux]))
                    aux++;
                else
                    Console.WriteLine("Lo que ha introducido no es un numero!");
            }

            Console.WriteLine("Ha introducido los siguentes numeros: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Numero : {0} en posicion : {1}",nums[i],i);
            }


            Menu menu = new Menu();
            menu.Ejercicios();
        }
    }
}
