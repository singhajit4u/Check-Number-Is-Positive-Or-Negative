namespace Check_Number_Is_Positive_Or_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to test Positive Or Negative:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) 
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
        }
    }
}