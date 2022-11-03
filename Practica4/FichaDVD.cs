using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FichaDVD : Ficha
    {
        private string director;
        private string fechaProduccion;
        private ArrayList protagonistas;

        public string Director { get { return director; } }
        public string FechaProduccion { get { return fechaProduccion; } }
        public ArrayList Protagonistas { get { return protagonistas; } }

        public FichaDVD(string referencia, string titulo, int numEjemplares, string director, string fechaProduccion, ArrayList protagonistas) : base(referencia, titulo, numEjemplares)
        {
            this.director = director;
            this.fechaProduccion = fechaProduccion;
            this.protagonistas = protagonistas;
        }

        public override void imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
