#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_AFFICHEURFERMETTE.MDF.Classes;
#endregion

namespace Projet_AFFICHEURFERMETTE.MDF.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_Personne : ADBase
 {
  #region Constructeurs
  public A_Personne(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, string Prenom, DateTime DateNaissance, string Photo, bool Role)
  {
   CreerCommande("AjouterPersonne");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   Commande.Parameters.AddWithValue("@Prenom", Prenom);
   Commande.Parameters.AddWithValue("@DateNaissance", DateNaissance);
   if(Photo == null) Commande.Parameters.AddWithValue("@Photo", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Photo", Photo);
   Commande.Parameters.AddWithValue("@Role", Role);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string Nom, string Prenom, DateTime DateNaissance, string Photo, bool Role)
  {
   CreerCommande("ModifierPersonne");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   Commande.Parameters.AddWithValue("@Prenom", Prenom);
   Commande.Parameters.AddWithValue("@DateNaissance", DateNaissance);
   if(Photo == null) Commande.Parameters.AddWithValue("@Photo", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Photo", Photo);
   Commande.Parameters.AddWithValue("@Role", Role);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_Personne> Lire(string Index)
  {
   CreerCommande("SelectionnerPersonne");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Personne> res = new List<C_Personne>();
   while (dr.Read())
   {
    C_Personne tmp = new C_Personne();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.Nom = dr["Nom"].ToString();
    tmp.Prenom = dr["Prenom"].ToString();
    tmp.DateNaissance = DateTime.Parse(dr["DateNaissance"].ToString());
    tmp.Photo = dr["Photo"].ToString();
    tmp.Role = bool.Parse(dr["Role"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_Personne Lire_ID(int ID)
  {
   CreerCommande("SelectionnerPersonne_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_Personne res = new C_Personne();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.Nom = dr["Nom"].ToString();
    res.Prenom = dr["Prenom"].ToString();
    res.DateNaissance = DateTime.Parse(dr["DateNaissance"].ToString());
    res.Photo = dr["Photo"].ToString();
    res.Role = bool.Parse(dr["Role"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerPersonne");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
