namespace vehicals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Imovable> imovables = new List<Imovable> {
            new Car(),
            new Plane()
            };

            foreach (Imovable imovable in imovables) { imovable.Move(); }
        }
    }
}
