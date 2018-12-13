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
 public class G_Personne : G_Base
 {
  #region Constructeurs
  public G_Personne()
   : base()
  { }
  public G_Personne(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, string Prenom, DateTime DateNaissance, string Photo, bool Role)
  { return new A_Personne(ChaineConnexion).Ajouter(Nom, Prenom, DateNaissance, Photo, Role); }
  public int Modifier(int ID, string Nom, string Prenom, DateTime DateNaissance, string Photo, bool Role)
  { return new A_Personne(ChaineConnexion).Modifier(ID, Nom, Prenom, DateNaissance, Photo, Role); }
  public List<C_Personne> Lire(string Index)
  { return new A_Personne(ChaineConnexion).Lire(Index); }
  public C_Personne Lire_ID(int ID)
  { return new A_Personne(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_Personne(ChaineConnexion).Supprimer(ID); }
 }
}
