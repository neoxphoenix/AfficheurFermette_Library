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
 public class C_Evenement
 {
  #region Données membres
  private int _ID;
  private DateTime _DateDebut;
  private DateTime _DateFin;
  private string _Description;
  private int _TypeEvenement;
  #endregion
  #region Constructeurs
  public C_Evenement()
  { }
  public C_Evenement(DateTime DateDebut_, DateTime DateFin_, string Description_, int TypeEvenement_)
  {
   DateDebut = DateDebut_;
   DateFin = DateFin_;
   Description = Description_;
   TypeEvenement = TypeEvenement_;
  }
  public C_Evenement(int ID_, DateTime DateDebut_, DateTime DateFin_, string Description_, int TypeEvenement_)
   : this(DateDebut_, DateFin_, Description_, TypeEvenement_)
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
  public DateTime DateDebut
  {
   get { return _DateDebut; }
   set { _DateDebut = value; }
  }
  public DateTime DateFin
  {
   get { return _DateFin; }
   set { _DateFin = value; }
  }
  public string Description
  {
   get { return _Description; }
   set { _Description = value; }
  }
  public int TypeEvenement
  {
   get { return _TypeEvenement; }
   set { _TypeEvenement = value; }
  }
  #endregion
 }
}
