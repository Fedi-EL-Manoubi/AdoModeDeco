using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoTpFedi;
using MySql.Data.MySqlClient;

namespace AdoTpDeco
{
    public class ManagerAuteur
    {
            public static Auteur DonneAuteurDuReader(MySqlDataReader monreader)
            {
            return null;
            }
            public static List<Auteur> DonneAuteurs()
            {
                  List<Auteur> lesAuteurs = new List<Auteur>();

                  MySqlCommand maRequete;
                  MySqlDataReader monReader;
                  Connection.MaConnection.Open();
                  maRequete = Connection.MaConnection.CreateCommand();
                  maRequete.CommandText = "select * from auteur order by nom";
                  monReader = maRequete.ExecuteReader();
                    while (monReader.Read())
                    {
                        Auteur unAuteur = new Auteur();
                unAuteur.Num = Convert.ToInt16(monReader["num"]);
                unAuteur.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string;
                unAuteur.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string;
                unAuteur.Nationalite = monReader["nationalite"] == DBNull.Value ? "" : monReader["nationalite"] as string;
                lesAuteurs.Add(unAuteur); 

            }
            monReader.Close();
            Connection.MaConnection.Close();
            return lesAuteurs;
             }
            public static Auteur DonneAuteurParId(int id)
            {
            return null;
            }
            public static bool ModifierAuteur(Auteur a)
            {
            return false;
            }
            public static bool AjouterAuteur(Auteur a)
            {
            return false;
             }
            public static bool SupprimerAuteur(Auteur a)
            {
            return false;
            }
    }
}
