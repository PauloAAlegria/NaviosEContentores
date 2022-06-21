using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class Chemical : Container
    {
        private string Type;
        
        public Chemical(int Number, string Destination, float Weigth, string Type)
        {
            this.Number = Number;
            this.Destination = Destination; 
            this.Weight = Weigth;
            this.Type = Type;
        }

        public string GetType()
        {
            return Type;
        }
        public void SetType(string Type)
        {
            this.Type=Type;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "Tipo" + Type;
            s += "\n----------------";
            return s;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Container)) return false;
            Chemical s = (Chemical)obj;
            bool result = this.Number.Equals(s.Number) &&
                this.Destination == s.Destination &&
                this.Weight == s.Weight &&
                this.Type == s.Type;
            return result;
        }
    }

    
}
