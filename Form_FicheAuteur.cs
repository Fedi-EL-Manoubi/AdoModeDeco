using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AdoTpFedi
{
    public partial class Form_FicheAuteur : Form
    {
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        private int numAuteur;
        public Form_FicheAuteur(bool modification, int num)
        {
            InitializeComponent();
            numAuteur = num; 
            try
            {
                Connection.MaConnection.Open();
                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "SELECT * FROM auteur WHERE num=@paramNum";
                maRequete.Parameters.AddWithValue("@paramNum", num);

                monReader = maRequete.ExecuteReader();
                if (monReader.Read())
                {
                    textBox_num.Text = num.ToString();
                    textBox_nom.Text = monReader["nom"].ToString();
                    textBox_prenom.Text = monReader["prenom"].ToString();
                    textBox_natio.Text = monReader["nationalite"].ToString();
                }
                else
                {
                    MessageBox.Show("Erreur: auteur introuvable");
                }

                if (modification == false)
                {
                    textBox_nom.Enabled = false;
                    textBox_prenom.Enabled = false;
                    textBox_natio.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur :" + ex.Message);
                throw;
            }
            finally
            {
                monReader.Close();
                Connection.MaConnection.Close();
            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            if (ControleSaisies() == true)
            {
                maRequete.CommandText = "update auteur set " +
                    "nom=@paramNom, prenom=@paramPrenom, nationalite=@paramNation where num=@paramNum";
                maRequete.Parameters.Clear();
                maRequete.Parameters.AddWithValue("@paramNom", textBox_nom.Text);
                maRequete.Parameters.AddWithValue("@paramPrenom", textBox_prenom.Text);
                maRequete.Parameters.AddWithValue("@paramNation", textBox_natio.Text);
                maRequete.Parameters.AddWithValue("@paramNum", textBox_num.Text);
                try
                {
                    Connection.MaConnection.Open();
                    int resultat=maRequete.ExecuteNonQuery();
                    if (resultat > 0)
                    {
                        MessageBox.Show("L'auteur a bien été mis a jour !");
                    }
                    else
                    {
                        MessageBox.Show("L'erreur s'est produite, l'auteur n'a pas été mis a jour.");
                    }



                }
                catch ( Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connection.MaConnection.Close();
                    this.Close();
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ControleSaisies()
        {
            bool controle = true;
            if (textBox_nom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if (textBox_prenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prénom");
                controle = false;
            }
            if (textBox_natio.Text == "")
            {
                MessageBox.Show("Vous devez saisir une nationalité");
                controle = false;
            }
            return controle;
        }
    }

}
