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
 public class A_PhotoEvenement : ADBase
 {
  #region Constructeurs
  public A_PhotoEvenement(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDevenement, string Photo, bool EstPicto)
  {
   CreerCommande("AjouterPhotoEvenement");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@IDevenement", IDevenement);
   Commande.Parameters.AddWithValue("@Photo", Photo);
   Commande.Parameters.AddWithValue("@EstPicto", EstPicto);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int IDevenement, string Photo, bool EstPicto)
  {
   CreerCommande("ModifierPhotoEvenement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@IDevenement", IDevenement);
   Commande.Parameters.AddWithValue("@Photo", Photo);
   Commande.Parameters.AddWithValue("@EstPicto", EstPicto);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_PhotoEvenement> Lire(string Index)
  {
   CreerCommande("SelectionnerPhotoEvenement");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_PhotoEvenement> res = new List<C_PhotoEvenement>();
   while (dr.Read())
   {
    C_PhotoEvenement tmp = new C_PhotoEvenement();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.IDevenement = int.Parse(dr["IDevenement"].ToString());
    tmp.Photo = dr["Photo"].ToString();
    tmp.EstPicto = bool.Parse(dr["EstPicto"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_PhotoEvenement Lire_ID(int ID)
  {
   CreerCommande("SelectionnerPhotoEvenement_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_PhotoEvenement res = new C_PhotoEvenement();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.IDevenement = int.Parse(dr["IDevenement"].ToString());
    res.Photo = dr["Photo"].ToString();
    res.EstPicto = bool.Parse(dr["EstPicto"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerPhotoEvenement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
