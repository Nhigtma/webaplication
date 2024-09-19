using System;
using System.Collections.Generic;

public class ListaEnlazada
{
    public static List<int> ObtenerLista()
    {
        Random random = new Random();
        LinkedList<int> numerosAleatorios = new LinkedList<int>();
        int cantidadElementos = 10;

        for (int i = 0; i < cantidadElementos; i++)
        {
            int numero = random.Next(1, 101);
            numerosAleatorios.AddLast(numero);
        }

        return new List<int>(numerosAleatorios);
    }
}