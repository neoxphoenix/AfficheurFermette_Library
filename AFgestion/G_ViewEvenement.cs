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
    public class G_ViewEvenement : G_Base
    {
        #region Constructeurs
        public G_ViewEvenement()
         : base()
        { }
        public G_ViewEvenement(string sChaineConnexion)
         : base(sChaineConnexion)
        { }
        #endregion
        public List<C_ViewEvenement> Lire(string Index)
        { return new A_ViewEvenement(ChaineConnexion).Lire(Index); }
        public C_ViewEvenement Lire_ID(int ID)
        { return new A_ViewEvenement(ChaineConnexion).Lire_ID(ID); }
        public List<C_PhotoEvenement> LirePhotosEvenement(int ID)
        { return new A_ViewEvenement(ChaineConnexion).LirePhotosEvenement(ID); }
        public List<C_Personne> LirePersonnesEvenement(int ID)
        { return new A_ViewEvenement(ChaineConnexion).LirePersonnesEvenement(ID); }
        public List<C_PersonnePos> LireClassementEvenement(int ID)
        { return new A_ViewEvenement(ChaineConnexion).LireClassementEvenement(ID); }
    }
}
