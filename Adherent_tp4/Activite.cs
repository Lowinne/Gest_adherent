using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adherent_tp4
{
    internal class Activite
    {
        private DateTime dateDebut;
        private string nom;
        private float tarif;
        private String type;

        public Activite(string nom, float tarif, string type, DateTime dateDebut)
        {
            this.dateDebut = dateDebut;
            this.nom = nom;
            this.tarif = tarif;
            this.type = type;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) { return false; }
            else { 
                Activite a = (Activite)obj;
                return this.nom.Equals( a.nom); 
            }
        }
        public override String ToString() { return nom+ " pour " + tarif+"€ au "+dateDebut; }
    }
}
