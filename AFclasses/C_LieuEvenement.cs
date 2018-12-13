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
  private int _IDevenement;
  private string _Lieu;
  #endregion
  #region Constructeurs
  public C_LieuEvenement()
  { }
  public C_LieuEvenement(int IDevenement_, string Lieu_)
  {
   IDevenement = IDevenement_;
   Lieu = Lieu_;
  }
  public C_LieuEvenement(int ID_, int IDevenement_, string Lieu_)
   : this(IDevenement_, Lieu_)
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
  public string Lieu
  {
   get { return _Lieu; }
   set { _Lieu = value; }
  }
  #endregion
 }
}
