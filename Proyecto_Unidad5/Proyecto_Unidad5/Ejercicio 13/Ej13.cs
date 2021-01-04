using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej13
    {
        public void PosUserAr()
        {
            Console.Write("Escriba el tamaño de la Array: ");
            string taman = Console.ReadLine();
            int i = Convert.ToInt32(taman);
            int[] aux = new int[i];
            Random rand = new Random();
            
            
            for (int a = 0; a < i; a++)
            {              
                int g = rand.Next(1,10);
                aux[a] = g;
            }

            
            foreach (var item in aux)
                Console.WriteLine(item);

            Menu menu = new Menu();
            menu.Ejercicios();
        }
    }
}
