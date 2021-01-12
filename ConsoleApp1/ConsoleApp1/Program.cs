using System;
using System.Collections.Generic;
using System.Linq;


public class Desafio
{

    public static void Main()
    {

        int a;
        int b = 0;
        int x;
        int z;
        int c = 0;
        x = int.Parse(Console.ReadLine());
        do
        {
            z = int.Parse(Console.ReadLine());
        }

        while (x > z + 1);
        {

            for (a = x; b < z; a++)
            {

                b += a;
                c++;

            }
        }

        Console.WriteLine(c);

    }
}
