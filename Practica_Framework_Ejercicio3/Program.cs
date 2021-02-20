using System;

namespace Practica_Framework_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombreCliente;
            double numeroCuenta =0;
            double saldo = 400000;
            double consignaciones = 0;
            double retirar = 0;
            int opcion = 0, control = 0;
            //do
            //{
            Console.WriteLine("Ingrese el nombre del cliente:");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de la cuenta:");
            numeroCuenta = double.Parse(Console.ReadLine());

            //  do
            //{
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1. Realizar consignacion");
            Console.WriteLine("2. Realizar retiro");
            Console.WriteLine("3. Ver saldo");
            Console.WriteLine("------------------------------");
            opcion = int.Parse(Console.ReadLine());
            if (opcion >= 1 && opcion < 3)
                control = 1;
            else
            {
                Console.WriteLine("Escogio una opcion incorrecta!");
                Console.WriteLine("------------------------------");
            }

            //} while (control == 0);
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Realizar consignacion");
                    consignaciones = saldo;
                    Console.WriteLine("Ingrese la consignacion");
                    consignaciones = double.Parse(Console.ReadLine());
                    if (consignaciones > saldo)
                    {
                        Console.WriteLine("Saldo insuficiente");
                        Console.WriteLine(consignaciones);
                    }
                    else
                    {
                        Console.WriteLine("Usted consigno : " + consignaciones);
                        Console.WriteLine("Consignacion Exitosa!");
                    }
                    Console.WriteLine("Su saldo disponible es: " + (saldo - consignaciones));
                    break;
                case 2:
                    Console.WriteLine("Realizar retiro");
                    Console.WriteLine("Ingrese la cantidad que desea retitar");
                    retirar = double.Parse(Console.ReadLine());
                    if (retirar > saldo)
                    {
                        Console.WriteLine("Usted desea retirar " + retirar);
                        Console.WriteLine("No se encuentra esa cantidad de dinero dispomible");
                    }
                    else
                    {
                        Console.WriteLine("Usted retiro " + retirar);
                        Console.WriteLine("Retiro exitoso!");
                    }
                    Console.WriteLine("El saldo disponible" + (saldo - retirar));
                    break;
                case 3:
                    Console.WriteLine("-Saldo disponible");
                    Console.WriteLine("El saldo disponible de la esta: " + saldo);
                    break;
                case 4:
                default:
                    Console.WriteLine("Opcion incorrecta");
                    control = 2;
                    break;

            }
            // } while (control != 2);
            ///Console.ReadLine();
        }
    }
}
