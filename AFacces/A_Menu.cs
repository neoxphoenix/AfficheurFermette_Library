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
 public class A_Menu : ADBase
 {
  #region Constructeurs
  public A_Menu(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime Date, int? IDpotage, int? IDplat, int? IDdessert)
  {
   CreerCommande("AjouterMenu");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Date", Date);
   if(IDpotage == null) Commande.Parameters.AddWithValue("@IDpotage", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@IDpotage", IDpotage);
   if(IDplat == null) Commande.Parameters.AddWithValue("@IDplat", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@IDplat", IDplat);
   if(IDdessert == null) Commande.Parameters.AddWithValue("@IDdessert", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@IDdessert", IDdessert);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, DateTime Date, int? IDpotage, int? IDplat, int? IDdessert)
  {
   CreerCommande("ModifierMenu");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@Date", Date);
   if(IDpotage == null) Commande.Parameters.AddWithValue("@IDpotage", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@IDpotage", IDpotage);
   if(IDplat == null) Commande.Parameters.AddWithValue("@IDplat", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@IDplat", IDplat);
   if(IDdessert == null) Commande.Parameters.AddWithValue("@IDdessert", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@IDdessert", IDdessert);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_Menu> Lire(string Index)
  {
   CreerCommande("SelectionnerMenu");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Menu> res = new List<C_Menu>();
   while (dr.Read())
   {
    C_Menu tmp = new C_Menu();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.Date = DateTime.Parse(dr["Date"].ToString());
   if(dr["IDpotage"] != DBNull.Value) tmp.IDpotage = int.Parse(dr["IDpotage"].ToString());
   if(dr["IDplat"] != DBNull.Value) tmp.IDplat = int.Parse(dr["IDplat"].ToString());
   if(dr["IDdessert"] != DBNull.Value) tmp.IDdessert = int.Parse(dr["IDdessert"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_Menu Lire_ID(int ID)
  {
   CreerCommande("SelectionnerMenu_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_Menu res = new C_Menu();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.Date = DateTime.Parse(dr["Date"].ToString());
   if(dr["IDpotage"] != DBNull.Value) res.IDpotage = int.Parse(dr["IDpotage"].ToString());
   if(dr["IDplat"] != DBNull.Value) res.IDplat = int.Parse(dr["IDplat"].ToString());
   if(dr["IDdessert"] != DBNull.Value) res.IDdessert = int.Parse(dr["IDdessert"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerMenu");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
