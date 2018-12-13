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
 public class A_Plat : ADBase
 {
  #region Constructeurs
  public A_Plat(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom, int Type)
  {
   CreerCommande("AjouterPlat");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nom", nom);
   Commande.Parameters.AddWithValue("@Type", Type);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string nom, int Type)
  {
   CreerCommande("ModifierPlat");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@nom", nom);
   Commande.Parameters.AddWithValue("@Type", Type);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_Plat> Lire(string Index)
  {
   CreerCommande("SelectionnerPlat");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Plat> res = new List<C_Plat>();
   while (dr.Read())
   {
    C_Plat tmp = new C_Plat();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.nom = dr["nom"].ToString();
    tmp.Type = int.Parse(dr["Type"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_Plat Lire_ID(int ID)
  {
   CreerCommande("SelectionnerPlat_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_Plat res = new C_Plat();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.nom = dr["nom"].ToString();
    res.Type = int.Parse(dr["Type"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerPlat");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
