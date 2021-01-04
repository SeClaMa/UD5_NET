using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej15
    {
        public void ArrayInver()
        {
            int[] lista = { 45, 12, 19, 92, 54, 82 };
            int[] temp = lista;
            Console.Write("Array de numeros NO invertidos: ");
            foreach (int i in lista)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            Array.Reverse(temp);
            Console.Write("Array de numeros Invertidos: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Menu menu = new Menu();
            menu.Ejercicios();

        }
    }
}
