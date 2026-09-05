using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpBasics04
{
    internal class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        static void ReplaceArray(ref double[] prices) 
        { 
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        static bool TryGetPrice(string title, out double price) 
        { 
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            } 
            price = 0; 
            return false; 
        }
        static void PrintBookInfo(string title, int pages = 300) 
        { 
            Console.WriteLine($"Book Title: {title}, Pages: {pages}"); 
        }

        static void Main(string[] args)
        {
            #region Question01
            // 1. Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
            double[] prices = { 25.5, 40.0, 33.75 };

            Console.WriteLine(prices[1]);
            #endregion

            #region Question02
            // 2. Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] shelfCopies =
            {
                { 3, 5 },
                { 1, 4 }
            };

            Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region Question03
            // 3.Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main
            PrintWelcomeMessage();
            #endregion

            #region Question04
            // 4. Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            PrintBookTitle("Clean Code");
            #endregion

            #region Question05
            // 5. Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            // Answer:
            // I expect to see 400 because int is a value type in C#.
            // A copy of pages is passed to the method, so adding 50 changes only the copy.
            // The original pages variable remains 400.

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            #endregion

            #region Question06
            // 6.  Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?
            // Answer:
            // I expect to see 20.5 because arrays are reference types in C#. 
            // The method modifies the original array, so prices[0] changes from 25.5 to 20.5.

            double[] prices2 = { 25.5, 40.0 };
            ApplyDiscount(prices2);
            Console.WriteLine(prices2[0]);
            #endregion

            #region Question07
            // 7. Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5 ?
            // Answer:
            // I expect to see 450 because ref allows the method to modify the original variable.
            // In question 5, a copy of the value was passed, so pages remained 400.
            // With ref, the original pages variable is changed to 450.
            int pages3 = 400;
            AddBonusPagesByRef(ref pages3);
            Console.WriteLine(pages3);
            #endregion

            #region Question08
            // 8. Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.
            double[] prices4 = { 25.5, 40.0 };
            ReplaceArray(ref prices4);
            Console.WriteLine(prices4.Length);
            #endregion

            #region Question09
            // 9. Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            // price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it and print the price if found
            double price;
            if (TryGetPrice("Clean Code", out price))
            { 
                Console.WriteLine(price); 
            }
            #endregion

            #region Question10
            // 10. Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages
            PrintBookInfo("Clean Code");
            PrintBookInfo("C# in Depth", 450);
            #endregion

            #region Question11
            // 11. Using the PrintBookInfo method from the question above, call it by naming the parameters, passing pages before title.
            PrintBookInfo(pages: 500, title: "The Pragmatic Programmer");
            #endregion

        }
    }
}
