using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Pizza
    {
        public Pizza()
        {
            this.queso = new queso();
            this.masa = new masa();
        }
        public queso queso { get; set; }
        public masa masa { get; set; }
        public bebida bebida { get; set; }
    }
    public class queso
    {

    }
    public class masa
    {

    }
    public class bebida
    {
        public string soda { get; set; }
        public string jugo { get; set; }
    }
}
