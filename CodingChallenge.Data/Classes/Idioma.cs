using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Vista;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        private int idIdioma;
        private string nombre;

        public int IdIdioma
        {
            set { idIdioma = value; }
            get { return idIdioma; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public Idioma()
        {
        }
        public abstract string TextoCabecera();
        public abstract string TextoListaVacia();
        public abstract string TextoLinea(ResultadosDeFigura _resultado, FormaGeometrica _forma);
        public abstract string TraducirForma(FormaGeometrica _forma, int _cantidad);
        public abstract string TextoPie(int totalFormas, decimal totalAreas, decimal totalPerimetros);
        
    }
}
