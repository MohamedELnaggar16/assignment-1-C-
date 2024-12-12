using System;

namespace assignment_1_C_
{
    internal class Program
    {    
        static void Main(string[] args)
        {

            #region question one
            Console.Write("Please enter a number: ");

            string number = Console.ReadLine();

            Console.WriteLine($"You entered: {number}");
            #endregion

            #region question two
          
             int x = 4 ;
             int y = 9;  
             y = x;  // we equal y = x = 4
            Console.WriteLine(y);
            // the value of y = 9 is stored in stack but not used
            #endregion

            #region question three
            Point p1 = new Point();
            Point p2 = new Point();
            p2 = p1;
            p1.x = 10;
            Console.WriteLine(p2.x);
            // answer will equal 10 bect we equaled p2 to p1 and now
            // the address of p2 in stack will allocat to value of p1 in heap
            //  value of p2 in heap will be unreachable
            #endregion


        }
    }
}