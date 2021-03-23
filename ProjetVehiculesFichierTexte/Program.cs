using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ProjetVehiculesFichierTexte.ClassesEtEnum;

namespace ProjetVehiculesFichierTexte
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicule> laListeDeVehicule = new List<Vehicule>();
            Vehicule unVehicule = new Vehicule();

            string path = "C:/Users/User/source/repos/ProjetVehiculesFichierTexte/ProjetVehiculesFichierTexte/ClassesEtEnum/ListeVehicules1.txt";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] uneLigne = new string[3];
            string value;

            foreach (string line in lines)
            {
                uneLigne = line.Split(",");
                Vehicule nouvVehicule = new Vehicule();
                nouvVehicule.SetImmat(uneLigne[0]);
                value = uneLigne[1];
                Couleurs coul = (Couleurs)Enum.Parse(typeof(Couleurs), value);
                nouvVehicule.SetCouleur(coul);
                nouvVehicule.SetPrix(double.Parse(uneLigne[2]));
                laListeDeVehicule.Add(nouvVehicule);

            }

            foreach (Vehicule unVeh in laListeDeVehicule)
            {
                Console.WriteLine("Immat: " + unVeh.GetImmat() + " Couleur: " + unVeh.GetCouleur() + " et le prix: " + unVeh.GetPrix());
            }

        }
    }
}
