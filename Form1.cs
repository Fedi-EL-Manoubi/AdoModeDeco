using MySql.Data.MySqlClient;

namespace AdoTpFedi
{
    public partial class Form_ListeAuteur : Form
    {
        List<Auteur> LesAuteurs = new List<Auteur>();

        public Form_ListeAuteur()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                dgv_ListeAuteur.Rows.Clear();
  
                while (monReader.Read())
                {
                    dgv_ListeAuteur.Rows.Add(
                        monReader["num"].ToString(),
                        monReader["nom"].ToString(),
                        monReader["prenom"].ToString(),
                        monReader["nationalite"].ToString()
                        );


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur :" + ex.Message);
            }
            finally
            {
                monReader.Close();
                Connection.MaConnection.Close();
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_ListeAuteur.SelectedRows[0].Cells[0].Value.ToString());
            Form_FicheAuteur frm = new Form_FicheAuteur(false, element);
            frm.Show();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_ListeAuteur.SelectedRows[0].Cells[0].Value.ToString());
            Form_FicheAuteur frm = new Form_FicheAuteur(true, element);
            frm.Show();
            RemplirListe();
            dgv_ListeAuteur.Refresh(); 
        }
    }
} 