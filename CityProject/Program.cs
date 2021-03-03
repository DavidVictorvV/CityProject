namespace CityProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Building h1 = new House(50, "House1");
            Building h2 = new House(15, "House2");
            Building h3 = new House(86, "House3");
            Building f1 = new Factory(162, "Factory1");
            Building f2 = new Factory(24, "Factory1");
            Building s1 = new School(100, "School1");

            Park p = new Park(1000, "Park1");

            Road r1 = new Road("Str. Gh. Doja", 100, 2, false);
            Road r2 = new Road("Str. Livezilor", 300, 4, true);

            r1.addBuilding(h1);
            r1.addBuilding(h2);
            r1.addBuilding(h3);
            r1.addBuilding(f1);
            r1.addBuilding(f2);
            r2.addBuilding(s1);
            r2.addBuilding(h1);

            r1.showBuilding();

            r1.removeBuilding(h3);

            r1.showBuilding();
            r2.showBuilding();


            Car c1 = new Car(5, 1234);
            Car c2 = new Car(5, 123);
            Car c3 = new Car(5, 12);
            Car c4 = new Car(5, 1);
            Car c5 = new Car(5, 5215);
            Car c6 = new Car(5, 52512);

            c1.parkCar(h1);
            c2.parkCar(h1);
            c3.parkCar(h1);
            c1.parkCar(h2);
            c2.parkCar(h3);

            h1.getParkedCars();
            h2.getParkedCars();

        }
    }
}
