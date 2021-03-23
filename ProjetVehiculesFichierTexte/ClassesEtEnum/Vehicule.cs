using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetVehiculesFichierTexte.ClassesEtEnum
{
    class Vehicule
    {
        private string _immatriculation;
        private Couleurs _couleur;
        private double _prix;

        public Vehicule() { }

        public Vehicule(string immat, Couleurs laCouleur, double lePrix)
        {
            _immatriculation = immat;
            _couleur = laCouleur;
            _prix = lePrix;
        }

        public void SetImmat(string immat)
        {
            _immatriculation = immat;
        }

        public string GetImmat()
        {
            return _immatriculation;
        }

        public void SetCouleur(Couleurs laCouleur)
        {
            _couleur = laCouleur;
        }

        public Couleurs GetCouleur()
        {
            return _couleur;
        }

        public void SetPrix(double lePrix)
        {
            _prix = lePrix;
        }

        public double GetPrix()
        {
            return _prix;
        }
    }
}
