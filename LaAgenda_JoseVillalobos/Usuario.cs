using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Usuario
{
    private string nombre;
    private int cedula;
    private int edad;

    public Usuario(string _nombre, int _edad, int _cedula)
    {
        nombre = _nombre;
        cedula = _cedula;
        ModificarEdad(_edad);
    }

    /// <summary>
    /// ¿Para que serviria un constructor estatico?
    /// </summary>
    static Usuario()
    { }

    public string ObtenerInformacion()
    {
        string datos = "Nombre: " + nombre + " | C.C: " + cedula + " | Edad: " + edad;
        return datos;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }

    public int ObtenerCedula()
    {
        return cedula;
    }

    public int ObtenerEdad()
    {
        return edad;
    }

    public void ModificarEdad(int _edad)
    {
        edad = _edad;
        if (edad < 0)
        {
            edad = 0;
        }

        if (edad > 120)
        {
            edad = 120;
        }
    }

    public void ModificarNombre(string _nombre)
    {
        nombre = _nombre;
    }

}


