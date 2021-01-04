using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej4
    {
        public void factor()
        {
            Console.WriteLine("Escriba el numero a factorizar: ");

            int Num = Convert.ToInt32(Console.ReadLine());
            int facNum = Num;

            for (int i = Num-1; i >= 1; --i)
            {
                facNum = facNum * i;

                // Pruebas para que me restara el numero y mostrara, asi saber si he realizado el for correctamente
                //Console.WriteLine(i);
                //--i;
            }
            Console.WriteLine("El numero factorizado es: {0}", facNum);

            Menu menu = new Menu();
            menu.Ejercicios();

        }


    }
}
