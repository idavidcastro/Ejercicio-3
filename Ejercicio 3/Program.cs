using System;

namespace Ejercicio_3
{
    class Program
    {
        /*
            Entrada:  Nombre, numero de cuenta y saldo de apertura.
            Proceso: Segun la gestión a realizar.
            Salida: Consultar el saldo con el que queda la cuenta.
        */
        static void Main(string[] args)
        {

            int op;
            string nombre;
            int nCuenta;
            double saldoAper = 0, saldoDisp = 0;

            Console.Write("Ingrese su nombre: ");
            try
            {
                nombre = Console.ReadLine();
            }
            catch (FormatException e) {
                nombre = "Usuario Desconocido\n";
            }
            Console.Write("Ingrese su número de cuenta: ");
            try
            {
                nCuenta = int.Parse(Console.ReadLine());
            }
            catch (FormatException e) {
                Console.Write("ERROR!! El número de cuenta es inválido. Por lo tanto, su valor será 12345.\n");
                nCuenta = 0;
            }
            while (nCuenta < 0) {
                Console.Write("Ingrese su número de cuenta correctamente (A partir de dígitos >=0): ");
                nCuenta = int.Parse(Console.ReadLine());
            }

            string seguir;
            do
            {
                Console.Write("Ingrese el saldo de apertura: ");
                try
                {
                    saldoAper = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.Write("ERROR!! El saldo de apertura es inválido. Por lo tanto, su valor será 1.000.\n");
                    saldoAper = 1000;
                }
                while (saldoAper < 0) {
                    Console.Write("Ingrese el saldo de apertura correctamente (Dígitos >0): ");
                    saldoAper = Convert.ToDouble(Console.ReadLine());
                }

                Console.Write("\n¿QUÉ GESTIÓN DESEA REALIZAR?\n");
                Console.Write("1 - Consignar a mi cuenta\n");
                Console.Write("2 - Retirar dinero de mi cuenta\n");
                Console.Write("3 - Consultar Saldo\n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        saldoDisp = saldoDisp + saldoAper;
                        Console.Write("\nEl dinero se ha consignado a su cuenta correctamente! ");
                        break;
                    case 2:
                        saldoDisp = saldoDisp - saldoAper;
                        Console.Write("\nEl dinero se ha retirado de su cuenta correctamente! ");
                        break;
                    case 3:
                        Console.Write("\nSu nombre es: {0}", nombre);
                        Console.Write("\nSu número de cuenta es: {0}", nCuenta);
                        Console.Write("\nEl saldo disponible es: {0}", saldoDisp);
                        break;
                    default:
                        Console.Write("Elija una opción válida"); break;
                }

            Console.Write("\n¿Desea realizar otra gestión? S/N\n");
            seguir= Console.ReadLine();

            } while (seguir.ToUpper().Equals("S"));

            Console.Write("\n¡¡GRACIAS POR USAR NUESTRO SERVICIO!!\n");
        }
    }
}

    
