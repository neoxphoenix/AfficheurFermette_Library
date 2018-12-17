#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_AFFICHEURFERMETTE.MDF.Classes;
using Projet_AFFICHEURFERMETTE.MDF.Acces;
#endregion

namespace Projet_AFFICHEURFERMETTE.MDF.Gestion
{
    /// <summary>
    /// Couche intermédiaire de gestion (Business Layer)
    /// </summary>
    public class G_ViewMenuDuJour : G_Base
    {
        #region Constructeurs
        public G_ViewMenuDuJour()
         : base()
        { }
        public G_ViewMenuDuJour(string sChaineConnexion)
         : base(sChaineConnexion)
        { }
        #endregion
        public List<C_ViewMenuDuJour> Lire(string Index)
        { return new A_ViewMenuDuJour(ChaineConnexion).Lire(Index); }
        public C_ViewMenuDuJour Lire_ID(int ID)
        { return new A_ViewMenuDuJour(ChaineConnexion).Lire_ID(ID); }
        public C_ViewMenuDuJour Lire_Date(DateTime Date)
        { return new A_ViewMenuDuJour(ChaineConnexion).Lire_Date(Date); }
    }
}
