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
        private String email;
        private DateTime dateNaissance;

        public Adherent(string nom, string prenom, string email, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.dateNaissance = dateNaissance;
        }
        public String GetNom() { return nom; }
        public String GetPrenom() { return prenom; }
        public String GetEmail() { return email; }
        public void SetMail(String email) { this.email = email; }
        public int GetAge() {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dateNaissance.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            return age;
        }
        
        public override String ToString() { 
            
            return "nom : " + nom + ", prenom : " + prenom + " email : " + email + " age : " + this.GetAge(); 
        
        }
        
        
    }
}
