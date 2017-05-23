using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class gastos
    {
        int identificacion;
        string nombre;
        string típo_de_Reparto;

        public int Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Típo_de_Reparto
        {
            get
            {
                return típo_de_Reparto;
            }

            set
            {
                típo_de_Reparto = value;
            }
        }
    }
}
