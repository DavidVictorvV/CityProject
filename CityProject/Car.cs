using System;

namespace CityProject
{
    class Car : City
    {
        private int registrationNr;
        private Boolean isCarParked = false;
        public Car(int size, int registrationNr) : base(size)
        {
            this.registrationNr = registrationNr;
        }

        public int getRegNr()
        {
            return registrationNr;
        }

        public void parkCar(Building b)
        {
            if (b.canPark() == true && b.getParkingSlots() > 0 && this.isCarParked == false)
            {
                b.addCar(this);
                this.isCarParked = true;

            }
            else if (this.isCarParked == true)
            {
                Console.WriteLine("The car: " + getRegNr() + " is already parked at another house.");
            }
            else
                Console.WriteLine("There are no parking slots for any more cars to park in the house: " + b.getAddress());
        }
    }
}
