#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_AFFICHEURFERMETTE.MDF.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_PersonneConcernees
 {
  #region Données membres
  private int _ID;
  private int _IDevenement;
  private int _IDpersonne;
  #endregion
  #region Constructeurs
  public C_PersonneConcernees()
  { }
  public C_PersonneConcernees(int IDevenement_, int IDpersonne_)
  {
   IDevenement = IDevenement_;
   IDpersonne = IDpersonne_;
  }
  public C_PersonneConcernees(int ID_, int IDevenement_, int IDpersonne_)
   : this(IDevenement_, IDpersonne_)
  {
   ID = ID_;
  }
  #endregion
  #region Accesseurs
  public int ID
  {
   get { return _ID; }
   set { _ID = value; }
  }
  public int IDevenement
  {
   get { return _IDevenement; }
   set { _IDevenement = value; }
  }
  public int IDpersonne
  {
   get { return _IDpersonne; }
   set { _IDpersonne = value; }
  }
  #endregion
 }
}
