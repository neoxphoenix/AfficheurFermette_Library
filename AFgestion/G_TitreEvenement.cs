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
 public class G_TitreEvenement : G_Base
 {
  #region Constructeurs
  public G_TitreEvenement()
   : base()
  { }
  public G_TitreEvenement(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDevenement, string Titre)
  { return new A_TitreEvenement(ChaineConnexion).Ajouter(IDevenement, Titre); }
  public int Modifier(int ID, int IDevenement, string Titre)
  { return new A_TitreEvenement(ChaineConnexion).Modifier(ID, IDevenement, Titre); }
  public List<C_TitreEvenement> Lire(string Index)
  { return new A_TitreEvenement(ChaineConnexion).Lire(Index); }
  public C_TitreEvenement Lire_ID(int ID)
  { return new A_TitreEvenement(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_TitreEvenement(ChaineConnexion).Supprimer(ID); }
 }
}
