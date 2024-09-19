using System;
using System.Collections.Generic;

class listaCircular
{
    static void Circular()
    {
        // Crear una instancia de la clase Random
        Random random = new Random();

        // Crear una lista doblemente enlazada de enteros
        LinkedList<int> listaCircular = new LinkedList<int>();

        // Definir el número de elementos en la lista
        int cantidadElementos = 10;

        // Rellenar la lista con números aleatorios
        for (int i = 0; i < cantidadElementos; i++)
        {
            // Generar un número aleatorio entre 1 y 100
            int numero = random.Next(1, 101);
            // Agregar el número a la lista
            listaCircular.AddLast(numero);
        }

        // Conectar el último nodo al primer nodo para hacer la lista circular
        if (listaCircular.First != null)
        {
            LinkedListNode<int> primerNodo = listaCircular.First;
            LinkedListNode<int> ultimoNodo = listaCircular.Last;
            // Establecer el siguiente del último nodo al primer nodo
            ultimoNodo.Next = primerNodo;
            // Establecer el previo del primer nodo al último nodo
            primerNodo.Previous = ultimoNodo;
        }

        // Imprimir los números aleatorios recorriendo la lista circular
        Console.WriteLine("Números en la lista circular:");
        if (listaCircular.First != null)
        {
            LinkedListNode<int> nodoActual = listaCircular.First;
            do
            {
                Console.WriteLine(nodoActual.Value);
                nodoActual = nodoActual.Next;
            }
            while (nodoActual != listaCircular.First); // Continuar hasta regresar al primer nodo
        }
    }
}
