using System;
using System.Collections.Generic;
using System.Text;

namespace examen_parcial
{
    class Menu_principal
    {
        public static void menu_cajero()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Cajero\n1-modo de dispensacion\n2-retirar dinero\n3-Salir\nselecciona una opcion\n");
                int opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        dispensador dispensador = new dispensador();
                        dispensador.cajero();
                        break;

                    case 2:
                        dispensador.retiro3();

                        break;

                    case 3:
                        Console.WriteLine("Pase buen dia");
                        Console.ReadKey();
                        
                        break;
                    default:
                        Console.WriteLine("Escribe una opcion valida");
                        menu_cajero();

                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Escribe una opcion valida");
                Console.ReadKey();


            }
            }





        }

    }

