using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej20
    {

        public int[] aux;
        public int[] aux2;
        public int ArraTam;
        public int ArraTam2;
        public void GenArrUno()
        {
            Random rand = new Random();


            Console.Write("Escriba el tamaño de la Primera Array: ");
            string taman = Console.ReadLine();
            ArraTam = Convert.ToInt32(taman);
            aux = new int[ArraTam];

            Console.Write("Escriba el tamaño de la Segunda Array: ");
            string taman2 = Console.ReadLine();
            ArraTam2 = Convert.ToInt32(taman2);
            aux2 = new int[ArraTam2];

            for (int a = 0; a < ArraTam; a++)
            {
                int g = rand.Next(1, 100);
                aux[a] = g;
                for (int b = 0; b < ArraTam2; b++)
                {
                    aux2[b] = g;
                }
            }

            int[] auxNew = new int[ArraTam];

            for (int c = 0; c < ArraTam; c++)
            {
                int g = rand.Next(100, 200);
                auxNew[c] = g;
            }

            foreach (var item in aux) { 
                Console.WriteLine(item); 
            }
            Console.WriteLine("=================");
            foreach (var item in aux2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================");
            foreach (var item in auxNew)
            {
                Console.WriteLine(item);
            }


        }

        public void ArrMult()
        {
            int MulAux = 0;

            for (int i = 0; i < ArraTam; i++)
            {
                for (int j = 0; j < ArraTam2; j++)
                {
                    MulAux = aux[i] * aux2[j];                  
                }
                Console.WriteLine("Multiplicacion de posicion {0} es : {1}", i, MulAux);
            }

            Menu menu = new Menu();
            menu.Ejercicios();
        }
    }
}
