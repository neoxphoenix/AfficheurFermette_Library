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
        /// <summary>
        /// Récupère tous les événements
        /// </summary>
        /// <param name="Index">Trie selon l'index entré</param>
        /// <returns>événements complets</returns>
        public List<C_ViewEvenement> Lire(string Index)
        { return new A_ViewEvenement(ChaineConnexion).Lire(Index); }
        /// <summary>
        /// Récupère un événement par son ID
        /// </summary>
        /// <param name="ID">ID de l'événement à récupérer</param>
        /// <returns>événement complet</returns>
        public C_ViewEvenement Lire_ID(int ID)
        { return new A_ViewEvenement(ChaineConnexion).Lire_ID(ID); }
        /// <summary>
        /// Récupère la liste des événements commençant à la date précisée
        /// </summary>
        /// <param name="DateDebut">Date de début de l'événement</param>
        /// <returns>Tous les événements commençant à la date précisée</returns>
        public List<C_ViewEvenement> Lire_DateDebut(DateTime DateDebut)
        { return new A_ViewEvenement(ChaineConnexion).Lire_DateDebut(DateDebut); }
        /// <summary>
        /// Récupère la liste des événements se terminant à la date précisée
        /// </summary>
        /// <param name="DateFin">Date de fin de l'événement</param>
        /// <returns></returns>
        public List<C_ViewEvenement> Lire_DateFin(DateTime DateFin)
        { return new A_ViewEvenement(ChaineConnexion).Lire_DateFin(DateFin); }
        /// <summary>
        /// Récupère la liste des événements se déroulants à la date donnée (=> qui ont leur date de début et date de fin qui encercle la date donnée)
        /// </summary>
        /// <param name="Date"></param>
        /// <returns></returns>
        public List<C_ViewEvenement> Lire_Date(DateTime Date)
        { return new A_ViewEvenement(ChaineConnexion).Lire_Date(Date); }
        /// <summary>
        /// Récupère les photos liées à un événement
        /// </summary>
        /// <param name="ID">ID de l'événement</param>
        /// <returns>Liste des photos</returns>
        public List<C_PhotoEvenement> LirePhotosEvenement(int ID)
        { return new A_ViewEvenement(ChaineConnexion).LirePhotosEvenement(ID); }
        /// <summary>
        /// Récupère les personnes participant à un événement
        /// </summary>
        /// <param name="ID">ID de l'événement</param>
        /// <returns>Participants</returns>
        public List<C_Personne> LirePersonnesEvenement(int ID)
        { return new A_ViewEvenement(ChaineConnexion).LirePersonnesEvenement(ID); }
        /// <summary>
        /// Récupère les personnes participant à une compétition, ainsi que leur position dans ladite compétition
        /// </summary>
        /// <param name="ID">ID de l'événement</param>
        /// <returns>Participants et leurs positions</returns>
        public List<C_PersonnePos> LireClassementEvenement(int ID)
        { return new A_ViewEvenement(ChaineConnexion).LireClassementEvenement(ID); }
    }
}
