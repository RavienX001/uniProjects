namespace temparatureInterpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input tempareture in celsius");
            float temparatute = float.Parse(Console.ReadLine());

            string status = "INVALID TEMPRETURE";

            if (temparatute < -10)
            {
                status = "Very Cold";
            }
            else if (temparatute > -10 && temparatute <= 0)
            {
                status = "Cold";
            }
            else if (temparatute > 0 && temparatute <= 10)
            {
                status = "Cool";
            }
            else if (temparatute > 10 && temparatute <= 20)
            {
                status = "Moderate";
            }
            else if (temparatute > 20)
            {
                status = "Warm";
            }
            Console.WriteLine("ohhhh... "+status);
        }

    }
}
