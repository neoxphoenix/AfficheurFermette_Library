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
 public class C_Plat
 {
  #region Données membres
  private int _ID;
  private string _nom;
  private int _Type;
  #endregion
  #region Constructeurs
  public C_Plat()
  { }
  public C_Plat(string nom_, int Type_)
  {
   nom = nom_;
   Type = Type_;
  }
  public C_Plat(int ID_, string nom_, int Type_)
   : this(nom_, Type_)
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
  public string nom
  {
   get { return _nom; }
   set { _nom = value; }
  }
  public int Type
  {
   get { return _Type; }
   set { _Type = value; }
  }
  #endregion
 }
}
