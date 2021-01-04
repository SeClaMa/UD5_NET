using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej14
    {
        public void PosUserArEx()
        {
            Console.Write("Escriba el tamaño de la Array: ");
            string taman = Console.ReadLine();
            int i = Convert.ToInt32(taman);
            int[] aux = new int[i];
            Random rand = new Random();


            for (int a = 0; a < i; a++)
            {
                int g = rand.Next(1, 10);
                aux[a] = g;
            }

            Console.WriteLine("Introduzca uno de los numeros generados (1-10): \n" +
                "===========================");
            var indiq = Convert.ToInt32(Console.ReadLine());

            foreach (var item in aux)
            {
                Console.WriteLine(item);

                if (indiq.Equals(item))
                {
                    Console.WriteLine("¡Este numero esta en la Array!");
                }

            }           

            Menu menu = new Menu();
            menu.Ejercicios();
        }


    }
}
