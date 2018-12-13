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
 public class A_PersonneConcernees : ADBase
 {
  #region Constructeurs
  public A_PersonneConcernees(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int IDevenement, int IDpersonne)
  {
   CreerCommande("AjouterPersonneConcernees");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@IDevenement", IDevenement);
   Commande.Parameters.AddWithValue("@IDpersonne", IDpersonne);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int IDevenement, int IDpersonne)
  {
   CreerCommande("ModifierPersonneConcernees");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@IDevenement", IDevenement);
   Commande.Parameters.AddWithValue("@IDpersonne", IDpersonne);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_PersonneConcernees> Lire(string Index)
  {
   CreerCommande("SelectionnerPersonneConcernees");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_PersonneConcernees> res = new List<C_PersonneConcernees>();
   while (dr.Read())
   {
    C_PersonneConcernees tmp = new C_PersonneConcernees();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.IDevenement = int.Parse(dr["IDevenement"].ToString());
    tmp.IDpersonne = int.Parse(dr["IDpersonne"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_PersonneConcernees Lire_ID(int ID)
  {
   CreerCommande("SelectionnerPersonneConcernees_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_PersonneConcernees res = new C_PersonneConcernees();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.IDevenement = int.Parse(dr["IDevenement"].ToString());
    res.IDpersonne = int.Parse(dr["IDpersonne"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerPersonneConcernees");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
