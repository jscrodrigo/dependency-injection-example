namespace DI_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller(new RecepcaoService());
            var result = controller.Ola("Rodrigo");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}