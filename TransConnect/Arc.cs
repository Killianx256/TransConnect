using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOURNIER_LOPES
{
    public class Arc
    {
        public string source;
        public string destination;
        public int distance;

        ///Ville source
        public string Source
        {
            get { return source; }
            set {  source = value; }
        }

        ///Ville destination
        public string Destination
        { 
            get { return destination; } 
            set { destination = value; }
        }

        ///Distance entre les villes permettant une pondération
        public int Distance
        {
            get { return distance; }
            set {distance = value; }
        }
    }
}
