using System;
using System.Collections.Generic;

namespace Boxing___Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object
            List<object> example = new List<object>();

            // Add the following values to the list: 7, 28, true, "chair"
            example.Add(7);
            example.Add(28);
            example.Add(true);
            example.Add("chair");

            // Loop through the list and print all values (Hint: Type Interference might help here!)
            for(int i = 0; i < example.Count; i++)
            {
                Console.WriteLine(example[i]);
            }

            // // Add all values that are int type together and output the sum
            // for(int j = 0; j < example.Count; j++)
            //     int sum = 0;
            // {
            //     if(example[j] is int)
            //     {
            //         sum += example[j];
            //     }
            // }
        }
    }
}
