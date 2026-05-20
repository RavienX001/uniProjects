using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        bool cont = true;
        while (cont)
        {

            Console.WriteLine("input no 1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("input no 2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("input arithmatic oparator to do " +
                "to add +" +
                "to substract -" +
                "to devide /" +
                "to multiply *");

            string oparator = Console.ReadLine();

            float answer = 0;

            switch (oparator)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("cant devide by zero");
                    }
                    else
                    {
                        answer = num1 / num2;
                    }
                    break;

                default:
                    Console.WriteLine("error!! enter a valid oparator");
                    break;
            }

            Console.WriteLine("result :" + answer);

            Console.WriteLine(" calculator - press 0 to exit" +
    " press any other key continue calculations");

            string v = Console.ReadLine();

            if (v=="0") { cont = false; }
        }
    }
}