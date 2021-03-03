using System;

namespace CityProject
{
    class Park : City
    {
        private int parkingSlots = 0;
        private string name;
        public Park(int size, string name) : base(size)
        {
            if (size >= 100)
            {
                parkingSlots = (size / 10);
            }

        }
        public Boolean canPark()
        {
            if (this.parkingSlots > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
