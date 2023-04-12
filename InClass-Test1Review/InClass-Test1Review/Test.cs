using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Test1Review
{
    public class Test
    {
        public static void Practice()
        {
            int[] arrayByOnes = new int[150];
            for (int i = 0; i < arrayByOnes.Length; i++) 
            { 
                arrayByOnes[i] = i; 
            }

            int[] arrayByFives = new int[150];
            for (int i = 0; i < arrayByFives.Length; i++)
            {
                arrayByFives[i] = i * 5 + 5;
            }

            Console.WriteLine(arrayByOnes);
            Console.WriteLine(arrayByFives);
        }
    }
}
