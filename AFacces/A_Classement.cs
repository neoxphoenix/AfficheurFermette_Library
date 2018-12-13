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
 public class A_Classement : ADBase
 {
  #region Constructeurs
  public A_Classement(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDevenement, int IDpersonne, int Position)
  {
   CreerCommande("AjouterClassement");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@IDevenement", IDevenement);
   Commande.Parameters.AddWithValue("@IDpersonne", IDpersonne);
   Commande.Parameters.AddWithValue("@Position", Position);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int IDevenement, int IDpersonne, int Position)
  {
   CreerCommande("ModifierClassement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@IDevenement", IDevenement);
   Commande.Parameters.AddWithValue("@IDpersonne", IDpersonne);
   Commande.Parameters.AddWithValue("@Position", Position);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_Classement> Lire(string Index)
  {
   CreerCommande("SelectionnerClassement");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Classement> res = new List<C_Classement>();
   while (dr.Read())
   {
    C_Classement tmp = new C_Classement();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.IDevenement = int.Parse(dr["IDevenement"].ToString());
    tmp.IDpersonne = int.Parse(dr["IDpersonne"].ToString());
    tmp.Position = int.Parse(dr["Position"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_Classement Lire_ID(int ID)
  {
   CreerCommande("SelectionnerClassement_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_Classement res = new C_Classement();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.IDevenement = int.Parse(dr["IDevenement"].ToString());
    res.IDpersonne = int.Parse(dr["IDpersonne"].ToString());
    res.Position = int.Parse(dr["Position"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerClassement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
