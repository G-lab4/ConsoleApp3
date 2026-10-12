namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transactions = { 120, -50, 300, -100, 80, -200, 500, -30, 150, -400 };
            int countPositive = 0;
            int countNegative = 0;
            int sumPositive = 0;
            int sumNegative = 0;


            foreach (var item in transactions)
            {

                if (item > 0)
                {
                    Console.WriteLine("dadebitia");
                    countPositive++;  // 120
                    sumPositive += item;
                }
                else if (item == 0)
                {
                    Console.WriteLine("egeti tanxas ver sheitan");
                }
                else
                {
                    Console.WriteLine("uayofitia");
                    countNegative++;
                    sumNegative += -item;
                }
            }

            Console.WriteLine(sumPositive);
            Console.WriteLine(sumNegative);
            Console.WriteLine($"balance = {sumPositive - sumNegative}");
        }
    }
}
