using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Defining array with 10 size ▼
            int[] numbers = new int[10];

            // ▼ Defining array members with for loop ▼
            for (int i = 0; i < numbers.Length; i++)
            {
                
                numbers[i] = i+1;
            }

            // ▼ Iteration array members with foreach loop ▼
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // ▼ Adding new 11. member to array - For this I need to copy first array and define new size 11 array cause of fix size of 10 ▼
            Console.Write("Please write your value to add to this array?:");
            int userInput=Convert.ToInt32(Console.ReadLine());

            // ▼ Copying first array with 11 size ▼
            int[] newSizeArray=new int[numbers.Length+1];
            Array.Copy(numbers, newSizeArray, numbers.Length);

            // ▼ Adding member userinput to array ▼
             newSizeArray[newSizeArray.Length-1]=(userInput);
            

            // ▼ Ordering and writing members smaller to bigger in array ▼
            Array.Sort(newSizeArray);
            for (int i = 0; i < newSizeArray.Length; i++)
            {
                Console.WriteLine($"{i+1}.member of array:{newSizeArray[i]}");
            }
        }
    }
}
