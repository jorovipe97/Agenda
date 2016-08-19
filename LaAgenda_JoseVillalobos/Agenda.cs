using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Agenda
{

    Usuario[] usuarios = new Usuario[5];

    public Agenda()
    {
        usuarios[0] = new Usuario("John", 20, 1);
        usuarios[1] = new Usuario("Carl", 25, 2);
        usuarios[2] = new Usuario("Josh", 30, 3);
        usuarios[3] = new Usuario("John", 20, 1);
        usuarios[4] = new Usuario("Carl", 25, 2);
    }

    public void VerDatos()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("La agenda");
        Console.ResetColor();
        foreach (Usuario user in usuarios)
        {
            string datos = user.ObtenerInformacion();
            Console.WriteLine(datos);
        }
        Console.WriteLine("");
    }

    /// <summary>
    /// Modifica la edad del usuario con la cedula especificada
    /// </summary>
    /// <param name="cedula">Cedula del usuario a modificar</param>
    /// <param name="edad">Edad que se desea poner al user</param>
    public void ModificarEdad(int cedula, int edad)
    { 
        foreach(Usuario user in usuarios)
        {
            if (user.ObtenerCedula() == cedula)
                user.ModificarEdad(edad);
        }
    }

    /// <summary>
    /// Modifica el nombre del usuario con la cedula especificada
    /// </summary>
    /// <param name="cedula">Cedula del usuario a modificar</param>
    /// <param name="edad">Nombre que se desea poner al user</param>
    public void ModificarNombre(int cedula, string nombre)
    {
        foreach (Usuario user in usuarios)
        {
            if (user.ObtenerCedula() == cedula)
                user.ModificarNombre(nombre);
        }
    }

    /// <summary>
    /// Calcula el promedio de edades de todos los usuarios de la agenda
    /// </summary>
    /// <returns>El promedio de los usuarios de la agenda</returns>
    public float CalcularPromedio()
    { 
        int sum = 0;
        foreach (Usuario user in usuarios)
        {
            sum += user.ObtenerEdad();
        }

        return sum / usuarios.Length;
    }

    /// <summary>
    /// Devuelve los datos de los usuarios repetidos
    /// </summary>
    /// <returns>Lista de los usuarios repetidos</returns>
    public List<string> BuscarRepetidos()
    {
        List<string> usuariosRepetidos = new List<string>();

        for (int i = 0; i < usuarios.Length; i++)
        {
            for (int j = i+1; j < usuarios.Length; j++)
            {
                if (usuarios[i].ObtenerCedula() == usuarios[j].ObtenerCedula())
                {
                    usuariosRepetidos.Add( usuarios[i].ObtenerInformacion() );
                    //Console.WriteLine(usuarios[i].ObtenerInformacion() + " Esta repetido");
                }
            }
        }

        return usuariosRepetidos;
    }
}