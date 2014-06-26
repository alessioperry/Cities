namespace BusinessLogic
{
    public class City
    {
        private readonly string name;

        public City(string name)
        {
            this.name = name;
        }

        public string Name()
        {
            return name;
        }
    }
}
