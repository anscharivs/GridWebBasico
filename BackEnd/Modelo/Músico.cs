using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelo
{
    public class Músico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Instrumento { get; set; }
        public int LugarNacimiento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaMuerte { get; set; }
    }
}
