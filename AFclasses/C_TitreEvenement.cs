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
 public class C_TitreEvenement
 {
  #region Données membres
  private int _ID;
  private string _Titre;
  #endregion
  #region Constructeurs
  public C_TitreEvenement()
  { }
  public C_TitreEvenement(string Titre_)
  {
   Titre = Titre_;
  }
  public C_TitreEvenement(int ID_, string Titre_)
   : this(Titre_)
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
  public string Titre
  {
   get { return _Titre; }
   set { _Titre = value; }
  }
  #endregion
 }
}
