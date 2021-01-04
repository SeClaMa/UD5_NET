using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej11
    {

        public void arrayPosSuma()
        {
            Console.WriteLine("!Ejercicio 11!\n" +
                              "======================================");

            int[] nums = { 56,67,54,23,47,70,87,1,12,3};
            long suma = 0;


            for (long i = 0; i < nums.Length; i++)
            {
                suma += nums[i];
            }
            
            Console.WriteLine("La suma total de los numeros fijos es: {0}",suma);


            Menu menu = new Menu();
            menu.Ejercicios();
        }
    }
}
