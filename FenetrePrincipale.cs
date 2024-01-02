namespace GestionTicket
{
    public partial class FenetrePrincipale : Form
    {
        List<Spectacle> listeSpectacle = new List<Spectacle>();
        Utilisateur utilisateurActuel = new Utilisateur();

        public FenetrePrincipale()
        {
            InitializeComponent();
            LoadFromDatabase();
        }

        private void LoadFromDatabase()
        {
            using (var context = new SpectacleContext())
            {
                context.Database.EnsureCreated();

                listeSpectacle = context.Spectacles.ToList();
                utilisateurActuel = context.Utilisateurs.ToList()[0];

                foreach (var spectacle in listeSpectacle)
                {
                    bool reserve = false;

                    foreach (var Billet in utilisateurActuel.HistoriqueReservations)
                    {
                        if (spectacle.Equals(Billet.Spectacle))
                            reserve = Billet.StatutReservation;
                    }

                    gridSpectacle.Rows.Add(reserve, spectacle.Titre, spectacle.Lieu, spectacle.Date.ToString("dd/mm/yyyy"));
                }
            }
        }

        private void sectionVideo_Click(object sender, EventArgs e)
        {
            gridSpectacle.Hide();
            buttonReserver.Hide();
            buttonSpectacle.FlatAppearance.BorderColor = default;
            buttonSpectacle.FlatAppearance.BorderSize = 1;
            buttonSpectacle.Font = new Font(buttonSpectacle.Font, FontStyle.Regular);
            buttonTicket.FlatAppearance.BorderColor = Color.ForestGreen;
            buttonTicket.FlatAppearance.BorderSize = 3;
            buttonTicket.Font = new Font(buttonTicket.Font, FontStyle.Bold);
        }

        private void sectionSpectacle_Click(object sender, EventArgs e)
        {
            gridSpectacle.Show();
            buttonReserver.Show();
            buttonTicket.FlatAppearance.BorderColor = default;
            buttonTicket.FlatAppearance.BorderSize = 1;
            buttonTicket.Font = new Font(buttonTicket.Font, FontStyle.Regular);
            buttonSpectacle.FlatAppearance.BorderColor = Color.ForestGreen;
            buttonSpectacle.FlatAppearance.BorderSize = 3;
            buttonSpectacle.Font = new Font(buttonSpectacle.Font, FontStyle.Bold);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Voulez-vous vraiment quitter ?",
                "Confirmation",
                MessageBoxButtons.OKCancel
            );
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void boutonReserver_Click(object sender, EventArgs e)
        {
            int selectedCheckboxCount = 0;
            List<DataGridViewRow> rowsList = new List<DataGridViewRow>();

            // Iterate through the cells in the checkbox column and count the checked ones
            foreach (DataGridViewRow row in gridSpectacle.Rows)
            {
                if (row.Cells["reservation"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    if ((bool)checkBoxCell.Value)
                    {
                        rowsList.Add(row);
                        selectedCheckboxCount++;
                    }
                }
            }

            var result = MessageBox.Show(
                "Voulez-vous vraiment réserver ?",
                "Confirmation",
                MessageBoxButtons.OKCancel
            );

            if (result == DialogResult.OK && selectedCheckboxCount > 0)
            {
                MessageBox.Show(
                    $"Confirmer la réservation pour les spectacles suivants : \n\n {rowsList[0].Cells["nom"].Value.ToString()}",
                    "Confirmation",
                    MessageBoxButtons.OKCancel
                );
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner au moins un spectacle.");
            }
        }

        private void gridSpectacle_SelectionChanged(object sender, EventArgs e)
        {
            gridSpectacle.ClearSelection();
        }
    }
}
