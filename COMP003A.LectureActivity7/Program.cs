/*
 * Author: Joseph Sandoval
 * Course: COMP-003A
 * Purpose: Array and List Activity Lecture
 * 
 */

using System.Dynamic;

namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Arrays");
            // arrays store a colection of data of the same type (e.g., int, string, objects, etc.)
            //array1 declaration and setting values 
            int[] array1 = new int[5]; //declare a single-dimensional array of 5 integers without values
            // you can set values to an index using the examples below:
            array1[0]= 5; //sets the value for index 0 to 5
            array1[1]= 10;// sets the value for index 1 to 10
            array1[2]= 15;// sets the value for index 2 to 15
            array1[3]= 20;// sets the value for index 3 to 20
            array1[4]= 25;// sets the value for index 4 to 25

            Console.WriteLine($"Length of array1: {array1.Length}\n"); // displays the length/size of the array; output 5

            //array2 declaration with values
            int[] array2 = new int[] { 1, 3, 5, 7, 9 }; // declares a single-dimensional array element with values 

            /* arrays are zero indexed meaning the first position starts at index 0
             * values in an array can be accessed using the syntax below:
             * arrayName [indexNumber]
             * 
             * e.g.,
             * int[] array2 = new int [] { 1, 3, 5, 7, 9 };
             * array2[0] -> returns 1
             * array2[1] -> returns 3
             * array2[2] -> returns 5
             * array2[3] -> returns 7
             * array2[4] -> returns 9d
             * array2[5] ->RUNTIME ERROR: OutOfBoundsException
             * 
             * it is important to note that arrays cannot be dynamically resiszed.
             * they are stored in sequential blocks of memory, making it extremely fast to access them
             * also you will get runtime error of OutOfBoundsException
             * when accessing an index that does not exist
             */
            Console.WriteLine("array2 Traversal");
            ArrayTraversal(array2);

            // integer array traversal
            int[] grades = new int[] { 100, 85, 92, 87, 91, 78, 89 };
            Console.WriteLine($"\ngrades Average: {GetAverage(grades)}");

            //string array traversal
            Console.WriteLine("\nstring Traversal");
            // strings are special object consisting of an array of characters
            string message = "hello";
            ArrayTraversal(message);

            SectionSeparator("Lists");
            // like arrays, lists store a collection of data with the same type (e.g., int, string, objects, etc.)
            // unlike arrays, lists are dynamic and can increase/ decrease in size.
            List<char> alphabet = new List<char>(); // declare an empty integer List
            alphabet.Add('A'); // adds the character at the end of the collection
            alphabet.Add('B'); // adds the character at the end of the collection
            alphabet.Add('C'); // adds the character at the end of the collection
            alphabet.Add('D'); // adds the character at the end of the collection
            alphabet.Add('E'); // adds the character at the end of the collection

            Console.WriteLine($"Count of alphabet: {alphabet.Count}"); // displays the count/size of the list; output 5

            // similar to arrays, you can use the syntac below:
            // listName [indexNumber] to access a specific content in the collection
            Console.WriteLine($"alphabet[0]: {alphabet[0]}");
            Console.WriteLine($"alphabet[2]: {alphabet[2]}");
            Console.WriteLine($"alphabet[4]: {alphabet[4]}");

            alphabet.Remove('C'); // removes a specific value somewhere inside the collection
            Console.WriteLine("\nContents of alphabet after removing 'C':");
            ListTraversal(alphabet);

        }

        ///<summary>
        ///Section separator method
        ///</summary>
        ///<param name="section">string input for seciton name</param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n/t/t{section} Section\n" + "".PadRight(50, '*'));
        }
        /// <summary>
        /// section separator method
        /// </summary>
        /// <param name="array"> integer array to traverse</param>
        static void ArrayTraversal(int[] array)
        {
            // you can use a for-loop or ot her looping statements for array traversals
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array at index {i}: {array[i]}");
            }
        }

        ///<summary>
        ///Array traveral
        ///</summary>
        ///<param name="array">string input</param>
        static void ArrayTraversal(string array)
        {
            //you can use a for-loop or other looping statements for array traversals
            for (int i = 0; i < array.Length;i++)
            {
                Console.WriteLine($"Array at index {i}", array[i]);
            }

        }

        ///<summary>
        ///Average grade calculator
        ///</summary>
        ///<param name="array"> Integer array input</param>
        ///<returns></returns>
        static double GetAverage(int[] array)
        {
            int runningTotal = 0;

            // if you are not planning to manipulate the contents of the array
            // you can use a foreach loop
            foreach (int item in array)
            {
                runningTotal += item; // adds the vaule of the current item to the runnnign total
            }

            return runningTotal / array.Length;// returns the average
        }

        ///<summary>
        ///List traversal using a foreach loop
        ///</summary>
        ///<param name="list">Character list input</param>
        static void ListTraversal (List<char> list)
        {
            // you can use a for each-loop or other looping statements for list traversals
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }


    }
}