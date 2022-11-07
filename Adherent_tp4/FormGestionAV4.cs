using System.Net;
using System.Collections.Generic;

namespace Adherent_tp4
{
    public partial class FormGestionAV4 : Form
    {
        private List<Activite> listeActivites;
        public FormGestionAV4()
        {
           
            listeActivites = new List<Activite>();
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtAdhe.Checked == true)
            {
                tabControlAdheGest.TabPages.Remove(tabGest);
                tabControlAdheGest.TabPages.Add(tabAdhe);
            }
            else
            {
                tabControlAdheGest.TabPages.Remove(tabAdhe);
                tabControlAdheGest.TabPages.Add(tabGest);
            }
        }

        

        private void listAdhe_SelectedIndexChanged(object sender, EventArgs e)
        {

            Adherent ad = (Adherent)listBAdhe.SelectedItem;


            if (ad != null)
            {

                labAdheNom.Text = ad.GetNom();
                labAdhePrenom.Text = ad.GetPrenom();
                TextBMail.Text = ad.GetMail();
                labAdheAge.Text = "" + ad.GetAge(); ;

                textBoxNomG.Text = ad.GetNom();
                textBoxPreG.Text = ad.GetPrenom();
                textBoxMailG.Text = ad.GetMail();
                textBoxAgeG.Text = "";

            }
            listBAct.Items.Clear();


            listBAct.Items.AddRange(((Adherent)listBAdhe.SelectedItem).GetMesActivite().ToArray());

        }

        private void buttModMail_Click(object sender, EventArgs e)
        {


            Adherent ad = (Adherent)listBAdhe.SelectedItem;
            listBAdhe.Items.Remove(listBAdhe.SelectedItem);

            ad.SetMail(TextBMail.Text);
            listBAdhe.Items.Add(ad);

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

            Adherent ad1 = new Adherent("Prince", "Boris", "boris.prince@gmail.com", new DateTime(1999, 05, 03));

            listBAdhe.Items.Add(ad1);
            Activite a1 = new Activite("Cycling", (float)25, "Sport", new DateTime(2022, 05, 27));
            listeActivites.Add(a1);
            listeActivites.Add(new Activite("Running",(float) 13, "Sport", new DateTime(2022, 05 , 23)));

            ad1.AjouterActivite(a1);


        }



        private void buttSuppAdheGest_Click(object sender, EventArgs e)
        {
            listBAdhe.Items.Remove(listBAdhe.SelectedItem);
        }

        private void buttAjoutAdheGest_Click(object sender, EventArgs e)
        {

            Adherent objAd = new Adherent(textBoxNomG.Text, textBoxPreG.Text, textBoxMailG.Text, Convert.ToDateTime(textBoxAgeG.Text));
            if (objAd != null) { listBAdhe.Items.Add((Adherent)objAd); MessageBox.Show("Ajout effectué"); }




        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Activite ac = new Activite(textBNomActGest.Text, float.Parse(textBTarifActGest.Text), textBTypeActGest.Text, Convert.ToDateTime(textBoxDateActGest.Text));

            textBResGest.Text = "";
            if (!(listeActivites.Contains(ac)))
            {
                listeActivites.Add(ac);
                textBResGest.Text = ac.ToString();
                MessageBox.Show("Activité ajouté");
            }

        }

        

        private void butAfficheAct_Click(object sender, EventArgs e)
        {
            listBAct.Items.Clear();
            listBAct.Items.AddRange(listeActivites.ToArray());
        }

        

        

        private void buttSuppAdheGest_Click_1(object sender, EventArgs e)
        {
            listBAdhe.Items.Remove(listBAdhe.SelectedItem);
        }

        private void buttAjoutAdheGest_Click_1(object sender, EventArgs e)
        {
            Adherent objAd = new Adherent(textBoxNomG.Text, textBoxPreG.Text, textBoxMailG.Text, Convert.ToDateTime(textBoxAgeG.Text));
            if (objAd != null) { listBAdhe.Items.Add((Adherent)objAd); MessageBox.Show("action effectué"); }
        }

        

       

        

        private void butInscription_Click(object sender, EventArgs e)
        {
            if (!((Adherent)listBAdhe.SelectedItem).GetMesActivite().Contains(((Activite)listBAct.SelectedItem)))
            {
                ((Adherent)listBAdhe.SelectedItem).AjouterActivite(((Activite)listBAct.SelectedItem));
                MessageBox.Show("Inscription effectué");
            }
            else
            {
                MessageBox.Show("Erreur");
            }
        }

        private void butDesincription_Click(object sender, EventArgs e)
        {
            if (((Adherent)listBAdhe.SelectedItem).GetMesActivite().Contains(((Activite)listBAct.SelectedItem)))
            {
                ((Adherent)listBAdhe.SelectedItem).SupprimerActivite(((Activite)listBAct.SelectedItem));
                
                //Reaffichage du tableau nouveau tableau sans l'element supprimer
                listBAct.Items.Clear();
                listBAct.Items.AddRange(((Adherent)listBAdhe.SelectedItem).GetMesActivite().ToArray());
                MessageBox.Show("Desinscription effectué");
            }
            else
            {
                MessageBox.Show("Erreur");
            }
        }

        private void butSupAct_Click(object sender, EventArgs e)
        {   //Supression dans les activités de l'utilisateur.
            for(int i = 0; i < listBAdhe.Items.Count; i++)
            {

                List<Activite> l =((Adherent)listBAdhe.Items[i]).GetMesActivite();
                if (l.Contains((Activite)listBAct.SelectedItem))
                {
                    l.Remove((Activite)listBAct.SelectedItem);
                }
                //listBAct.Items.Remove(listBAct.SelectedItem);
            }

            if (listeActivites.Contains((Activite)listBAct.SelectedItem)) { MessageBox.Show("Found and deleted"); }
            listeActivites.Remove((Activite)listBAct.SelectedItem);
            listBAct.Items.Remove(listBAct.SelectedItem);


        }
    }
}