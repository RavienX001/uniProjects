namespace EmloyeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.SetDetails("k", 200000);
            emp1.DisplayDetails();
        }
    }
}
