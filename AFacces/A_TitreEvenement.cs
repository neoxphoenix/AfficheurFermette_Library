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
 public class A_TitreEvenement : ADBase
 {
  #region Constructeurs
  public A_TitreEvenement(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Titre)
  {
   CreerCommande("AjouterTitreEvenement");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Titre", Titre);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string Titre)
  {
   CreerCommande("ModifierTitreEvenement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@Titre", Titre);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_TitreEvenement> Lire(string Index)
  {
   CreerCommande("SelectionnerTitreEvenement");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_TitreEvenement> res = new List<C_TitreEvenement>();
   while (dr.Read())
   {
    C_TitreEvenement tmp = new C_TitreEvenement();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.Titre = dr["Titre"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_TitreEvenement Lire_ID(int ID)
  {
   CreerCommande("SelectionnerTitreEvenement_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_TitreEvenement res = new C_TitreEvenement();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.Titre = dr["Titre"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerTitreEvenement");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
