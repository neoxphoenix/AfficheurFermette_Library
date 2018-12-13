#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_AFFICHEURFERMETTE.MDF.Classes
{
    /// <summary>
    /// Classe de définition des données
    /// </summary>
    public class C_ViewEvenement
    {
        #region Données membres
        private int _ID;
        private string _Titre;
        private string _Lieu;
        private int _TypeEvenement;
        private DateTime _DateDebut;
        private DateTime _DateFin;
        private string _Description;
        #endregion
        #region Constructeurs
        public C_ViewEvenement()
        { }
        public C_ViewEvenement(string Titre_, string Lieu_, int TypeEvenement_, DateTime DateDebut_, DateTime DateFin_, string Description_)
        {
            Titre = Titre_;
            Lieu = Lieu_;
            TypeEvenement = TypeEvenement_;
            DateDebut = DateDebut_;
            DateFin = DateFin_;
            Description = Description_;
        }
        public C_ViewEvenement(int ID_, string Titre_, string Lieu_, int TypeEvenement_, DateTime DateDebut_, DateTime DateFin_, string Description_)
         : this(Titre_, Lieu_, TypeEvenement_, DateDebut_, DateFin_, Description_)
        {
            ID = ID_;
        }
        #endregion
        #region Accesseurs
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }
        public string Lieu
        {
            get { return _Lieu; }
            set { _Lieu = value; }
        }
        public int TypeEvenement
        {
            get { return _TypeEvenement; }
            set { _TypeEvenement = value; }
        }
        public DateTime DateDebut
        {
            get { return _DateDebut; }
            set { _DateDebut = value; }
        }
        public DateTime DateFin
        {
            get { return _DateFin; }
            set { _DateFin = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        #endregion
    }
}
