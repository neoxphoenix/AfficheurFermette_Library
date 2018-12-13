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
  public int Ajouter(DateTime DateDebut, DateTime DateFin, string Description, int TypeEvenement)
  { return new A_Evenement(ChaineConnexion).Ajouter(DateDebut, DateFin, Description, TypeEvenement); }
  public int Modifier(int ID, DateTime DateDebut, DateTime DateFin, string Description, int TypeEvenement)
  { return new A_Evenement(ChaineConnexion).Modifier(ID, DateDebut, DateFin, Description, TypeEvenement); }
  public List<C_Evenement> Lire(string Index)
  { return new A_Evenement(ChaineConnexion).Lire(Index); }
  public C_Evenement Lire_ID(int ID)
  { return new A_Evenement(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_Evenement(ChaineConnexion).Supprimer(ID); }
 }
}
