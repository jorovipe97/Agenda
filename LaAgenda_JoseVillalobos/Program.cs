using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();

        agenda.VerDatos();

        agenda.ModificarEdad(2, 50);
        agenda.VerDatos();

        agenda.ModificarNombre(3, "Jack");
        agenda.VerDatos();

        float promedio = agenda.CalcularPromedio();
        Console.WriteLine("Edad promedio: " + promedio);

        Console.WriteLine("\nUsuarios repetidos");
        List<string> x = agenda.BuscarRepetidos();

        foreach (string user in x)
        {
            Console.WriteLine(user);
        }


        Console.ReadLine();
    }
}