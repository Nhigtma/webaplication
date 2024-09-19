using System;
using System.Collections.Generic;


public class ListaConcepto
{
    public static List<int> ObtenerLista()
    {
        Random random = new Random();
        List<int> numerosAleatorios = new List<int>();
        int cantidadElementos = 10;

        for (int i = 0; i < cantidadElementos; i++)
        {
            int numero = random.Next(1, 101);
            numerosAleatorios.Add(numero);
        }

        return numerosAleatorios;
    }
}