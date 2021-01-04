using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej19
    {
        public int[] aux;
        public int ArraTam;

        public void GenPos()
        {
            int max = 0;
            Console.Write("Escriba el tamaño de la Array: ");
            string taman = Console.ReadLine();
            ArraTam = Convert.ToInt32(taman);
            aux = new int[ArraTam];

            Random rand = new Random();

            for (int a = 0; a < ArraTam; a++)
            {
                int g = rand.Next(1, 100);
                aux[a] = g;
               
            }


            foreach (var item in aux) { 
                Console.WriteLine(item);               
            }
            max = aux[0];

            for (ArraTam = 1; ArraTam < aux.Length; ArraTam++)
            {
                
                if (max < aux[ArraTam])
                    max = aux[ArraTam];
            }
          
            Console.WriteLine("Numero mayor en la array : " + max);


        }

        public void EsPrimo()
        {
            int i, j;
            Console.Write("Los siguentes numeros son primos: ");
            for (ArraTam = 0; ArraTam < aux.Length; ArraTam++)
            {
                i = 2;
                j = 1;
                while (i < aux[ArraTam])
                {
                    if (aux[ArraTam] % i == 0)
                    {
                        j = 0;
                        break;
                    }
                    i++;
                }

                if (j == 1)
                {
                    Console.Write(aux[ArraTam] + " ");
                }
            }

            Menu menu = new Menu();
            menu.Ejercicios();
        }
    }
}
