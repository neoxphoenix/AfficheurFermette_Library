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
 public class G_Menu : G_Base
 {
  #region Constructeurs
  public G_Menu()
   : base()
  { }
  public G_Menu(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime Date, int? IDpotage, int? IDplat, int? IDdessert)
  { return new A_Menu(ChaineConnexion).Ajouter(Date, IDpotage, IDplat, IDdessert); }
  public int Modifier(int ID, DateTime Date, int? IDpotage, int? IDplat, int? IDdessert)
  { return new A_Menu(ChaineConnexion).Modifier(ID, Date, IDpotage, IDplat, IDdessert); }
  public List<C_Menu> Lire(string Index)
  { return new A_Menu(ChaineConnexion).Lire(Index); }
  public C_Menu Lire_ID(int ID)
  { return new A_Menu(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_Menu(ChaineConnexion).Supprimer(ID); }
 }
}
