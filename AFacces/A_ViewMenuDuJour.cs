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
    public class A_ViewMenuDuJour : ADBase
    {
        #region Constructeurs
        public A_ViewMenuDuJour(string sChaineConnexion)
            : base(sChaineConnexion)
        { }
        #endregion
        public List<C_ViewMenuDuJour> Lire(string Index)
        {
            CreerCommande("SelectionnerViewMenuDuJour");
            Commande.Parameters.AddWithValue("@Index", Index);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_ViewMenuDuJour> res = new List<C_ViewMenuDuJour>();
            while (dr.Read())
            {
                C_ViewMenuDuJour tmp = new C_ViewMenuDuJour();
                tmp.ID = int.Parse(dr["ID"].ToString());
                tmp.Date = DateTime.Parse(dr["Date"].ToString());
                tmp.eNom = dr["eNom"].ToString();
                tmp.pNom = dr["pNom"].ToString();
                tmp.dNom = dr["dNom"].ToString();
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public C_ViewMenuDuJour Lire_ID(int ID)
        {
            CreerCommande("SelectionnerViewMenuDuJour_ID");
            Commande.Parameters.AddWithValue("@ID", ID);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            C_ViewMenuDuJour res = new C_ViewMenuDuJour();
            while (dr.Read())
            {
                res.ID = int.Parse(dr["ID"].ToString());
                res.Date = DateTime.Parse(dr["Date"].ToString());
                res.eNom = dr["eNom"].ToString();
                res.pNom = dr["pNom"].ToString();
                res.dNom = dr["dNom"].ToString();
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
    }
}
