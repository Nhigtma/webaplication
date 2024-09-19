using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
public class OpcionesController : Controller
{
    public IActionResult Main(string opcion)
    {
        var model = new OpcionModel();
        
        switch (opcion)
        {
            case "concepto":
                model = new OpcionModel
                {
                    TituloSeleccionado = "Concepto de Lista",
                    Descripcion = "Una lista en programación es una estructura de datos que almacena una colección de elementos ordenados y accesibles por índices. Los elementos pueden ser de cualquier tipo y la lista permite realizar operaciones como agregar, eliminar y modificar elementos. Las listas son mutables en muchos lenguajes, lo que significa que se pueden cambiar después de su creación.",
                    ImagenUrl = "/img/concepto1.jpg",
                    NumerosAleatorios = ListaConcepto.ObtenerLista(),
                    TipoLista = "Lista Simple"
                };
                break;
            case "enlazada":
                model = new OpcionModel
                {
                    TituloSeleccionado = "Lista Enlazada",
                    Descripcion = "Una lista enlazada es una estructura de datos compuesta por nodos, donde cada nodo contiene un valor y una referencia (o enlace) al siguiente nodo en la secuencia. A diferencia de las listas tradicionales, que utilizan índices para acceder a los elementos, las listas enlazadas permiten una inserción y eliminación de elementos más eficiente al no requerir el desplazamiento de otros elementos. Los nodos están conectados secuencialmente y el primer nodo se llama 'cabeza' mientras que el último puede tener una referencia nula, indicando el final de la lista.",
                    ImagenUrl = "/img/enlazada1.jpg",
                    NumerosAleatorios = ListaEnlazada.ObtenerLista(),
                    TipoLista = "Lista Enlazada"
                };
                break;
            case "doble":
                model = new OpcionModel
                {
                    TituloSeleccionado = "Lista Enlazada Doble",
                    Descripcion = "Una lista doblemente enlazada es una variante de la lista enlazada en la que cada nodo contiene dos referencias: una al siguiente nodo y otra al nodo anterior. Esto permite una navegación bidireccional a través de la lista, facilitando la inserción y eliminación de elementos en cualquier posición de manera más eficiente, ya que se puede acceder tanto al nodo anterior como al siguiente. La lista doblemente enlazada consta de un nodo 'cabeza' al inicio y un nodo 'cola' al final, ambos con referencias a sus respectivos nodos vecinos.",
                    ImagenUrl = "/img/doble1.jpg",
                    NumerosAleatorios = ListaDobleEnlazada.ObtenerLista(),
                    TipoLista = "Lista Doble Enlazada"
                };
                break;
            case "circular":
                model = new OpcionModel
                {
                    TituloSeleccionado = "Lista Enlazada Circular",
                    Descripcion = "Una lista circular es una estructura de datos en la que los nodos están conectados de manera que el último nodo apunta de nuevo al primer nodo, formando un ciclo continuo. En una lista circular, no hay un final explícito, ya que el recorrido de la lista puede continuar indefinidamente desde el último nodo de vuelta al primero. Esto permite una navegación cíclica eficiente y es útil para aplicaciones que requieren recorridos repetitivos o continuos, como en el manejo de buffers o en algoritmos que necesitan recorrer elementos en un ciclo.",
                    ImagenUrl = "/img/circular1.jpg",
                    NumerosAleatorios = ListaCircular.ObtenerLista(),
                    TipoLista = "Lista Circular"
                };
                break;
            default:
                model = new OpcionModel
                {
                    TituloSeleccionado = "Selecciona una opción",
                    Descripcion = "Selecciona una opción del menú para ver la lista correspondiente.",
                    ImagenUrl = "/img/default.jpg",  // Imagen por defecto
                    NumerosAleatorios = new List<int>(),
                    TipoLista = "N/A"
                };
                break;
        }

        // Verifica si la solicitud es AJAX
        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        {
            return PartialView("_ContenidoParcial", model); // Retorna solo la vista parcial
        }
        
        // Retorna la vista completa si no es una solicitud AJAX
        return View(model);
    }
}
    public static class ListaConcepto
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

    public static class ListaEnlazada
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

    public static class ListaDobleEnlazada
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

    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    public static class ListaCircular
    {
        public static List<int> ObtenerLista()
        {
            Random random = new Random();
            Nodo cabeza = null;
            Nodo ultimo = null;
            int cantidadElementos = 10;

            for (int i = 0; i < cantidadElementos; i++)
            {
                int numero = random.Next(1, 101);
                Nodo nuevoNodo = new Nodo(numero);

                if (cabeza == null)
                {
                    cabeza = nuevoNodo;
                    ultimo = nuevoNodo;
                    cabeza.Siguiente = cabeza; // El primer nodo apunta a sí mismo
                }
                else
                {
                    ultimo.Siguiente = nuevoNodo;
                    nuevoNodo.Siguiente = cabeza;
                    ultimo = nuevoNodo;
                }
            }

            // Recorrer la lista para obtener los valores
            List<int> numerosAleatorios = new List<int>();
            Nodo actual = cabeza;
            if (actual != null)
            {
                do
                {
                    numerosAleatorios.Add(actual.Valor);
                    actual = actual.Siguiente;
                } while (actual != cabeza);
            }

            return numerosAleatorios;
        }
    }
}
