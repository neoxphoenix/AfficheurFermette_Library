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
    public class C_Menu
    {
        #region Données membres
        private int _ID;
        private DateTime _Date;
        private int? _IDpotage;
        private int? _IDplat;
        private int? _IDdessert;
        #endregion
        #region Constructeurs
        public C_Menu()
        { }
        public C_Menu(DateTime Date_, int? IDpotage_, int? IDplat_, int? IDdessert_)
        {
            Date = Date_;
            IDpotage = IDpotage_;
            IDplat = IDplat_;
            IDdessert = IDdessert_;
        }
        public C_Menu(int ID_, DateTime Date_, int? IDpotage_, int? IDplat_, int? IDdessert_)
         : this(Date_, IDpotage_, IDplat_, IDdessert_)
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
        public int? IDpotage
        {
            get { return _IDpotage; }
            set { _IDpotage = value; }
        }
        public int? IDplat
        {
            get { return _IDplat; }
            set { _IDplat = value; }
        }
        public int? IDdessert
        {
            get { return _IDdessert; }
            set { _IDdessert = value; }
        }
        #endregion
    }
}
