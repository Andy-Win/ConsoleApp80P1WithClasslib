namespace ConsoleApp80P1WithClasslib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
            Console.WriteLine("Hello from console app " + c.GetHello());
            Console.ReadKey();
        }
    }
}