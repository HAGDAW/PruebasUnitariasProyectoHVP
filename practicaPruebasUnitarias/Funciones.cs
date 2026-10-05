using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaPruebasUnitarias
{
    public class Funciones
    {
        public const string EDAD_0_MESSAGE = "Evidentemente no eres mayor de edad";
        public const string EDAD_NEGATIVE_MESSAGE = "Todavía no has nacido";
        public static bool EsMayorDeEdad(int edad)
        {
            if (edad == 0)
                throw new ArgumentException(EDAD_0_MESSAGE);
            else if (edad < 0)
                throw new ArgumentException(EDAD_NEGATIVE_MESSAGE);
            return edad >= 18;
        }
    }
}
