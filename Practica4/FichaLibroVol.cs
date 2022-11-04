using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FichaLibroVol : FichaLibro
    {
        private int volumen;
        public int Volumen { get { return volumen; } }

        public FichaLibroVol(string referencia, string titulo, int numEjemplares, string autor, string editorial, int volumen) : base(referencia, titulo, numEjemplares, autor, editorial)
        {
            this.volumen = volumen;
        }   
    }
}
