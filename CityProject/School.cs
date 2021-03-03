namespace CityProject
{
    class School : Building
    {
        private int nrPeople;
        public School(int size, string address) : base(size, address)
        {
            this.nrPeople = size * 4;
        }
    }
}
