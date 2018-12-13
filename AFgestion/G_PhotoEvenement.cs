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
 public class G_PhotoEvenement : G_Base
 {
  #region Constructeurs
  public G_PhotoEvenement()
   : base()
  { }
  public G_PhotoEvenement(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDevenement, string Photo, bool EstPicto)
  { return new A_PhotoEvenement(ChaineConnexion).Ajouter(IDevenement, Photo, EstPicto); }
  public int Modifier(int ID, int IDevenement, string Photo, bool EstPicto)
  { return new A_PhotoEvenement(ChaineConnexion).Modifier(ID, IDevenement, Photo, EstPicto); }
  public List<C_PhotoEvenement> Lire(string Index)
  { return new A_PhotoEvenement(ChaineConnexion).Lire(Index); }
  public C_PhotoEvenement Lire_ID(int ID)
  { return new A_PhotoEvenement(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_PhotoEvenement(ChaineConnexion).Supprimer(ID); }
 }
}
