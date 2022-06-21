using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class Explosive : Container
    {
        private string Type;
        private string IsPlasticExplosive;

        public Explosive(int Number, string Destination, float Weight, string Type, string IsPlasticExplosive)
        {
            this.Number = Number;
            this.Destination = Destination;                
            this.Weight = Weight;
            this.Type = Type;
            this.IsPlasticExplosive = IsPlasticExplosive;
        }

        public string GetType()
        {
            return Type;
        }
        public void SetType(string Type)
        {
            this.Type=Type;
        }

        public string GetIsPlasticExplosive()
        {
            return IsPlasticExplosive;
        }
        public void SetIsPlasticExplosive(string IsPlasticExplosive)
        {
            this.IsPlasticExplosive=IsPlasticExplosive;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "Tipo" + Type;
            s += "\nÉ Explosivo Plástico" + IsPlasticExplosive;
            s += "\n---------------------";
            return s;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Container)) return false;
            Explosive s = (Explosive)obj;
            bool result = this.Number.Equals(s.Number) &&
                this.Destination == s.Destination &&
                this.Weight == s.Weight &&
                this.Type == s.Type &&
                this.IsPlasticExplosive == s.IsPlasticExplosive;
            return result;
        }
    }
}
