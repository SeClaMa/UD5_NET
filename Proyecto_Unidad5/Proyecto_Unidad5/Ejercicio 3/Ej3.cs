using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej3
    {

        public void PrimeNum()
        {
            Console.WriteLine("Introduzca el numero: ");

            int primo = 0, num;
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < (num+1); i++)
            {
                if (num % i == 0)
                {
                    primo++;
                }
            }

            if (primo != 2)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }

            Menu menu = new Menu();
            menu.Ejercicios();


        }

    }
}
