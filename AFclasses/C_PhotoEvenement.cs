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
 public class C_PhotoEvenement
 {
  #region Données membres
  private int _ID;
  private int _IDevenement;
  private string _Photo;
  private bool _EstPicto;
  #endregion
  #region Constructeurs
  public C_PhotoEvenement()
  { }
  public C_PhotoEvenement(int IDevenement_, string Photo_, bool EstPicto_)
  {
   IDevenement = IDevenement_;
   Photo = Photo_;
   EstPicto = EstPicto_;
  }
  public C_PhotoEvenement(int ID_, int IDevenement_, string Photo_, bool EstPicto_)
   : this(IDevenement_, Photo_, EstPicto_)
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
  public string Photo
  {
   get { return _Photo; }
   set { _Photo = value; }
  }
  public bool EstPicto
  {
   get { return _EstPicto; }
   set { _EstPicto = value; }
  }
  #endregion
 }
}
