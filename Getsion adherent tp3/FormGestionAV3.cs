namespace Gestion_adhérent_tp3
{
    public partial class FormGestionAV3 : Form
    {
        public FormGestionAV3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtAdhe.Checked == true) {
                tabControlAdheGest.TabPages.Remove(tabGest);
                tabControlAdheGest.TabPages.Add(tabAdhe);
            }
            else
            {
                tabControlAdheGest.TabPages.Remove(tabAdhe);
                tabControlAdheGest.TabPages.Add(tabGest);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listAdhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String sadh = (String)listAdhe.SelectedItem;
            String nom, prenom, mail;

            if (sadh != null)
            {

                int pos1 = sadh.IndexOf(',');
                int pos2 = sadh.IndexOf(',', pos1 + 1);

                nom = sadh.Substring(0, pos1);
                prenom = sadh.Substring(pos1 + 1, pos2 - pos1 - 1);
                mail = sadh.Substring(pos2 + 1);

                labAdheNom.Text = nom;
                labAdhePrenom.Text = prenom;
                TextBMail.Text = mail;

                textBoxNomG.Text = nom;
                textBoxPreG.Text = prenom;
                textBoxMailG.Text = mail;
            }
        }

        private void buttModMail_Click(object sender, EventArgs e)
        {
         

            listAdhe.Items.Remove(listAdhe.SelectedItem);

            String newMail = labAdheNom.Text+","+labAdhePrenom.Text+","+TextBMail.Text;
            

            listAdhe.Items.Add(newMail);
        }

        private void GestAdhe_Load(object sender, EventArgs e)
        {
            tabControlAdheGest.TabPages.Remove(tabGest);
            listAdhe.Items.Add("boris,prince,mail");
            listAdhe.Items.Add("01,3456,89");
            listAdhe.Items.Add("aaaaa,bbbbb,maila");

        }

        private void tabAdhe_Click(object sender, EventArgs e)
        {

        }

        private void buttSuppAdheGest_Click(object sender, EventArgs e)
        {
            listAdhe.Items.Remove(listAdhe.SelectedItem);
        }

        private void buttAjoutAdheGest_Click(object sender, EventArgs e)
        {

            String newAdhe = textBoxNomG.Text + "," + textBoxPreG.Text + "," + textBoxMailG.Text;
            listAdhe.Items.Add(newAdhe);

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Gest_Adherent_tp3
            // 
            this.ClientSize = new System.Drawing.Size(288, 253);
            this.Name = "Gest_Adherent_tp3";
            this.ResumeLayout(false);

        }
    }
}