using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Oc_GestionUtilisateurs.Models;

namespace Oc_GestionUtilisateurs
{
    public class FicheUtilisateurViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        private ObservableCollection<Utilisateur> fiches;
        public ObservableCollection<Utilisateur> Fiches
        {
            get { return fiches; }
            set
            {
                if (value != fiches)
                {
                    fiches = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Utilisateur utilisateurSelectionne;
        public Utilisateur UtilisateurSelectionne
        {
            get { return utilisateurSelectionne; }
            set
            {
                if (value != utilisateurSelectionne)
                {
                    utilisateurSelectionne = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public FicheUtilisateurViewModel()
        {
            Fiches = new ObservableCollection<Utilisateur>();
        }

        public ICommand ReinitialiserFicheUtilisateur { get; } = new RelayCommand<Utilisateur>(
            (utilisateur) =>
            {
                utilisateur.Adresse.CodePostal = null;
                utilisateur.Adresse.Numero = null;
                utilisateur.Adresse.Pays = string.Empty;
                utilisateur.Adresse.Rue = string.Empty;
                utilisateur.Adresse.Ville = string.Empty;
                utilisateur.Age = 0;
                utilisateur.Genre = string.Empty;
                utilisateur.Nom = string.Empty;
                utilisateur.Prenom = string.Empty;
                utilisateur.Profession = string.Empty;
            }
        );

        private ICommand ajouterFicheUtilisateur;
        public ICommand AjouterFicheUtilisateur
        {
            get
            {
                if (ajouterFicheUtilisateur == null)
                {
                    ajouterFicheUtilisateur = new RelayCommand<object>(
                        (obj) => Fiches.Add(new Utilisateur())
                    );
                }
                return ajouterFicheUtilisateur;
            }
        }

        private ICommand modifierFicheUtilisateur;
        public ICommand ModifierFicheUtilisateur
        {
            get
            {
                if (modifierFicheUtilisateur == null)
                {
                    modifierFicheUtilisateur = new RelayCommand<Utilisateur>(
                        (utilisateur) => utilisateurSelectionne = utilisateur
                    );
                }
                return modifierFicheUtilisateur;
            }
        }

        private ICommand supprimerFicheUtilisateur;
        public ICommand SupprimerFicheUtilisateur
        {
            get
            {
                if (supprimerFicheUtilisateur == null)
                {
                    supprimerFicheUtilisateur = new RelayCommand<Utilisateur>((utilisateur) => Fiches.Remove(utilisateur));
                }
                return supprimerFicheUtilisateur;
            }
        }
    }
}
