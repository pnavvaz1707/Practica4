using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FichaLibro : Ficha
    {
        private string autor;
        private string editorial;

        public string Autor { get { return autor; } }
        public string Editorial { get { return editorial; } }

        public FichaLibro(string referencia, string titulo, int numEjemplares, string autor, string editorial) : base(referencia, titulo, numEjemplares)
        {
            this.autor = autor;
            this.editorial = editorial;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Referencia: " + Referencia);
            Console.WriteLine("Título....: " + Titulo);
            Console.WriteLine("Ejemplares: " + NumEjemplares);
            Console.WriteLine("Autor.....: " + Autor);
            Console.WriteLine("Editorial.: " + Editorial);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
