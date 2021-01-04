using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej21
    {
        public void EscArray()
        {
            Console.Write("Escriba el tamaño de la Array: ");
            string taman = Console.ReadLine();
            int i = Convert.ToInt32(taman);
            int[] aux = new int[i];
            Random rand = new Random();
            int esc;
            int Ultnum;
            bool num = false;

            for (int a = 0; a < i; a++)
            {
                int g = rand.Next(1, 300);
                aux[a] = g;
            }


            foreach (var item in aux) { 
                Console.WriteLine(item);
            }

           // do
            //{
                Console.WriteLine("Escriba el ultimo digito del numero que quiera escoger");
                esc = Convert.ToInt32(Console.ReadLine());
                for (int a = 0; a < i; a++)
                {
                    Ultnum = aux[esc] % 10;
                    Console.WriteLine(Ultnum);
            }
            


            //} while (num=false);

                

            Menu menu = new Menu();
            menu.Ejercicios();

        }
    }
}
