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
 public class G_Classement : G_Base
 {
  #region Constructeurs
  public G_Classement()
   : base()
  { }
  public G_Classement(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDevenement, int IDpersonne, int Position)
  { return new A_Classement(ChaineConnexion).Ajouter(IDevenement, IDpersonne, Position); }
  public int Modifier(int ID, int IDevenement, int IDpersonne, int Position)
  { return new A_Classement(ChaineConnexion).Modifier(ID, IDevenement, IDpersonne, Position); }
  public List<C_Classement> Lire(string Index)
  { return new A_Classement(ChaineConnexion).Lire(Index); }
  public C_Classement Lire_ID(int ID)
  { return new A_Classement(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_Classement(ChaineConnexion).Supprimer(ID); }
 }
}
