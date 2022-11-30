using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatClassProject
{
    public class Kat
    {
        public string Farve { get; set; }

        public Kat(string farve)
        {
            Farve = farve;
        }
        public string changeColor()
        {
            return "gul";
        }
    }
}
