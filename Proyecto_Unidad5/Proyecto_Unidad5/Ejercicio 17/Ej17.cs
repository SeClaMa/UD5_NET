using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej17
    {
        int[] arra = new int[10];

        public void ArrPosRell() {

            

            Console.WriteLine("Rellene 10 posiciones con valores Enteros: ");
            for (int i = 0; i < arra.Length; i++)
            {
                arra[i] = Convert.ToInt32(Console.ReadLine());

            }

            

        }
        public void ArrPosDec()
        {
            
            for (int i = 0; i < arra.Length; i++)
            {
                Console.WriteLine("Posicion {0}, con valor {1} ", i, arra[i]);
            }

            Menu menu = new Menu();
            menu.Ejercicios();

        }

    }
}
