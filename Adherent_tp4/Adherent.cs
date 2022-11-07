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

        public Adherent(string nom, string prenom, string mail, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.dateNaissance = dateNaissance;
            mesActivites = new List<Activite>();

        }
        public void AjouterActivite(Activite a) { mesActivites.Add(a); }
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

            return nom + " " + prenom + " " + this.GetAge() + " ans";
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
    }
}
