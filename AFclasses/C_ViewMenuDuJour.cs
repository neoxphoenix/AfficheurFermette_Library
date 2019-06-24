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
    public class C_ViewMenuDuJour
    {
        #region Données membres
        private int _ID;
        private DateTime _Date;
        private string _eNom;
        private string _pNom;
        private string _dNom;
        private string _ePhoto;
        private string _pPhoto;
        private string _dPhoto;
        #endregion
        #region Constructeurs
        public C_ViewMenuDuJour()
        { }
        public C_ViewMenuDuJour(DateTime Date_, string eNom_, string ePhoto_, string pNom_, string pPhoto_, string dNom_, string dPhoto_)
        {
            Date = Date_;
            eNom = eNom_;
            ePhoto = ePhoto_;
            pNom = pNom_;
            pPhoto = pPhoto_;
            dNom = dNom_;
            dPhoto = dPhoto_;
        }
        public C_ViewMenuDuJour(int ID_, DateTime Date_, string eNom_, string ePhoto_, string pNom_, string pPhoto_, string dNom_, string dPhoto_)
         : this(Date_, eNom_, ePhoto_, pNom_, pPhoto_, dNom_, dPhoto_)
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
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public string eNom
        {
            get { return _eNom; }
            set { _eNom = value; }
        }
        public string pNom
        {
            get { return _pNom; }
            set { _pNom = value; }
        }
        public string dNom
        {
            get { return _dNom; }
            set { _dNom = value; }
        }

        public string ePhoto { get => _ePhoto; set => _ePhoto = value; }
        public string pPhoto { get => _pPhoto; set => _pPhoto = value; }
        public string dPhoto { get => _dPhoto; set => _dPhoto = value; }
        #endregion
    }
}
