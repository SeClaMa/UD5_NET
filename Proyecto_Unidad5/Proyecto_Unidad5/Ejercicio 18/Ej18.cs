using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej18
    {
        public int [] aux;
        public int ArraTam;
        public void SumArrayPos()
        {
            Console.Write("Escriba el tamaño de la Array: ");
            string taman = Console.ReadLine();
            ArraTam = Convert.ToInt32(taman);
            aux = new int[ArraTam];         

        }

        public void GenNum()
        {
            int sum = 0;
            Random rand = new Random();
            for (int a = 0; a < ArraTam; a++)
            {
                int g = rand.Next(0, 9);
                aux[a] = g;
            }
            foreach (var item in aux) {
                sum += item;
                Console.WriteLine(item);
            }
            Console.WriteLine("La suma es: {0}",sum);



            Menu menu = new Menu();
            menu.Ejercicios();
        }
    }
}
