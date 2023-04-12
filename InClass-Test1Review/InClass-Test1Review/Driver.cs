using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Test1Review
{
    public class Driver
    {
        public static void Main()
        {
            //TwoDimArrayPractice();
            //RandomClassReview();
            //MoreDimensions();
            //Quiz12And13();
            ArraysOfDifferentTypes();
        }

        public static void TwoDimArrayPractice()
        {
            //create a new array
            int[] numbers = new int[15];

            int[,] numbers2D = new int[5, 3]; ///rows, columns

            //fill the array
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (i * 5) + 5; //5, 10, ..., 70, 75
            }

            for(int i = 0; i < numbers2D.GetLength(0); i++) //i = 0; i < numRows; i++
            {
                for (int j = 0; j < numbers2D.GetLength(1); j++) //j = 0; j < numCols; j++
                {
                    numbers2D[i, j] = i * j;
                }
            }

            //create a new array and give it initial values
            int[] numbersInit = { 3, 7, 6, 3, 8 };

            int[,] numberInit2D = { 
                                    { 3, 5, 6 },
                                    { 5, 2, 1 },
                                    { 6, 8, 2 },
                                    { 9, 0, 3 } 
                                  };

            //display the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers2D.GetLength(0); i++) //i = 0; i < numRows; i++
            {
                for (int j = 0; j < numbers2D.GetLength(1); j++) //j = 0; j < numCols; j++
                {
                    Console.Write(numbers2D[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static void RandomClassReview()
        {
            Random rand = new Random();

            int randomValue = rand.Next(); //0 to max int value (~2 billion)
            Console.WriteLine(randomValue);
            //Console.WriteLine(int.MaxValue);

            int randomValue2 = rand.Next(10); // 0, 1, ... 9 (upper bound exclusive)
            Console.WriteLine(randomValue2);

            int randomValue3 = rand.Next(5, 10); //5, 6, 7, 8, 9 (upper bound exclusive)
            Console.WriteLine(randomValue3);

            double randomValue4 = rand.NextDouble(); //0.0 ... 1.0 (upper bound exclusive)
            Console.WriteLine(randomValue4);

            double randomValue5 = rand.NextDouble() + 5; //5.0 ... 6.0 (adding shifts the range)
            Console.WriteLine(randomValue5);

            double randomValue6 = rand.NextDouble() * 5; //0.0 ... 5.0 (multiplying widens the range)
            Console.WriteLine(randomValue6);

            double randomValue7 = (rand.NextDouble() * 5) + 3; //3.0 ... 8.0 
            Console.WriteLine(randomValue7);

            double randomValue8 = (rand.NextDouble() + 3) * 5; //15.0 ... 20.0
            Console.WriteLine(randomValue8);
        }

        public static void MoreDimensions()
        {
            int[,,,] my4DArray = new int[2, 3, 6, 1];

            for(int i = 0; i < my4DArray.GetLength(0); i++)
            {
                for(int j = 0; j < my4DArray.GetLength(1); j++)
                {
                    for(int k = 0; k < my4DArray.GetLength(2); k++)
                    {
                        for(int l = 0; l < my4DArray.GetLength(3); l++)
                        {
                            my4DArray[i, j, k, l] = i + j + k + l;
                        }
                    }
                }
            }


            for (int i = 0; i < my4DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my4DArray.GetLength(1); j++)
                {
                    for (int k = 0; k < my4DArray.GetLength(2); k++)
                    {
                        for (int l = 0; l < my4DArray.GetLength(3); l++)
                        {
                            Console.WriteLine(my4DArray[i, j, k, l]);
                        }
                    }
                }
            }

            Console.WriteLine("----------------------");

            foreach(int num in my4DArray)
            {
                Console.WriteLine(num);
            }
        }

        public static void Quiz12And13()
        {
            int[,] grades = new int[5, 3]; //12.

            //grades[2, 1] = 88; //13.

            //.Length - number of items in the array, regardless of dimensions
            //.GetLength(x) - size of dimension x

            for(int i = 0; i < grades.GetLength(0); i++)
            {
                Console.WriteLine($"Please enter the grades for student {i + 1}:");
                for(int j = 0; j < grades.GetLength(1); j++)
                {
                    Console.Write($"Test {j + 1}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < grades.GetLength(0); i++) //i = 0; i < numRows; i++
            {
                Console.WriteLine($"Student {i+1}'s grades:");
                for (int j = 0; j < grades.GetLength(1); j++) //j = 0; j < numCols; j++
                {
                    Console.Write(grades[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ArraysOfDifferentTypes()
        {
            string[] names = { "Bob", "John", "Bill" };
            //object[] items = { 3, "Bob" };
        }
    }
}
