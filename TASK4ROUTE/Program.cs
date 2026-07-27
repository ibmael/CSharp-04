namespace TASK4ROUTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"Task 1: {prices[1]}");
            Console.WriteLine();
            #endregion
            #region Task 2
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine($"Task 2: {shelfCopies[1, 0]}");
            Console.WriteLine();
            #endregion
            #region Task 3
            PrintWelcomeMessage();
            Console.WriteLine();
            #endregion
            #region Task 4
            PrintBookTitle("Clean Code");
            Console.WriteLine();
            #endregion
        #region Task 5
        int pages5 = 400;
        AddBonusPages(pages5);
        Console.WriteLine($"Task 5: {pages5}");
            Console.WriteLine();
            #endregion
            #region Task 6
            double[] prices6 = { 25.5, 40.0 };
            ApplyDiscount(prices6);
            Console.WriteLine($"Task 6: {prices6[0]}");
            Console.WriteLine();
            #endregion
            #region Task 7
            int pages7 = 400;
            AddBonusPagesByRef(ref pages7);
            Console.WriteLine($"Task 7: {pages7}");
            Console.WriteLine();
            #endregion

        }
        //Task 03
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Task 3: Welcome to the Library!");
        }
//Task 04
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Task 4: Book title: {title}");
        }
//Task 05
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
//Task 06
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        //Task 07
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
    }
}
