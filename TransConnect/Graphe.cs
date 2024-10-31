using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FOURNIER_LOPES
{/// Classe pour créer le graphe depuis le fichier distance pour utiliser Dijkstra
    public class Graphe
    {
        public Dictionary<string, List<Arc>> ListeAdjacence { get; set; }
        public Graphe()
        {
            ListeAdjacence = new Dictionary<string, List<Arc>>();
        }

        ///Création des liaisons (arcs) entre chaque ville
        public void AjouterArc(string source, string destination, int distance)
        {
            if (!ListeAdjacence.ContainsKey(source))
                ListeAdjacence[source] = new List<Arc>();

            if (!ListeAdjacence.ContainsKey(destination))
                ListeAdjacence[destination] = new List<Arc>();

            ListeAdjacence[source].Add(new Arc { Source = source, Destination = destination, Distance = distance });
            ListeAdjacence[destination].Add(new Arc { Source = destination, Destination = source, Distance = distance });
        }
    }
}
