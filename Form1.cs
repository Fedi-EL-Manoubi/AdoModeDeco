using AdoTpDeco;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
                LesAuteurs = ManagerAuteur.DonneAuteurs();

            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur :" + ex.Message);
            }
            finally
            {

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

        private void Form_ListeAuteur_Load(object sender, EventArgs e)
        {

        }

        private void dgv_ListeAuteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bs_CurrentChanged(object sender, EventArgs e)
        {

        }
        BindingSource bindingSource1 = new BindingSource();
        


    }
} 