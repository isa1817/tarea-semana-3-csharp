using System;

namespace RegistroEstudiante
{
    // Clase que representa a un estudiante
    public class Estudiante
    {
        // Propiedades (datos) del estudiante
        // Se inicializan con string.Empty para evitar advertencias de null
        public string Id { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;

        // Array para almacenar EXACTAMENTE 3 teléfonos (requisito de la tarea)
        public string[] Telefonos { get; set; } = new string[3];

        // Método para mostrar los datos del estudiante en consola
        public void MostrarDatos()
        {
            Console.WriteLine("\n===== DATOS DEL ESTUDIANTE =====");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");

            // Recorremos el arreglo de teléfonos con un bucle for
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Registro de Estudiante (C#) ===");

            // Creamos un objeto de la clase Estudiante
            Estudiante estudiante = new Estudiante();

            // Solicitamos datos por consola
            Console.Write("Ingrese el ID del estudiante: ");
            estudiante.Id = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese los nombres: ");
            estudiante.Nombres = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese los apellidos: ");
            estudiante.Apellidos = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese la dirección: ");
            estudiante.Direccion = Console.ReadLine() ?? string.Empty;

            // Ingreso de teléfonos (array de tamaño fijo: 3)
            for (int i = 0; i < estudiante.Telefonos.Length; i++)
            {
                Console.Write($"Ingrese el teléfono {i + 1}: ");
                estudiante.Telefonos[i] = Console.ReadLine() ?? string.Empty;
            }

            // Mostramos los datos ingresados
            estudiante.MostrarDatos();

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
