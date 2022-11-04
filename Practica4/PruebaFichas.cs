using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class PruebaFichas
    {
        private static string[] MENU_OPCIONES =
        {
            "Crear la ficha de un libro",
            "Crear la ficha de un libro con volumen",
            "Crear la ficha de una revista",
            "Crear la ficha de un DVD",
            "Consultar biblioteca",
            "Salir"
        };

        public static void Main(string[] args)
        {
            int opcion;
            ArrayList fichas = new ArrayList();
            do
            {
                opcion = menu();

                imprimirEncabezado(opcion);

                switch (opcion)
                {
                    case 1:
                        fichas.Add(creaFichaLibro());
                        break;

                    case 2:
                        fichas.Add(creaFichaLibroVol());
                        break;

                    case 3:
                        fichas.Add(creaFichaRevista());
                        break;

                    case 4:
                        fichas.Add(creaFichaDVD());
                        break;

                    case 5:
                        for (int i = 0; i < fichas.Count; i++)
                        {
                            Console.WriteLine(fichas[i]);
                        }
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 6);
        }

        private static FichaLibro creaFichaLibro()
        {
            string referencia, titulo, autor, editorial;
            int numEjemplares;

            referencia = Auxiliar.leerCadena("Introduce la referencia del libro");
            titulo = Auxiliar.leerCadena("Introduce el título del libro");
            numEjemplares = Auxiliar.solicitarEnteroEnUnRango(0, Int16.MaxValue, "Introduce el número de ejemplares");
            autor = Auxiliar.leerCadena("Introduce el autor del libro");
            editorial = Auxiliar.leerCadena("Introduce la editorial del libro");

            return new FichaLibro(referencia, titulo, numEjemplares, autor, editorial);
        }
        private static FichaLibroVol creaFichaLibroVol()
        {
            string referencia, titulo, autor, editorial;
            int numEjemplares, volumen;

            referencia = Auxiliar.leerCadena("Introduce la referencia del libro");
            titulo = Auxiliar.leerCadena("Introduce el título del libro");
            numEjemplares = Auxiliar.solicitarEnteroEnUnRango(0, Int16.MaxValue, "Introduce el número de ejemplares");
            autor = Auxiliar.leerCadena("Introduce el autor del libro");
            editorial = Auxiliar.leerCadena("Introduce la editorial del libro");
            volumen = Auxiliar.solicitarEnteroEnUnRango(0, Int16.MaxValue, "Introduce el volumen del libro");

            return new FichaLibroVol(referencia, titulo, numEjemplares, autor, editorial, volumen);
        }
        private static FichaRevista creaFichaRevista()
        {
            string referencia, titulo, fechaPublicacion;
            int numEjemplares, numRevista;

            referencia = Auxiliar.leerCadena("Introduce la referencia de la revista");
            titulo = Auxiliar.leerCadena("Introduce el título de la revista");
            numEjemplares = Auxiliar.solicitarEnteroEnUnRango(0, Int16.MaxValue, "Introduce el número de ejemplares");
            numRevista = Auxiliar.solicitarEnteroEnUnRango(0, Int16.MaxValue, "Introduce el número de la revista");
            fechaPublicacion = Convert.ToString(Auxiliar.solicitarEnteroEnUnRango(DateTime.Now.Year - 100, DateTime.Now.Year, "Introduce la fecha de publicación de la revista"));

            return new FichaRevista(referencia, titulo, numEjemplares, numRevista, fechaPublicacion);
        }
        private static FichaDVD creaFichaDVD()
        {
            string referencia, titulo, director, fechaProduccion;
            int numEjemplares;

            referencia = Auxiliar.leerCadena("Introduce la referencia del DVD");
            numEjemplares = Auxiliar.solicitarEnteroEnUnRango(0, Int16.MaxValue, "Introduce el número de ejemplares de DVD");
            titulo = Auxiliar.leerCadena("Introduce el título del DVD");
            director = Auxiliar.leerCadena("Introduce el director del DVD");
            fechaProduccion = Convert.ToString(Auxiliar.solicitarEnteroEnUnRango(DateTime.Now.Year - 100, DateTime.Now.Year, "Introduce la fecha de producción del DVD"));
            ArrayList protagonistas = crearProtagonistas();
            return new FichaDVD(referencia, titulo, numEjemplares, director, fechaProduccion, protagonistas);
        }


        private static ArrayList crearProtagonistas()
        {
            ArrayList protagonistas = new ArrayList();
            bool sigue = true;
            string respuesta;
            do
            {
                Console.WriteLine("Introduce un actor protagonista");
                protagonistas.Add(Console.ReadLine());
                sigue = continuarBucle("¿Desea introducir otro actor?");

            } while (sigue);
            return protagonistas;
        }

        private static bool continuarBucle(string msg)
        {
            bool sigueBucle = null;
            bool siguePreguntando = true;
            string respuesta;
            while (siguePreguntando)
            {
                try
                {
                    Console.WriteLine(msg);
                    respuesta = Console.ReadLine().ToLower();
                    if (respuesta.Equals("si") || respuesta.Equals("sí"))
                    {
                        siguePreguntando = false;
                        sigueBucle = true;
                    }
                    else if (respuesta.Equals("no"))
                    {
                        siguePreguntando = false;
                        sigueBucle = false;
                    }
                    else
                    {
                        throw new Exception("Debe introducir un si o un no");
                    }
                }
                catch (Exception e)
                {
                    Colores.imprimirRojo(e.Message);
                }
            }
            return sigueBucle;

        }

        private static int menu()
        {
            Console.Clear();
            Colores.imprimirVerde("\n\t\t----- GESTIÓN BIBLIOTECA -----\n");
            Console.WriteLine("Elija el tipo de Ficha a crear");
            crearMenu();
            return Auxiliar.solicitarEnteroEnUnRango(1, MENU_OPCIONES.Length, "Seleccione una opción");
        }
        private static void crearMenu()
        {
            for (int i = 0; i < MENU_OPCIONES.Length; i++)
            {
                Colores.imprimirAzul((i + 1) + ". " + MENU_OPCIONES[i]);
            }
        }

        private static void imprimirEncabezado(int respuesta)
        {
            Console.Clear();
            Colores.imprimirAzul("Has seleccionado " + MENU_OPCIONES[respuesta - 1]);
        }
    }
}
