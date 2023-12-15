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
            public static DonneAuteurDuReader(MySqlDataReader monreader)
            {

            }
            public static List<Auteur> DonneAuteurs()
            {
                  MySqlCommand maRequete;
                  MySqlDataReader monReader;
                  Connection.MaConnection.Open();
                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from auteur order by nom";
                monReader = maRequete.ExecuteReader();
        }
            public static Auteur DonneAuteurParId(int id)
            {

            }
            public static bool ModifierAuteur(Auteur a)
            {

            }
            public static bool AjouterAuteur(Auteur a)
            {

            }
            public static bool SupprimerAuteur(Auteur a)
            {

            }
    }
}
