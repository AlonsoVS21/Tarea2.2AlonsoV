using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese el carnet del estudiante: ");
        string carnet = Console.ReadLine();

        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        double promedioQuices = CalcularPromedio("quices");
        double promedioTareas = CalcularPromedio("tareas");
        double promedioExamenes = CalcularPromedio("exámenes");

        // Calcular porcentajes (asegurándose de que estén en el rango correcto)
        double porcentajeQuices = promedioQuices * 0.25;
        double porcentajeTareas = promedioTareas * 0.3;
        double porcentajeExamenes = promedioExamenes * 0.45;

        // Calcular promedio final
        double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

        // Determinar condición del estudiante
        string condicion = (promedioFinal >= 70) ? "Aprobado" : (promedioFinal >= 50) ? "Aplazado" : "Reprobado";

        // Mostrar resultados
        Console.WriteLine($"Carnet: {carnet}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Porcentaje de quices: {porcentajeQuices:P}");
        Console.WriteLine($"Porcentaje de tareas: {porcentajeTareas:P}");
        Console.WriteLine($"Porcentaje de exámenes: {porcentajeExamenes:P}");
        Console.WriteLine($"Promedio final: {promedioFinal:P}");
        Console.WriteLine($"Condición: {condicion}");

        // Esperar una entrada del usuario antes de cerrar la consola
        Console.ReadLine();
    }

    static double CalcularPromedio(string tipo)
    {
        double total = 0;
        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Ingrese la nota del {tipo} {i}: ");
            double nota;
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
            {
                Console.WriteLine("Por favor, ingrese una nota válida entre 0 y 100.");
                Console.Write($"Ingrese la nota del {tipo} {i}: ");
            }
            total += nota;
        }
        return total / 3 / 100; // Asegurar que el promedio esté en el rango correcto (0 a 1)
    }
}
