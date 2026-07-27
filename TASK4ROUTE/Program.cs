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
    }
}
