namespace ExceptionHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a num1");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a num2");
                int num2 = int.Parse(Console.ReadLine());

                int answer = num1 / num2;

                Console.WriteLine("answer is " + answer);
            }
            catch (DivideByZeroException) { 
            Console.WriteLine("cant devide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("cant devide by zero");
            }

        }
    }
}
