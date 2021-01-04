using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej8
    {
        public void arraynum()
        {
            Console.WriteLine("!Ejercicio 8!\n" +
                              "======================================");

            int[] nums = { 343, 232, 12, 9, 34, 78, 93 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Este numero {0} tiene la posicion {1}", nums[i], i+1);
            }
            
            Menu menu = new Menu();
            menu.Ejercicios();
        }
        
    }
}
