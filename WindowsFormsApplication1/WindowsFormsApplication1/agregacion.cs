using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Edficio
    {
        public propietario propietario { get; set; }
        public string direccion { get; set; }
    }
    public class propietario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}
