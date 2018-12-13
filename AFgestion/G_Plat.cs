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
 public class G_Plat : G_Base
 {
  #region Constructeurs
  public G_Plat()
   : base()
  { }
  public G_Plat(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom, int Type)
  { return new A_Plat(ChaineConnexion).Ajouter(nom, Type); }
  public int Modifier(int ID, string nom, int Type)
  { return new A_Plat(ChaineConnexion).Modifier(ID, nom, Type); }
  public List<C_Plat> Lire(string Index)
  { return new A_Plat(ChaineConnexion).Lire(Index); }
  public C_Plat Lire_ID(int ID)
  { return new A_Plat(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_Plat(ChaineConnexion).Supprimer(ID); }
 }
}
