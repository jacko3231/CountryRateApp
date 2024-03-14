using System;
using System.Collections.Generic;

namespace CountryStatistics
{
    public class CountryInMemory : CountryBase
    {
        private List<float> impressionsList = new List<float>();
        private List<float> nightlifeList = new List<float>();
        private List<float> localFoodList = new List<float>();
        private List<float> costOfLivingList = new List<float>();

        public CountryInMemory(string name) : base(name) { }

        public override void AddImpressions(float impressions)
        {
            impressionsList.Add(impressions);
        }

        public override void AddNightlife(float nightlife)
        {
            nightlifeList.Add(nightlife);
        }

        public override void AddLocalFood(float localFood)
        {
            localFoodList.Add(localFood);
        }

        public override void AddCostOfLiving(float costOfLiving)
        {
            costOfLivingList.Add(costOfLiving);
        }

        public override Statistics GetImpressionsStatistics()
        {
            return CalculateStatistics(impressionsList);
        }

        public override Statistics GetNightlifeStatistics()
        {
            return CalculateStatistics(nightlifeList);
        }

        public override Statistics GetLocalFoodStatistics()
        {
            return CalculateStatistics(localFoodList);
        }

        public override Statistics GetCostOfLivingStatistics()
        {
            return CalculateStatistics(costOfLivingList);
        }

        private Statistics CalculateStatistics(List<float> values)
        {
            var statistics = new Statistics();
            foreach (var value in values)
            {
                statistics.AddScore(value);
            }
            return statistics;
        }
    }
}
