using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej12
    {
        public void arrayPosMedia()
        {
            Console.WriteLine("!Ejercicio 12!\n" +
                              "======================================");

            int[] nums = { 56, 67, 54, 23, 47, 70, 87, 1, 12, 3 };
            long media = 0;


            for (long i = 0; i < nums.Length; i++)
            {
                media += nums[i];             
            }

            media /= nums.Length;

            Console.WriteLine("La media total de los numeros fijos es: {0}", media);


            Menu menu = new Menu();
            menu.Ejercicios();
        }


    }
}
