namespace CountryStatistics
{
    public interface ICountry
    {
        string Name { get; }

        void AddImpressions(float impressions);
        void AddNightlife(float nightlife);
        void AddLocalFood(float localFood);
        void AddCostOfLiving(float costOfLiving);

        Statistics GetImpressionsStatistics();
        Statistics GetNightlifeStatistics();
        Statistics GetLocalFoodStatistics();
        Statistics GetCostOfLivingStatistics();
    }
}
