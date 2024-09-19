using System;
using System.Collections.Generic;

public class ListaCircular
{
    public static List<int> ObtenerLista()
    {
        Random random = new Random();
        LinkedList<int> listaCircular = new LinkedList<int>();
        int cantidadElementos = 10;

        for (int i = 0; i < cantidadElementos; i++)
        {
            int numero = random.Next(1, 101);
            listaCircular.AddLast(numero);
        }

        // Conectar el último nodo al primer nodo para hacer la lista circular
        if (listaCircular.First != null)
        {
            LinkedListNode<int> primerNodo = listaCircular.First;
            LinkedListNode<int> ultimoNodo = listaCircular.Last;
            ultimoNodo.Next = primerNodo;
            primerNodo.Previous = ultimoNodo;
        }

        return new List<int>(listaCircular);
    }
}
