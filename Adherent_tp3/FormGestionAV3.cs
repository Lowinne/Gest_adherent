namespace Adherent_tp4
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
            
            Adherent ad = (Adherent)listAdhe.SelectedItem;
            

            if (ad != null)
            {
                
                labAdheNom.Text = ad.GetNom();
                labAdhePrenom.Text = ad.GetPrenom();
                TextBMail.Text = ad.GetEmail();
                labAdheAge.Text = ""+ad.GetAge(); ;

                textBoxNomG.Text = ad.GetNom();
                textBoxPreG.Text = ad.GetPrenom();
                textBoxMailG.Text = ad.GetEmail();
                textBoxAgeG.Text = "";

            }
        }

        private void buttModMail_Click(object sender, EventArgs e)
        {

            
            Adherent ad = (Adherent)listAdhe.SelectedItem;
            listAdhe.Items.Remove(listAdhe.SelectedItem);

            ad.SetMail(TextBMail.Text);
            listAdhe.Items.Add(ad);

        }

        private void GestAdhe_Load(object sender, EventArgs e)
        {
            tabControlAdheGest.TabPages.Remove(tabGest);
            labAdheAge.Text = "";
            labAdheNom.Text = "";
            labAdhePrenom.Text = "";
            labAdheMail.Text = "";
            TextBMail.Text = "";
            textBoxNomG.Text = "";
            textBoxPreG.Text = "";
            textBoxAgeG.Text = "";
            textBoxMailG.Text = "";

            

            listAdhe.Items.Add(new Adherent("Prince","Boris","boris.prince@gmail.com",new DateTime(1999,05,03)));
           

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
            
            Adherent objAd = new Adherent(textBoxNomG.Text, textBoxPreG.Text, textBoxMailG.Text, Convert.ToDateTime(textBoxAgeG.Text));
            listAdhe.Items.Add((Adherent)objAd);

            

        }

        
    }
}