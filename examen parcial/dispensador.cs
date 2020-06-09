using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace examen_parcial
{
    class dispensador
    {

        public static int b1, b2, b3, b4, op3;
        public static int billetes;
        

        public void cajero()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1- 200,1000\n2- 100,500\n3- eficiente\nSelecciona una opcion:\n");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {

                    case 1:
                        Console.WriteLine("escribe un monto:");
                        billetes = int.Parse(Console.ReadLine());
                        if (billetes % 5 == 0)
                        {                                                       
                            b2 = billetes / 1000;
                            billetes = billetes - (b2 * 1000);
                            b1 = billetes / 200;
                            billetes = billetes - (b1 * 200 - 1000);

                            Console.WriteLine("se le entrego " + b1 + " de 200 y " + b2 + " de 1000 ");
                            Console.ReadKey();
                            Menu_principal.menu_cajero();
                        }
                        else
                        {
                            Console.WriteLine("Monto no valido");
                            Console.ReadKey();
                            cajero();

                        }

                        break;
                    case 2:
                        Console.WriteLine("escribe un monto:");
                        billetes = int.Parse(Console.ReadLine());
                        if (billetes % 5 == 1)                            
                        {

                            b4 = billetes / 500;
                            billetes = billetes - (b4 * 500);

                            b3 = billetes / 100;
                            billetes = billetes - (b3 * 100);



                            Console.WriteLine("se le entrego " + b3 + " de 100 y " + b4 + " de 500 ");
                            Console.ReadKey();
                            Menu_principal.menu_cajero();
                        }
                        else
                        {
                            Console.WriteLine("Monto no valido");
                            Console.ReadKey();
                            cajero();

                        }
                       
                        break;

                    case 3:
                        Console.WriteLine("escribe un monto:");                       
                        billetes = int.Parse(Console.ReadLine());
                        if (billetes % 200 == 0)
                        {
                            b2 = billetes / 1000;
                            billetes = billetes - (b2 * 1000);
                            b1 = billetes / 200;
                            billetes = billetes - (b1 * 200 - 1000);
                            Console.WriteLine("se le entrego " + b1 + " de 200 y " + b2 + " de 1000 ");
                            Console.ReadKey();
                            Menu_principal.menu_cajero();
                        }
                        else
                        {
                            b4 = billetes / 500;
                            billetes = billetes - (b4 * 500);
                            b3 = billetes / 100;
                            billetes = billetes - (b3 * 100);
                            Console.WriteLine("se le entrego " + b3 + " de 100 y " + b4 + " de 500 ");
                            Console.ReadKey();
                            Menu_principal.menu_cajero();
                        }

                        Menu_principal.menu_cajero();
                       
                        break;

                    default:
                        cajero();
                        break;


                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Escribe una opcion valida");
                Console.ReadKey();
                cajero();

            }

        }
       
        
        public static void retiro3()
        {
            Console.WriteLine("escribe un monto:");
            billetes = int.Parse(Console.ReadLine());
            if (billetes % 200 == 0)
            {
                b2 = billetes / 1000;
                billetes = billetes - (b2 * 1000);
                b1 = billetes / 200;
                billetes = billetes - (b1 * 200 - 1000);
                Console.WriteLine("se le entrego " + b1 + " de 200 y " + b2 + " de 1000 ");
                Console.ReadKey();
                Menu_principal.menu_cajero();
            }
            else
            {
                b4 = billetes / 500;
                billetes = billetes - (b4 * 500);
                b3 = billetes / 100;
                billetes = billetes - (b3 * 100);
                Console.WriteLine("se le entrego " + b3 + " de 100 y " + b4 + " de 500 ");
                Console.ReadKey();
                Menu_principal.menu_cajero();
            }

            









        }
    }
}
