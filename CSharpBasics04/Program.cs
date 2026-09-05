using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpBasics04
{
    internal class Program
    {
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

        }
    }
}
