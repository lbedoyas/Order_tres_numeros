using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Ingrese el primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine("El primer numero es el mayor {0} ",n1);
                


                if (n2>n3)
                {
                    Console.WriteLine("El segundo numero es el del medio {0} ", n2);
                    Console.WriteLine("El tercero numero es el menor {0} ", n3);
                }
                else
                {
                    Console.WriteLine("El tercero numero es del medio {0} ", n3);
                    Console.WriteLine("El segundo numero es el menor {0} ", n2);
                }
                

            }
            else
            {
                if(n2 > n1 && n2 > n3)
                {
                    Console.WriteLine("El mayor es el segundo numero {0}", n2);

                    if(n1>n3)
                    {
                        Console.WriteLine("El primer numero es el del medio {0} ",n1);
                        Console.WriteLine("El tercer numero es el menor {0} ", n3);
                    }
                    else
                    {
                        Console.WriteLine("El tercer numero es el del medio {0} ", n3);
                        Console.WriteLine("El primer numero es el menor {0} ", n1);
                    }
                }
                else
                {
                    Console.WriteLine("El mayor es el tercer numero {0}", n3);
                    if (n1 > n2)
                    {
                        Console.WriteLine("El primer numero es el del medio {0} ", n1);
                        Console.WriteLine("El segundo numero es el menor {0} ", n2);
                    }
                    else
                    {
                        Console.WriteLine("El segundo numero es el del medio {0} ", n2);
                        Console.WriteLine("El primer numero es el menor {0} ", n1);
                    }
                }


            }
            Console.ReadKey();


        }
    }
}
