namespace CountryStatistics
{
    public abstract class CountryBase : ICountry
    {
        public string Name { get; private set; }

        protected CountryBase(string name)
        {
            Name = name;
        }

        public abstract void AddImpressions(float impressions);
        public abstract void AddNightlife(float nightlife);
        public abstract void AddLocalFood(float localFood);
        public abstract void AddCostOfLiving(float costOfLiving);

        public abstract Statistics GetImpressionsStatistics();
        public abstract Statistics GetNightlifeStatistics();
        public abstract Statistics GetLocalFoodStatistics();
        public abstract Statistics GetCostOfLivingStatistics();
    }
}
