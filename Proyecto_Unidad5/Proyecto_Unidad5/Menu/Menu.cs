using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Unidad5
{
    class Menu
    {

        public  void Ejercicios()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("¿Que ejercicio desea inspeccionar?(Tenga en cuenta los espacios, Ej: Ejercicio 1)\n" +
                "Si desea salir del programa escriba 'Salir'");
            String Ejercicio = Console.ReadLine();
            
            switch (Ejercicio)
            {
                case "Ejercicio 1":
                    Ej1 Ejerc1 = new Ej1();
                    Ejerc1.calculadora();

                    break;

                case "Ejercicio 2":
                    Ej2 Ejerc2 = new Ej2();
                    Ejerc2.RandomNum();

                    break;


                case "Ejercicio 3":
                    Ej3 Ejerc3 = new Ej3();
                    Ejerc3.PrimeNum();

                    break;

                case "Ejercicio 4":

                    Ej4 Ejerc4 = new Ej4();
                    Ejerc4.factor();

                    break;

                case "Ejercicio 5":

                    Ej5 Ejerc5 = new Ej5();
                    Ejerc5.binario();

                    break;

                case "Ejercicio 6":

                    Ej6 Ejerc6 = new Ej6();
                    Ejerc6.cifrasPov();

                    break;

                case "Ejercicio 7":

                    Ej7 Ejerc7 = new Ej7();
                    Ejerc7.convertidor();

                    break;

                case "Ejercicio 8":

                    Ej8 Ejerc8 = new Ej8();
                    Ejerc8.arraynum();

                    break;

                case "Ejercicio 9":

                    Ej9 Ejerc9 = new Ej9();
                    Ejerc9.arrayUser();

                    break;


                case "Ejercicio 10":

                    Ej10 Ejerc10 = new Ej10();
                    Ejerc10.tabla();

                    break;

                case "Ejercicio 11":

                    Ej11 Ejerc11 = new Ej11();
                    Ejerc11.arrayPosSuma();

                    break;

                case "Ejercicio 12":

                    Ej12 Ejerc12 = new Ej12();
                    Ejerc12.arrayPosMedia();

                    break;

                case "Ejercicio 13":

                    Ej13 Ejerc13 = new Ej13();
                    Ejerc13.PosUserAr();

                    break;


                case "Ejercicio 14":

                    Ej14 Ejerc14 = new Ej14();
                    Ejerc14.PosUserArEx();

                    break;

                case "Ejercicio 15":

                    Ej15 Ejerc15 = new Ej15();
                    Ejerc15.ArrayInver();

                    break;

                case "Ejercicio 16":

                    Ej16 Ejerc16 = new Ej16();
                    Ejerc16.Capicua();

                    break;

                case "Ejercicio 17":
                    Ej17 Ejerc17 = new Ej17();
                    Ejerc17.ArrPosRell();
                    Ejerc17.ArrPosDec();

                    break;

                case "Ejercicio 18":
                    Ej18 Ejerc18 = new Ej18();
                    Ejerc18.SumArrayPos();
                    Ejerc18.GenNum();

                    break;

                case "Ejercicio 19":
                    Ej19 Ejerc19 = new Ej19();
                    Ejerc19.GenPos();
                    Ejerc19.EsPrimo();

                    break;

                case "Ejercicio 20":
                    Ej20 Ejerc20 = new Ej20();
                    Ejerc20.GenArrUno();
                    Ejerc20.ArrMult();

                    break;

                case "Ejercicio 21":
                    Ej21 Ejerc21 = new Ej21();
                    Ejerc21.EscArray();

                    break;


                case "Salir":
                    Console.WriteLine("Saliendo del programa...");
                    break;

                case null:
                    Console.WriteLine("Error, no ha introducido un ejercicio existente");
                    break;
            }

        }
}
}
