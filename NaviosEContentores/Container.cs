using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class Container
    {
        public int ShipNumber;
        public int Number;
        public string Destination;
        public float Weight;

        public Container(){}

        public int GetShipNumber()
        {
            return ShipNumber;
        }
        public void SetShipNumber(int ShipNumber)
        {
            this.ShipNumber = ShipNumber;   
        }

        public int GetNumber()
        {
            return Number;
        }
        public void SetNumber(int Number)
        {
            this.Number = Number;
        }

        public string GetDestination()
        {
            return Destination;
        }
        public void SetDestination(string Destination)
        {
            this.Destination = Destination;
        }

        public float GetWeight()
        {
            return Weight;
        }
        public void SetWeight(float Weight)
        {
            this.Weight = Weight;
        }

        public override string ToString()
        {
            string s = "ShipNumber" + ShipNumber;
            s += "\nNúmero" + Number;
            s += "\nDestino" + Destination;
            s += "\nPeso" + Weight;
            s += "\n-----------------------";
            return s;
        }



    }
}
