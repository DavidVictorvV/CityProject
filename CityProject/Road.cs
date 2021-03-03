using System;
using System.Linq;

namespace CityProject
{
    class Road : City
    {
        private Building[] houseOnRoad;
        private int nrOfItems = 0;
        private int nrLanes;
        private Boolean isOneWayRoad;
        private string roadName;
        public Road(string roadName, int size, int nrLanes, Boolean isOneWayRoad) : base(size)
        {
            this.roadName = roadName;
            this.nrLanes = nrLanes;
            this.isOneWayRoad = isOneWayRoad;
            this.houseOnRoad = new Building[6];
        }

        public void addBuilding(Building b)
        {
            Boolean spotFound = false;
            for (int i = 0; i < houseOnRoad.Length; i++)
            {
                if (houseOnRoad[i] == null)
                {
                    nrOfItems++;
                    houseOnRoad[i] = b;
                    spotFound = true;
                    break;
                }

            }
            if (spotFound == false)
            {
                Console.WriteLine("There are no more place for houses on " + this + " for the building: " + b.getAddress());
            }
        }

        public void removeBuilding(Building b)
        {
            for (int i = 0; i < nrOfItems; i++)
            {
                if (houseOnRoad[i].getAddress() == b.getAddress() && houseOnRoad[i].getSize() == b.getSize())
                {
                    houseOnRoad = houseOnRoad.Where((source, index) => index != i).ToArray();
                    nrOfItems--;
                }
            }
        }

        public void showBuilding()
        {
            Console.WriteLine(roadName + ":");
            int roadLength = 50;
            string result = "";
            for (int i = 0; i < nrOfItems / 2; i++)
            {
                result += houseOnRoad[i].getAddress() + "  ";
                if (i + 1 == nrOfItems / 2)
                {
                    result += "\n";
                }
            }
            for (int j = 0; j < roadLength; j++)
            {
                result += "-";
            }
            result += "\n";
            for (int j = 0; j < roadLength / 3; j++)
            {
                result += "-  ";
            }
            result += "\n";
            for (int j = 0; j < roadLength; j++)
            {
                result += "-";
            }
            result += "\n";

            for (int i = nrOfItems / 2; i < nrOfItems; i++)
            {
                result += houseOnRoad[i].getAddress() + "  ";
            }
            Console.WriteLine(result + "\n");
        }

    }
}
