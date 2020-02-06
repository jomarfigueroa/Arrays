using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Jomar F<jomar@mail.usf.edu>

4:50 AM(12 hours ago)


to me
namespace ArraysDeliverable
    {
        class Program
        {
            static void Main(string[] args)
            {
                // just saying it's a program for an array
                Console.WriteLine("This is a console program for arrays. Sit back, and relax."); // just to introduce to the program

                try
                {


                    Console.WriteLine("This array will be populated and executed automatically, there will be 25 elements."); // just elaborating

                    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 }; // 25 element array created

                    foreach (int i in numbers) // This will display the required explanation for each element in the array
                    {
                        Console.Write("Element Value = " + i + " " + "\n"); // new line at the end
                    }
                    Console.WriteLine("Press any key to exit the program..."); // end program
                    Console.ReadKey(true);


                }
                catch // not needed but I like to do try catch
                {
                    Console.WriteLine("error");
                    Console.ReadKey();
                }
            }
        }
    }
    // end of program
}
    }
}
