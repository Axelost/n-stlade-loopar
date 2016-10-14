using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nästlade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //övning 1
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x%2==0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("o");
                    }

                }
                Console.WriteLine();

            }
            //övning 2
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x % 2 == 0)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write("o");
                        }
                    }
                    else
                    {
                        if (i%2==0)
                        {
                            Console.Write("o");
                        }
                        else
                        {
                            Console.Write("#");
                        }
                        
                    }

                }
                Console.WriteLine();

            }

            //övning 3
            for (int i = 10; i > 0; i--)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write("#");

                }
                Console.WriteLine();

            }
            //övning 4
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x<i)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                    

                }
                Console.WriteLine();

            }
            //övning 5
            for (int i = 0; i < 7; i++)
            {
                for (int x  = 0; x < 7; x++)
                {
                    if (x==i || x+i==6)
                    {
                        Console.Write("x");

                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();

            }
            //övning 6
            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if ((x > i || x + i >6)&&(x+i<6||x<i))
                    {
                        Console.Write("-");

                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();

            } 
            */
            //övning 7
            for (int i = 0; i < 9; i++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (x+i<4||x+i>12||x-i>4||x-i<-4)
                    {
                        Console.Write("-");

                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();

            }


            Console.ReadKey();
        }
    }
}
