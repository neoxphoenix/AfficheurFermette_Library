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
        #endregion
        #region Constructeurs
        public C_ViewMenuDuJour()
        { }
        public C_ViewMenuDuJour(DateTime Date_, string eNom_, string pNom_, string dNom_)
        {
            Date = Date_;
            eNom = eNom_;
            pNom = pNom_;
            dNom = dNom_;
        }
        public C_ViewMenuDuJour(int ID_, DateTime Date_, string eNom_, string pNom_, string dNom_)
         : this(Date_, eNom_, pNom_, dNom_)
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
        #endregion
    }
}
