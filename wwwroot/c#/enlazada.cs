using System;
using System.Collections.Generic;

class ListaEnlazada
{
    static void Enlazada()
    {
        // Crear una instancia de la clase Random
        Random random = new Random();

        // Crear una lista enlazada de enteros
        LinkedList<int> numerosAleatorios = new LinkedList<int>();

        // Definir el número de elementos en la lista
        int cantidadElementos = 10;

        // Rellenar la lista enlazada con números aleatorios
        for (int i = 0; i < cantidadElementos; i++)
        {
            // Generar un número aleatorio entre 1 y 100
            int numero = random.Next(1, 101);
            // Agregar el número a la lista enlazada
            numerosAleatorios.AddLast(numero);
        }

        // Imprimir los números aleatorios
        Console.WriteLine("Números aleatorios en la lista enlazada:");
        foreach (int numero in numerosAleatorios)
        {
            Console.WriteLine(numero);
        }
    }
}
