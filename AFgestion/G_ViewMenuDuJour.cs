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
        /// <summary>
        /// Récupère tous les menus
        /// </summary>
        /// <param name="Index">Index de tri</param>
        /// <returns></returns>
        public List<C_ViewMenuDuJour> Lire(string Index)
        { return new A_ViewMenuDuJour(ChaineConnexion).Lire(Index); }
        /// <summary>
        /// Récupère un menu par son ID
        /// </summary>
        /// <param name="ID">ID du menu</param>
        /// <returns></returns>
        public C_ViewMenuDuJour Lire_ID(int ID)
        { return new A_ViewMenuDuJour(ChaineConnexion).Lire_ID(ID); }
        /// <summary>
        /// Récupère le menu de la date précisée
        /// </summary>
        /// <param name="Date">Date</param>
        /// <returns></returns>
        public C_ViewMenuDuJour Lire_Date(DateTime Date)
        { return new A_ViewMenuDuJour(ChaineConnexion).Lire_Date(Date); }
    }
}
