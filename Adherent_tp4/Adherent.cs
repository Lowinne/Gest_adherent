using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adherent_tp4
{
    internal class Adherent
    {
        private String nom;
        private String prenom;
        private String mail;
        private DateTime dateNaissance;
        private List<Activite> mesActivites;
        private float budgetMax;

        public Adherent(string nom, string prenom, string mail, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.dateNaissance = dateNaissance;
            mesActivites = new List<Activite>();
            budgetMax = 50;

        }
        public Adherent(string nom, string prenom, string mail, DateTime dateNaissance, float budgetMax)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.dateNaissance = dateNaissance;
            mesActivites = new List<Activite>();
            this.budgetMax = budgetMax;

        }
        public void AjouterActivite(Activite a) 
        {
            if (a.GetTarif() <= Activite.GetTarifMax())
            {
                mesActivites.Add(a);
            }
            else { MessageBox.Show("Methode : AjouterActivite : 'Le tarif de l'activite depasse le tarif max'"); }
             
        }
        /*public override bool Equals(Object obj)
        {
            if ((obj == null) || this.GetType().Equals(obj.GetType())) { return false; }
            else
            {
                Adherent a = (Adherent)obj;
                return this.nom == a.nom;
            }
        }*/
        public int GetAge()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dateNaissance.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            return age;
        }
        public DateTime GetDateNaissance() { return dateNaissance; }
        public String GetMail() { return mail; }
        public List<Activite> GetMesActivite() { return mesActivites; }
        public String GetNom() { return nom; }
        public String GetPrenom() { return prenom; }
        public void SetMail(String email) { this.mail = email; }
        public void SupprimerActivite(Activite ac) { mesActivites.Remove(ac); }
        /*public override String ToString()
        {

            return "nom : " + nom + ", prenom : " + prenom + " email : " + mail + " age : " + this.GetAge();

        }*/
        public override String ToString()
        {

            return nom + " " + prenom + " " + this.GetAge() + " ans/Budget "+this.GetBudgetMax()+" cout "+this.GetCoutActivite();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else
            {
                Adherent a = (Adherent)obj;
                return this.nom.Equals(a.nom);
            }
        }
        public float GetBudgetMax() { return budgetMax; }

        public void SetBudgetMax(float budgetMax) { this.budgetMax = budgetMax; }

        public float GetCoutActivite()
        {
            float som = 0;
            for (int i = 0; i < mesActivites.Count; i++)
            {
                
                som += mesActivites[i].GetTarif();
                

            }
            return som;
        }
    }
}
