using System;
using System.Collections.Generic;

class ListaConcepto
{
    static void Concepto()
    {
        // Crear una instancia de la clase Random
        Random random = new Random();

        // Crear una lista de enteros
        List<int> numerosAleatorios = new List<int>();

        // Definir el número de elementos en la lista
        int cantidadElementos = 10;

        // Rellenar la lista con números aleatorios
        for (int i = 0; i < cantidadElementos; i++)
        {
            // Generar un número aleatorio entre 1 y 100
            int numero = random.Next(1, 101);
            numerosAleatorios.Add(numero);
        }

        // Imprimir los números aleatorios
        Console.WriteLine("Números aleatorios en la lista:");
        foreach (int numero in numerosAleatorios)
        {
            Console.WriteLine(numero);
        }
    }
}