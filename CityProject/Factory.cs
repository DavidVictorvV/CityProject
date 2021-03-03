namespace CityProject
{
    class Factory : Building
    {
        private int nrPeople, nrTools;

        public Factory(int size, string address) : base(size, address)
        {
            this.nrPeople = size * 6;
        }
    }
}
