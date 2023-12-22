using AdoTpDeco;
using AdoTpFedi;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;





internal static class ManagerAuteurHelpers
{
    public static void ConfigurerDataGridView(DataGridView dataGridView)
    {
        // Configurer les colonnes du DataGridView
        dataGridView.AutoGenerateColumns = false;

        // Créer et configurer les colonnes
        DataGridViewTextBoxColumn colonneNom = new DataGridViewTextBoxColumn
        {
            Name = "Nom",
            DataPropertyName = "Nom",
            HeaderText = "Nom"
        };

        DataGridViewTextBoxColumn colonnePrenom = new DataGridViewTextBoxColumn
        {
            Name = "Prenom",
            DataPropertyName = "Prenom",
            HeaderText = "Prénom"
        };

        // Ajouter les colonnes au DataGridView
        dataGridView.Columns.AddRange(colonneNom, colonnePrenom);

        // Configurer le BindingSource
        BindingSource votreBindingSource = new BindingSource();
        votreBindingSource.DataSource = ManagerAuteur.DonneAuteurs();

        // Lier le BindingSource au DataGridView
        dataGridView.DataSource = votreBindingSource;

        // Rafraîchir le DataGridView
        dataGridView.Refresh();
    }
     
    public static Auteur DonneAuteurParId(int id)
    {
        MySqlCommand maRequete;
        MySqlDataReader monReader;
        Connection.MaConnection.Open();

        maRequete = Connection.MaConnection.CreateCommand();
        maRequete.CommandText = "SELECT * FROM auteur WHERE num = @id";
        maRequete.Parameters.AddWithValue("@id", id);

        monReader = maRequete.ExecuteReader();

        Auteur auteur = null;

        if (monReader.Read())
        {
            auteur = new Auteur
            {
                Num = Convert.ToInt32(monReader["num"]),
                Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string,
                Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string,
                Nationalite = monReader["nationalite"] == DBNull.Value ? "" : monReader["nationalite"] as string
            };
        }

        monReader.Close();
        Connection.MaConnection.Close();

        return auteur;
    }
}
