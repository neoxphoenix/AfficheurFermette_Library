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
    public class C_PersonnePos
    {
        #region Données membres
        private int _ID;
        private string _Nom;
        private string _Prenom;
        private DateTime _DateNaissance;
        private string _Photo;
        private bool _Role;
        private int _Position;
        #endregion
        #region Constructeurs
        public C_PersonnePos()
        { }
        public C_PersonnePos(string Nom_, string Prenom_, DateTime DateNaissance_, string Photo_, bool Role_, int Position_)
        {
            Nom = Nom_;
            Prenom = Prenom_;
            DateNaissance = DateNaissance_;
            Photo = Photo_;
            Role = Role_;
            Position = Position_;
        }
        public C_PersonnePos(int ID_, string Nom_, string Prenom_, DateTime DateNaissance_, string Photo_, bool Role_, int Position_)
         : this(Nom_, Prenom_, DateNaissance_, Photo_, Role_, Position_)
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
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }
        public DateTime DateNaissance
        {
            get { return _DateNaissance; }
            set { _DateNaissance = value; }
        }
        public string Photo
        {
            get { return _Photo; }
            set { _Photo = value; }
        }
        public bool Role
        {
            get { return _Role; }
            set { _Role = value; }
        }
        public int Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
        #endregion
    }
}
