using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjoitustyoApp
{

    public class Henkilo
    {
        public string Etunimet { get; set; }
        public string Kutsumanimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hetu { get; set; }
        public string Katuosoite { get; set; }
        public string Postinumero { get; set; }
        public string Postitoimipaikka { get; set; }

        public Toimisuhde Toimisuhde;
    


        public List<Toimisuhde> Toimisuhteet { get; set; } = new List<Toimisuhde>();

        public string ToimisuhdeTiedot
        {
            get
            {
                if (Toimisuhteet != null && Toimisuhteet.Any())
                {
                    var toimisuhde = Toimisuhteet.Last(); 
                    return toimisuhde.Alkamispaiva.ToShortDateString() + ", " + toimisuhde.Paattymispaiva.ToShortDateString() + ", " + toimisuhde.Tyonimike + ", " + toimisuhde.Yksikko;
                }
                return "Ei toimisuhdetietoja";
            }
        }


    }
}
