using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Notas
{
     class ClaseBase
    {
        private string DireccionIP = string.Empty;
        public string fecha = string.Empty;
        public string fecha2 = string.Empty;

        public ClaseBase(string IPADRESS, string Fecha, string Fecha2 )
        {
            DireccionIP = IPADRESS;
            fecha = Fecha;
            fecha2 = Fecha2;
        }


    }
}


