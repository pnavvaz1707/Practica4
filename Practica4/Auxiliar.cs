using System;
using System.Collections;
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
                    Console.Write(mensaje);
                    respuesta = Console.ReadLine();
                    if (respuesta == "")
                    {
                        throw new Exception("La cadena no puede estar vacía");
                    }
                    sigue = false;
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
                    Console.Write(msg);
                    num = Convert.ToInt32(Console.ReadLine());
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
                catch (OverflowException)
                {
                    Colores.imprimirRojo("El número introducido es demasiado alto");
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
