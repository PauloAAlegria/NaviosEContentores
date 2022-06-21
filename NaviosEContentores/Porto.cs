using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    internal class Porto
    {
        private string Name;
        private List<Ship> Ships;
        private List<Container> Containers;

        public Porto(string Name)
        {
            this.Name = Name;
            Ships = new List<Ship>();
            Containers = new List<Container>();
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name=Name;
        }

        public void AddShips(Ship sh)
        {
            Ships.Add(sh); 
        }

        public void RemoveShips(Ship sh)
        {
            Ships.Remove(sh);
        }

        public void AddContainers(Container c)
        {
            Containers.Add(c);
        }

        public void RemoveContainers(Container c)
        {
            Containers.Remove(c);
        }

        public List<Ship> GetshipsList()
        {
            return Ships;
        }
        public void SetshipList(List<Ship> ships)
        {
            this.Ships = ships;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "Nome" + Name;
            s += "\n--------------";
            return s;
        }


    }
}
