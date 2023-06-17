namespace trailingzeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("The number of trailing zeroes are :-" + trailingzeroes(number1));
            Console.ReadLine();
            }

        static int trailingzeroes(int n)

        {
            int number = 0;

            for (int i = 5; n / i >= 1; i *= 5)
            {
                number+= n / i;
            }

            //while (n > 0)
            //{
            //    number += n / 5;
            //    n /= 5;
            //}
            return number;

        }
    }
}