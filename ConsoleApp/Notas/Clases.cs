using System;
namespace ConsoleApp.Notas
    {
    public class Persona
    {
        // Propiedades
        public string Nombre { get; set; } // Lectura y Escrituroa
        public string Apellido { get; } // Lectura
        public string Edad { get; }

         // Constructor 
        public Persona()
        {
            Nombre = "unknown";
            Apellido = "unknown";
            Edad = "unknown";
        }

        // Constructor con argumentos
        public Persona(string NombrePersona, string ApellidoPersona, string EdadPersona)
        {
            Nombre = NombrePersona;
            Apellido = ApellidoPersona;
            Edad = EdadPersona;
        }

    }
    class TestPerson
    {
        static void Main()
        {
            // Instancia de mis objetos
            Persona per1 = new Persona();
            Persona per2 = new Persona("Maria", "Perez", "20");

           Console.WriteLine(per1.Nombre = "MeCambieElNombre-Pedro");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}
