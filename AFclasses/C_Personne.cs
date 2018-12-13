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
 public class C_Personne
 {
  #region Données membres
  private int _ID;
  private string _Nom;
  private string _Prenom;
  private DateTime _DateNaissance;
  private string _Photo;
  private bool _Role;
  #endregion
  #region Constructeurs
  public C_Personne()
  { }
  public C_Personne(string Nom_, string Prenom_, DateTime DateNaissance_, string Photo_, bool Role_)
  {
   Nom = Nom_;
   Prenom = Prenom_;
   DateNaissance = DateNaissance_;
   Photo = Photo_;
   Role = Role_;
  }
  public C_Personne(int ID_, string Nom_, string Prenom_, DateTime DateNaissance_, string Photo_, bool Role_)
   : this(Nom_, Prenom_, DateNaissance_, Photo_, Role_)
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
  public string Nom
  {
   get { return _Nom; }
   set { _Nom = value; }
  }
  public string Prenom
  {
   get { return _Prenom; }
   set { _Prenom = value; }
  }
  public DateTime DateNaissance
  {
   get { return _DateNaissance; }
   set { _DateNaissance = value; }
  }
  public string Photo
  {
   get { return _Photo; }
   set { _Photo = value; }
  }
  public bool Role
  {
   get { return _Role; }
   set { _Role = value; }
  }
  #endregion
 }
}
