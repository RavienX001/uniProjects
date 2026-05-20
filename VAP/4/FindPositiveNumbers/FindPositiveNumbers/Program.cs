namespace FindPositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number:   ");
            int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception("Error!!!!!  Its a negetive number");
                }
                else { 
                    Console.WriteLine(number + " is Accepted!");
                        }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
