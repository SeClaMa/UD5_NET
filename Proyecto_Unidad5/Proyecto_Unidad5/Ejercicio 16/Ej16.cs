using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej16
    {
        static int EsCapicua(int aux)
        {
            int rev = 0;
            int rem = 0;
            int num = aux;

            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }

            if (rev == aux)
            {
                return 1;
            }

            else
            {
                return 0;
            }

                
        }

        public void Capicua()
        {
            int i = 0;

            int[] arra = new int[5] { 182, 12321, 84, 424, 271 };

            
              
            Console.WriteLine("Estos numeros son capicua : ");
            for (i = 0; i < arra.Length; i++)
            {
                if (EsCapicua(arra[i]) == 1)
                    Console.Write(arra[i] + " ");
            }
            Menu menu = new Menu();
            menu.Ejercicios();
        }

    }

    }

