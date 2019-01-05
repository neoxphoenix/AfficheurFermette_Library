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
 public class G_LieuEvenement : G_Base
 {
  #region Constructeurs
  public G_LieuEvenement()
   : base()
  { }
  public G_LieuEvenement(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Lieu)
  { return new A_LieuEvenement(ChaineConnexion).Ajouter(Lieu); }
  public int Modifier(int ID, string Lieu)
  { return new A_LieuEvenement(ChaineConnexion).Modifier(ID, Lieu); }
  public List<C_LieuEvenement> Lire(string Index)
  { return new A_LieuEvenement(ChaineConnexion).Lire(Index); }
  public C_LieuEvenement Lire_ID(int ID)
  { return new A_LieuEvenement(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_LieuEvenement(ChaineConnexion).Supprimer(ID); }
 }
}
