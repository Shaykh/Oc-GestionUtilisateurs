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

        private string pays;
        public string Pays
        {
            get { return pays; }
            set
            {
                if (value != pays)
                {
                    pays = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pays"));
                }
            }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set
            {
                if (value != ville)
                {
                    ville = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ville"));
                }
            }
        }

        private int? codePostal;
        public int? CodePostal
        {
            get { return codePostal; }
            set
            {
                if (value != codePostal)
                {
                    codePostal = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CodePostal"));
                }
            }
        }

        private string rue;
        public string Rue
        {
            get { return rue; }
            set
            {
                if (value != rue)
                {
                    rue = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rue"));
                }
            }
        }

        private int? numero;
        public int? Numero
        {
            get { return numero; }
            set
            {
                if (value != numero)
                {
                    numero = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Numero"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
