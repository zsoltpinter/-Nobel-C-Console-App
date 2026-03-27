using System;
using System.Collections.Generic;
using System.Text;

namespace Nobel
{
    class Nobel
    {
        public int EvSzam { get; set; }
        public string Tipus { get; set; }
        public string KeresztNev { get; set; }
        public string VezetekNev { get; set; }

        public Nobel(string fajlsor){
            string[] adatok = fajlsor.Split(';');
            EvSzam = int.Parse(adatok[0]);
            Tipus = adatok[1];
            KeresztNev = adatok[2];
            VezetekNev = adatok[3];
        }
    }
}
