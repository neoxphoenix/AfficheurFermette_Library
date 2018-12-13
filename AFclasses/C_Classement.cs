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
 public class C_Classement
 {
  #region Données membres
  private int _ID;
  private int _IDevenement;
  private int _IDpersonne;
  private int _Position;
  #endregion
  #region Constructeurs
  public C_Classement()
  { }
  public C_Classement(int IDevenement_, int IDpersonne_, int Position_)
  {
   IDevenement = IDevenement_;
   IDpersonne = IDpersonne_;
   Position = Position_;
  }
  public C_Classement(int ID_, int IDevenement_, int IDpersonne_, int Position_)
   : this(IDevenement_, IDpersonne_, Position_)
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
  public int Position
  {
   get { return _Position; }
   set { _Position = value; }
  }
  #endregion
 }
}
