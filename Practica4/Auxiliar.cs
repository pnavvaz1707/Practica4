using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Auxiliar
    {
        public static string leerCadena(string mensaje)
        {
            bool sigue = true;
            string respuesta = null;
            while (sigue)
            {
                try
                {
                    Console.WriteLine(mensaje);
                    respuesta = Console.ReadLine();
                    if (respuesta == "")
                    {
                        throw new Exception("La cadena no puede estar vacía");
                    }
                }
                catch (Exception e)
                {
                    Colores.imprimirRojo(e.Message);
                }
            }
            return respuesta;
        }

        public static int solicitarEnteroEnUnRango(int limiteInferior, int limiteSuperior, string msg)
        {
            bool sigue = true;
            int num = 0;

            while (sigue)
            {
                try
                {
                    Console.WriteLine(msg);
                    num = Convert.ToInt16(Console.ReadLine());
                    if (num < limiteInferior || num > limiteSuperior)
                    {
                        throw new Exception("El número debe estar comprendido en el siguiente rango [" + limiteInferior + "," + limiteSuperior + "]");
                    }
                    sigue = false;
                }
                catch (FormatException)
                {
                    Colores.imprimirRojo("Debe introducir un número entero");
                }
                catch (Exception e)
                {
                    Colores.imprimirRojo(e.Message);
                }
            }
            return num;
        }
    }
}
