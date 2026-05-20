namespace mathHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num1=int.Parse(Console.ReadLine()); 
            Console.WriteLine("enter another number to add to it");
            int num2 = int.Parse(Console.ReadLine());

            int answer = MathHelper.add(num1, num2);

            Console.WriteLine("answer is "+ answer);
        }
    }
}
