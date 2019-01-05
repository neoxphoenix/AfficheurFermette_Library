#region Ressources extérieures
using System;
#endregion

namespace Projet_AFFICHEURFERMETTE.MDF.Classes
{
    /// <summary>
    /// Classe de définition des données
    /// </summary>
    public class C_Evenement
    {
        #region Données membres
        private int _ID;
        private DateTime _DateDebut;
        private DateTime _DateFin;
        private string _Description;
        private int _TypeEvenement;
        private int _IDtitre;
        private int _IDlieu;
        #endregion
        #region Constructeurs
        public C_Evenement()
        { }
        public C_Evenement(DateTime DateDebut_, DateTime DateFin_, string Description_, int TypeEvenement_, int IDtitre_, int IDlieu_)
        {
            DateDebut = DateDebut_;
            DateFin = DateFin_;
            Description = Description_;
            TypeEvenement = TypeEvenement_;
            IDtitre = IDtitre_;
            IDlieu = IDlieu_;
        }
        public C_Evenement(int ID_, DateTime DateDebut_, DateTime DateFin_, string Description_, int TypeEvenement_, int IDtitre_, int IDlieu_)
         : this(DateDebut_, DateFin_, Description_, TypeEvenement_, IDtitre_, IDlieu_)
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
        public int TypeEvenement
        {
            get { return _TypeEvenement; }
            set { _TypeEvenement = value; }
        }

        public int IDtitre { get => _IDtitre; set => _IDtitre = value; }
        public int IDlieu { get => _IDlieu; set => _IDlieu = value; }
        #endregion
    }
}
