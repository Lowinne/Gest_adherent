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
        private String nom;
        private float tarif;
        private String type;
        private static float tarifMax =50;

        public Activite(string nom, float tarif, string type, DateTime dateDebut)
        {
            this.dateDebut = dateDebut;
            this.nom = nom;
            this.tarif = tarif;
            if(tarif > tarifMax)
            {
                this.tarif = tarifMax;
                MessageBox.Show("Suite à un exces, le tarif de l'activité a été plafonner au tarif max");
            }
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
        public float GetTarif() { return tarif; }
        public static float GetTarifMax() { return tarifMax; }

        public static void setTarifMax(float t) { tarifMax = t; }

        public override String ToString() { return nom+ " pour " + tarif+"€ au "+dateDebut; }

        
    }
}
