using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FichaRevista : Ficha
    {
        private int numRevista;
        private string fechaPublicacion;

        public int NumRevista { get { return numRevista; } }
        public string FechaPublicacion { get { return fechaPublicacion; } }

        public FichaRevista(string referencia, string titulo, int numEjemplares, int numRevista, string fechaPublicacion) : base(referencia, titulo, numEjemplares)
        {
            this.fechaPublicacion = fechaPublicacion;
            this.numRevista = numRevista;
        }

        public override void imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
