using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class Regular : Container
    {
        private string Description;
        private string IsRefrigerated;

        public Regular(int Number, string Destination, float Weight, string Description, string IsRefrigerated)
        {
            this.Number = Number;
            this.Destination = Destination;
            this.Weight = Weight;
            this.Description = Description;
            this.IsRefrigerated = IsRefrigerated;
        }

        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string Description)
        {
            this.Description=Description;
        }

        public string GetIsRefrigerated()
        {
            return IsRefrigerated;
        }
        public void SetIsRefrigerated(string IsRefrigerated)
        {
            this.IsRefrigerated=IsRefrigerated;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "Descrição" + Description;
            s += "\nÉ Refrigerado" + IsRefrigerated;
            s += "\n---------------------";
            return s;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Container)) return false;
            Regular s = (Regular)obj;
            bool result = this.Number.Equals(s.Number) &&
                this.Destination == s.Destination &&
                this.Weight == s.Weight &&
                this.Description == s.Description &&
                this.IsRefrigerated == s.IsRefrigerated;
            return result;
        }
    }
}
