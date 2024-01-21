using Profesorii;
using Profesorii.Liceu.Service;
using Profesorii.Profesori.service;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Selectati ce doriti: ");
        View view = new View();
        view.play();
    }
}
