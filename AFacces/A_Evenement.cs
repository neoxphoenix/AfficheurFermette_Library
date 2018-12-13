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
 public class A_Evenement : ADBase
 {
  #region Constructeurs
  public A_Evenement(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime DateDebut, DateTime DateFin, string Description, int TypeEvenement)
  {
   CreerCommande("AjouterEvenement");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@DateDebut", DateDebut);
   Commande.Parameters.AddWithValue("@DateFin", DateFin);
   if(Description == null) Commande.Parameters.AddWithValue("@Description", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Description", Description);
   Commande.Parameters.AddWithValue("@TypeEvenement", TypeEvenement);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, DateTime DateDebut, DateTime DateFin, string Description, int TypeEvenement)
  {
   CreerCommande("ModifierEvenement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@DateDebut", DateDebut);
   Commande.Parameters.AddWithValue("@DateFin", DateFin);
   if(Description == null) Commande.Parameters.AddWithValue("@Description", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Description", Description);
   Commande.Parameters.AddWithValue("@TypeEvenement", TypeEvenement);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_Evenement> Lire(string Index)
  {
   CreerCommande("SelectionnerEvenement");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Evenement> res = new List<C_Evenement>();
   while (dr.Read())
   {
    C_Evenement tmp = new C_Evenement();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.DateDebut = DateTime.Parse(dr["DateDebut"].ToString());
    tmp.DateFin = DateTime.Parse(dr["DateFin"].ToString());
    tmp.Description = dr["Description"].ToString();
    tmp.TypeEvenement = int.Parse(dr["TypeEvenement"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_Evenement Lire_ID(int ID)
  {
   CreerCommande("SelectionnerEvenement_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_Evenement res = new C_Evenement();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.DateDebut = DateTime.Parse(dr["DateDebut"].ToString());
    res.DateFin = DateTime.Parse(dr["DateFin"].ToString());
    res.Description = dr["Description"].ToString();
    res.TypeEvenement = int.Parse(dr["TypeEvenement"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerEvenement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
