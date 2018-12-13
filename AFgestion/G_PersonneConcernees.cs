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
 public class G_PersonneConcernees : G_Base
 {
  #region Constructeurs
  public G_PersonneConcernees()
   : base()
  { }
  public G_PersonneConcernees(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDevenement, int IDpersonne)
  { return new A_PersonneConcernees(ChaineConnexion).Ajouter(IDevenement, IDpersonne); }
  public int Modifier(int ID, int IDevenement, int IDpersonne)
  { return new A_PersonneConcernees(ChaineConnexion).Modifier(ID, IDevenement, IDpersonne); }
  public List<C_PersonneConcernees> Lire(string Index)
  { return new A_PersonneConcernees(ChaineConnexion).Lire(Index); }
  public C_PersonneConcernees Lire_ID(int ID)
  { return new A_PersonneConcernees(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_PersonneConcernees(ChaineConnexion).Supprimer(ID); }
 }
}
