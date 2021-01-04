using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej2
    {
        public void RandomNum()
        {
            Console.WriteLine("Introduzca el primero numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Random R = new Random();

            int randomRange = R.Next(num1,num2);

            Console.WriteLine("El numero aleatorio escogido es: {0}", randomRange);
            Menu menu = new Menu();
            menu.Ejercicios();
        }
    }
}
