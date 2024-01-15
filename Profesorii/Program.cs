using Profesorii;
using Profesorii.Liceul.Service;
using Profesorii.Profesor.service;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Selectati ce doriti: ");
        View view = new View();
        view.play();
    }
}
