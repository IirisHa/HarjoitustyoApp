using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjoitustyoApp
{
    public class Toimisuhde
    {
        public DateTime Alkamispaiva { get; set; }
        public DateTime Paattymispaiva { get; set; }
        public string Tyonimike { get; set; }
        public string Yksikko { get; set; }
    }
}
