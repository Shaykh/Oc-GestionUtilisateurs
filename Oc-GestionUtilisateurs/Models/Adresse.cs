using System.ComponentModel;
namespace Oc_GestionUtilisateurs.Models
{
    public class Adresse : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
    }
}
