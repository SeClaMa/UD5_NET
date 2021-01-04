using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Ej1
    {
        public void calculadora() {

            Console.WriteLine("==================================");
            Console.WriteLine("Inserte el objeto geometrico:(Circulo, Triangulo, Cuadrado) ");

            String figura = Console.ReadLine();


            switch (figura)
            {
                case "Circulo" :

                    Console.WriteLine("Introduzca el Radio: ");
                    double RadioCirc = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El area de su circulo es: {0}", Math.Pow(RadioCirc, 2) * Math.PI);
                    break;

                case "Triangulo":
                    Console.WriteLine("Introduzca la base: ");
                    double TriangBase = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Introduzca la altura: ");
                    double TriangAlt = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("El area de su Triangulo es: {0}",(TriangBase*TriangAlt)/2);

                    break;

                case "Cuadrado":

                    Console.WriteLine("Introduzca el primer lado");
                    double Lado1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Introduzca el segundo lado");
                    double Lado2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("El area de su cuadrado es: {0}",Lado1*Lado2);

                    break;
                default:
                    break;
            }
            Menu menu = new Menu();
            menu.Ejercicios();
        }

    }
}
