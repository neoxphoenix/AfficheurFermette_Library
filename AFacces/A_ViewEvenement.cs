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
    public class A_ViewEvenement : ADBase
    {
        #region Constructeurs
        public A_ViewEvenement(string sChaineConnexion)
            : base(sChaineConnexion)
        { }
        #endregion
        public List<C_ViewEvenement> Lire(string Index)
        {
            CreerCommande("SelectionnerViewEvenement");
            Commande.Parameters.AddWithValue("@Index", Index);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_ViewEvenement> res = new List<C_ViewEvenement>();
            while (dr.Read())
            {
                C_ViewEvenement tmp = new C_ViewEvenement();
                tmp.ID = int.Parse(dr["ID"].ToString());
                tmp.Titre = dr["Titre"].ToString();
                tmp.Lieu = dr["Lieu"].ToString();
                tmp.TypeEvenement = int.Parse(dr["TypeEvenement"].ToString());
                tmp.DateDebut = DateTime.Parse(dr["DateDebut"].ToString());
                tmp.DateFin = DateTime.Parse(dr["DateFin"].ToString());
                tmp.Description = dr["Description"].ToString();
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public C_ViewEvenement Lire_ID(int ID)
        {
            CreerCommande("SelectionnerViewEvenement_ID");
            Commande.Parameters.AddWithValue("@ID", ID);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            C_ViewEvenement res = new C_ViewEvenement();
            while (dr.Read())
            {
                res.ID = int.Parse(dr["ID"].ToString());
                res.Titre = dr["Titre"].ToString();
                res.Lieu = dr["Lieu"].ToString();
                res.TypeEvenement = int.Parse(dr["TypeEvenement"].ToString());
                res.DateDebut = DateTime.Parse(dr["DateDebut"].ToString());
                res.DateFin = DateTime.Parse(dr["DateFin"].ToString());
                res.Description = dr["Description"].ToString();
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public List<C_ViewEvenement> Lire_DateDebut(DateTime dateDebut)
        {
            CreerCommande("SelectionnerViewEvenement_DateDebut");
            Commande.Parameters.AddWithValue("@DateDebut", dateDebut);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_ViewEvenement> res = new List<C_ViewEvenement>();
            while (dr.Read())
            {
                C_ViewEvenement tmp = new C_ViewEvenement();
                tmp.ID = int.Parse(dr["ID"].ToString());
                tmp.Titre = dr["Titre"].ToString();
                tmp.Lieu = dr["Lieu"].ToString();
                tmp.TypeEvenement = int.Parse(dr["TypeEvenement"].ToString());
                tmp.DateDebut = DateTime.Parse(dr["DateDebut"].ToString());
                tmp.DateFin = DateTime.Parse(dr["DateFin"].ToString());
                tmp.Description = dr["Description"].ToString();
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public List<C_ViewEvenement> Lire_DateFin(DateTime dateFin)
        {
            CreerCommande("SelectionnerViewEvenement_DateFin");
            Commande.Parameters.AddWithValue("@DateFin", dateFin);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_ViewEvenement> res = new List<C_ViewEvenement>();
            while (dr.Read())
            {
                C_ViewEvenement tmp = new C_ViewEvenement();
                tmp.ID = int.Parse(dr["ID"].ToString());
                tmp.Titre = dr["Titre"].ToString();
                tmp.Lieu = dr["Lieu"].ToString();
                tmp.TypeEvenement = int.Parse(dr["TypeEvenement"].ToString());
                tmp.DateDebut = DateTime.Parse(dr["DateDebut"].ToString());
                tmp.DateFin = DateTime.Parse(dr["DateFin"].ToString());
                tmp.Description = dr["Description"].ToString();
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public List<C_ViewEvenement> Lire_Date(DateTime date)
        {
            CreerCommande("SelectionnerViewEvenement_Date");
            Commande.Parameters.AddWithValue("@Date", date);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_ViewEvenement> res = new List<C_ViewEvenement>();
            while (dr.Read())
            {
                C_ViewEvenement tmp = new C_ViewEvenement();
                tmp.ID = int.Parse(dr["ID"].ToString());
                tmp.Titre = dr["Titre"].ToString();
                tmp.Lieu = dr["Lieu"].ToString();
                tmp.TypeEvenement = int.Parse(dr["TypeEvenement"].ToString());
                tmp.DateDebut = DateTime.Parse(dr["DateDebut"].ToString());
                tmp.DateFin = DateTime.Parse(dr["DateFin"].ToString());
                tmp.Description = dr["Description"].ToString();
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public List<C_PhotoEvenement> LirePhotosEvenement(int ID)
        {
            CreerCommande("SelectionnerPhotosEvenement");
            Commande.Parameters.AddWithValue("@ID", ID);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_PhotoEvenement> res = new List<C_PhotoEvenement>();
            while(dr.Read())
            {
                C_PhotoEvenement tmp = new C_PhotoEvenement();
                tmp.ID = int.Parse(dr["ID"].ToString());
                tmp.IDevenement = int.Parse(dr["ID"].ToString());
                tmp.Photo = dr["Photo"].ToString();
                tmp.EstPicto = bool.Parse(dr["EstPicto"].ToString());
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public List<C_Personne> LirePersonnesEvenement(int ID)
        {
            CreerCommande("SelectionnerPersonnesEvenement");
            Commande.Parameters.AddWithValue("@ID", ID);
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
        public List<C_PersonnePos> LireClassementEvenement(int ID)
        {
            CreerCommande("SelectionnerPersonnesEvenement");
            Commande.Parameters.AddWithValue("@ID", ID);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_PersonnePos> res = new List<C_PersonnePos>();
            while (dr.Read())
            {
                C_PersonnePos tmp = new C_PersonnePos();
                tmp.ID = int.Parse(dr["ID"].ToString());
                tmp.Nom = dr["Nom"].ToString();
                tmp.Prenom = dr["Prenom"].ToString();
                tmp.DateNaissance = DateTime.Parse(dr["DateNaissance"].ToString());
                tmp.Photo = dr["Photo"].ToString();
                tmp.Role = bool.Parse(dr["Role"].ToString());
                tmp.Position = int.Parse(dr["Position"].ToString());
                res.Add(tmp);
            }
            dr.Close();
            Commande.Connection.Close();
            return res;
        }
    }
}
