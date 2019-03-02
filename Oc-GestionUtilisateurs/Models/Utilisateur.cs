using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Oc_GestionUtilisateurs.Models
{
    public class Utilisateur : INotifyPropertyChanged
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                if (value != nom)
                {
                    nom = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nom"));
                }
            }
        }

        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (value != prenom)
                {
                    prenom = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prenom"));
                }
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value != age)
                {
                    age = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }

        private string genre;
        public string Genre
        {
            get { return genre; }
            set
            {
                if (value != genre)
                {
                    genre = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Genre"));
                }
            }
        }

        private string profession;
        public string Profession
        {
            get { return profession; }
            set
            {
                if (value != profession)
                {
                    profession = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Profession"));
                }
            }
        }

        private Adresse adresse;
        public Adresse Adresse
        {
            get { return adresse; }
            set
            {
                if (!value.Equals(adresse))
                {
                    adresse = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Adresse"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
