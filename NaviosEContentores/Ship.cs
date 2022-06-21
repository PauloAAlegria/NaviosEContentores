using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class Ship
    {
        private string Name;
        private int Number;
        private int MaxContainers;
        private int MaxExplosive;
        private int MaxChemical;
        private int mRegular;
        private int mChemical;
        private int mExplosive;
        private List<Container> Containers1;

        public Ship(string Name, int Number, int MaxContainers, int MaxExplosive, int MaxChemical)
        {
            this.Name = Name;
            this.Number = Number;
            this.MaxContainers = MaxContainers;
            this.MaxExplosive = MaxExplosive;
            this.MaxChemical = MaxChemical;
            mRegular = 0;
            mChemical = 0;
            mExplosive = 0;
            Containers1 = new List<Container>();
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public int GetNumber()
        {
            return Number;
        }
        public void SetNumber(int Number)
        {
            this.Number = Number;
        }

        public int GetMaxContainers()
        {
            return MaxContainers;
        }
        public void SetMaxContainers(int MaxContainers)
        {
            this.MaxContainers = MaxContainers;
        }

        public int GetMaxExplosive()
        {
            return MaxExplosive;
        }
        public void SetMaxExplosive(int MaxExplosive)
        {
            this.MaxExplosive = MaxExplosive;
        }

        public int GetMaxChemical()
        {
            return MaxChemical;
        }
        public void SetMaxChemical(int MaxChemical)
        {
            this.MaxChemical = MaxChemical;
        }

        public void AddContainers(Container c)
        {
            if(Containers1.Count == MaxContainers)
            {
                throw new Exception("\nNúmero Máximo de Contentores Atingido!");
            }
            if (c is Explosive)
            {
                if (mExplosive < MaxExplosive)
                {
                    c.SetShipNumber(Number);
                    Containers1.Add(c);
                    mExplosive++;
                }
                else
                {
                    throw new Exception("\nAtingiu Limite Máximo de Contentores Explosivos!");
                }
            }
            else if (c is Chemical)
            {
                if (mChemical < MaxChemical)
                {
                    c.SetShipNumber(Number);
                    Containers1.Add(c);
                    mChemical++;
                }
                else
                {
                    throw new Exception("\nAtingiu Limite Máximo de Contentores Quimicos!");
                }            
            }
            else
            {
                c.SetShipNumber(Number);
                Containers1.Add(c);
                mRegular++;
            }
        }

        public void RemoveContainers(Container c)
        {
            Containers1.Remove(c);
        }

        public List<Container> GetContainersList()//metodo para contar os contentores do navio
        {
            return Containers1;
        }
        public void SetContainersList(List<Container> Containers)
        {
            this.Containers1 = Containers;
        }







        public override string ToString()
        {
            string s = "Nome: " + Name;
            s += "\nNumero: " + Number;
            s += "\nMaximo de Contentores: " + MaxContainers;
            s += "\nContentores Explosivos: " + MaxExplosive;
            s += "\nContentores Quimicos: " + MaxChemical;
            s += "\n-------------------------";
            foreach (Container c in Containers1)
            {
                s += c + "\n";
            }
            return s;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Ship)) return false;
            Ship s = (Ship)obj;
            bool result = this.Name.Equals(s.Name) &&
                this.Number == s.Number &&
                this.MaxContainers == s.MaxContainers &&
                this.MaxExplosive == s.MaxExplosive &&
                this.MaxChemical == s.MaxChemical;
            return result;
        }
    }
}
