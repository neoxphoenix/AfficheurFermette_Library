#region Ressources extérieures
using Projet_AFFICHEURFERMETTE.MDF.Acces;
using Projet_AFFICHEURFERMETTE.MDF.Classes;
using System;
using System.Collections.Generic;
#endregion

namespace Projet_AFFICHEURFERMETTE.MDF.Gestion
{
    /// <summary>
    /// Couche intermédiaire de gestion (Business Layer)
    /// </summary>
    public class G_Evenement : G_Base
    {
        #region Constructeurs
        public G_Evenement()
         : base()
        { }
        public G_Evenement(string sChaineConnexion)
         : base(sChaineConnexion)
        { }
        #endregion
        /// <summary>
        /// Ajoute un événement à la base de données
        /// </summary>
        /// <param name="DateDebut"></param>
        /// <param name="DateFin"></param>
        /// <param name="Description"></param>
        /// <param name="TypeEvenement">0 = divers, 1 = atelier, 2 = compétition</param>
        /// <param name="IDtitre">ID de la table Titre liée</param>
        /// <param name="IDlieu">ID de la table Lieu liée</param>
        /// <returns></returns>
        public int Ajouter(DateTime DateDebut, DateTime DateFin, string Description, int TypeEvenement, int IDtitre, int IDlieu)
        { return new A_Evenement(ChaineConnexion).Ajouter(DateDebut, DateFin, Description, TypeEvenement, IDtitre, IDlieu); }
        /// <summary>
        /// Modifie un événement de la base de données
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="DateDebut"></param>
        /// <param name="DateFin"></param>
        /// <param name="Description"></param>
        /// <param name="TypeEvenement">0 = divers, 1 = atelier, 2 = compétition</param>
        /// <param name="IDtitre">ID de la table Titre liée</param>
        /// <param name="IDlieu">ID de la table Lieu liée</param>
        /// <returns></returns>
        public int Modifier(int ID, DateTime DateDebut, DateTime DateFin, string Description, int TypeEvenement, int IDtitre, int IDlieu)
        { return new A_Evenement(ChaineConnexion).Modifier(ID, DateDebut, DateFin, Description, TypeEvenement, IDtitre, IDlieu); }
        /// <summary>
        /// Récupère tous les événements
        /// </summary>
        /// <param name="Index">Index de tri de la liste retournée</param>
        /// <returns></returns>
        public List<C_Evenement> Lire(string Index)
        { return new A_Evenement(ChaineConnexion).Lire(Index); }
        /// <summary>
        /// Lis l'événement précisé
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public C_Evenement Lire_ID(int ID)
        { return new A_Evenement(ChaineConnexion).Lire_ID(ID); }
        /// <summary>
        /// Suppression de l'événement précisé ATTENTION ceci supprimera aussi les tables Classement et PersonnesConcernees qui y sont liées
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Supprimer(int ID)
        { return new A_Evenement(ChaineConnexion).Supprimer(ID); }
    }
}
