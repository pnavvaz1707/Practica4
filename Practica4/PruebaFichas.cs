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
            "Salir"
        };

        public static void Main(string[] args)
        {
            bool sigue = true;

            int opcion;

            Colores.imprimirVerde("\n\t\t----- GESTIÓN BIBLIOTECA -----\n");
            Console.WriteLine("Elija el tipo de Ficha a crear");

            while (sigue)
            {
                opcion = menu();

                imprimirEncabezado(opcion);

                switch (opcion)
                {
                    case 1:
                        creaFichaLibro();
                        break;

                    case 2:
                        creaFichaLibroVol();
                        break;

                    case 3:
                        creaFichaRevista();
                        break;

                    case 4:
                        creaFichaDVD();
                        break;

                    case 0:
                        sigue = false;
                        break;
                }
            }
        }

        private static FichaLibro creaFichaLibro()
        {
            string referencia, titulo, autor, editorial;
            int numEjemplares;
            return new FichaLibro(referencia, titulo, numEjemplares, autor, editorial);
        }
        private static FichaLibroVol creaFichaLibroVol()
        {
            string referencia, titulo, autor, editorial;
            int numEjemplares, volumen;
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

            ArrayList protagonistas = Auxiliar.;
            return new FichaDVD(referencia, titulo, numEjemplares, director, fechaProduccion, protagonistas);
        }

        private static int menu()
        {
            Console.Clear();
            crearMenu();
            return Auxiliar.solicitarEnteroEnUnRango(0, MENU_OPCIONES.Length, "Seleccione una opción");
        }
        private static void crearMenu()
        {
            for (int i = 0; i < MENU_OPCIONES.Length - 1; i++)
            {
                Colores.imprimirAzul((i + 1) + ". " + MENU_OPCIONES[i]);
            }
            Colores.imprimirAzul("0. " + MENU_OPCIONES[MENU_OPCIONES.Length - 1]);

        }

        private static void imprimirEncabezado(int respuesta)
        {
            Console.Clear();
            Colores.imprimirAzul("Has seleccionado " + MENU_OPCIONES[respuesta - 1]);
        }
    }
}
