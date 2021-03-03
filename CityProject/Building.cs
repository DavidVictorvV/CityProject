using System;

namespace CityProject
{
    class Building : City
    {
        private Car[] carParked;
        private int parkingSlots = 0;
        private string address;
        private int pos = 0;
        private int size;
        public Building(int size, string address) : base(size)
        {
            this.size = size;
            this.address = address;
            if (size >= 50)
            {
                this.parkingSlots = (size / 15);
            }
            this.carParked = new Car[parkingSlots];
        }

        public string getAddress()
        {
            return address;
        }

        public int getSize()
        {
            return size;
        }

        public Boolean canPark()
        {
            if (pos < parkingSlots)
            {
                return true;
            }
            else
                return false;
        }

        public void addCar(Car c)
        {
            carParked[pos] = c;
            pos++;
        }

        public int getParkingSlots()
        {
            return parkingSlots;
        }

        public void getParkedCars()
        {
            string result = this.getAddress() + " has the following cars parked: ";
            for (int i = 0; i < carParked.Length; i++)
            {
                result += carParked[i].getRegNr() + " , ";
            }

            if (carParked.Length > 0)
                Console.WriteLine(result);
            else
                Console.WriteLine("There are no cars parked at the building: " + this.getAddress());
        }
    }
}
