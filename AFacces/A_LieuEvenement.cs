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
 public class A_LieuEvenement : ADBase
 {
  #region Constructeurs
  public A_LieuEvenement(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDevenement, string Lieu)
  {
   CreerCommande("AjouterLieuEvenement");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@IDevenement", IDevenement);
   Commande.Parameters.AddWithValue("@Lieu", Lieu);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int IDevenement, string Lieu)
  {
   CreerCommande("ModifierLieuEvenement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@IDevenement", IDevenement);
   Commande.Parameters.AddWithValue("@Lieu", Lieu);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_LieuEvenement> Lire(string Index)
  {
   CreerCommande("SelectionnerLieuEvenement");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_LieuEvenement> res = new List<C_LieuEvenement>();
   while (dr.Read())
   {
    C_LieuEvenement tmp = new C_LieuEvenement();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.IDevenement = int.Parse(dr["IDevenement"].ToString());
    tmp.Lieu = dr["Lieu"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_LieuEvenement Lire_ID(int ID)
  {
   CreerCommande("SelectionnerLieuEvenement_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_LieuEvenement res = new C_LieuEvenement();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.IDevenement = int.Parse(dr["IDevenement"].ToString());
    res.Lieu = dr["Lieu"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerLieuEvenement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
