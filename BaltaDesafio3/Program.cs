internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da gasolina: ");
        float gas = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor do álcool: ");
        float alc = float.Parse(Console.ReadLine());
        float rel = alc / gas;
        if (rel <= 0.72)
        {
            Console.WriteLine("Use álcool.");
        }
        else
        {
            Console.WriteLine("Use gasolina.");
        }
    }
}