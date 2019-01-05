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
 public class C_LieuEvenement
 {
  #region Données membres
  private int _ID;
  private string _Lieu;
  #endregion
  #region Constructeurs
  public C_LieuEvenement()
  { }
  public C_LieuEvenement(string Lieu_)
  {
   Lieu = Lieu_;
  }
  public C_LieuEvenement(int ID_, string Lieu_)
   : this(Lieu_)
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
  public string Lieu
  {
   get { return _Lieu; }
   set { _Lieu = value; }
  }
  #endregion
 }
}
