using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Multidimensional Arrays are arrays containing multiple arrays rather than individual elements

            String[,] sentence = new string[3, 5] {
                {"Hello","my","name","is", "Lin-z"},
                {"I","am","27","years", "old"},
                {"I","was","born","in","October"}
                };
            //sentence is a multidimensional rectangular array containing 3 more arrays
            //3 equals the number of rows (arrays) and 5 is the number of columns (elements in each array)


            //can also declare individual 'quadrants' by stating:
            //sentence[2, 3] = "in";



            //nested for loops
            //first loop is for the rows or x axis
            //GetLength is used since this is a rectangular array (not a jagged array)
            //GetLength(0) is used here because this is referring to the first element in the array sentence (which in turn represents the 3 arrays of text)
            for (int rows = 0; rows < sentence.GetLength(0); rows++)
            {
                //second loop is for each column or y axis
                //GetLength(1) is used because now we are referring to the second element in the array sentence (representing the 5 columns of text)
                Console.WriteLine(" ");
                for (int columns = 0; columns < sentence.GetLength(1); columns++)
                {
                    //print out word at specific index for row and column
                    Console.WriteLine(sentence[rows, columns]);
                }
            }


            Console.WriteLine(" ");
            //this just prints out an example of what information is found at a given 'quadrant' or row/column
            Console.WriteLine("Sentence[2,3] is: " + sentence[2, 3]);


            //Jagged arrays
            string[][] newSentence = new string[3][];
            newSentence[0] = new string[3] { "This", "is", "a" };
            newSentence[1] = new string[2] { "jagged", "array" };
            newSentence[2] = new string[7] { "each", "row", "can", "have", "different", "column", "lengths" };


            Console.WriteLine("newSentence [2][3] is: " + newSentence[2][3]);
            Console.ReadKey();


        }
    }
}
