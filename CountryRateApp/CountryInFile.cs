using System.IO;
using System;

namespace CountryStatistics
{
    public class CountryInFile : CountryBase
    {
        private const string fileName = "country_scores.txt";

        public CountryInFile(string name) : base(name) { }

        public override void AddImpressions(float impressions)
        {
            WriteScoreToFile(impressions);
        }

        public override void AddNightlife(float nightlife)
        {
            WriteScoreToFile(nightlife);
        }

        public override void AddLocalFood(float localFood)
        {
            WriteScoreToFile(localFood);
        }

        public override void AddCostOfLiving(float costOfLiving)
        {
            WriteScoreToFile(costOfLiving);
        }

        private void WriteScoreToFile(float score)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(score);
            }
        }

        public override Statistics GetImpressionsStatistics()
        {
            return ReadScoresFromFileToList();
        }

        public override Statistics GetNightlifeStatistics()
        {
            return ReadScoresFromFileToList();
        }

        public override Statistics GetLocalFoodStatistics()
        {
            return ReadScoresFromFileToList();
        }

        public override Statistics GetCostOfLivingStatistics()
        {
            return ReadScoresFromFileToList();
        }

        private Statistics ReadScoresFromFileToList()
        {
            var statistics = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (float.TryParse(line, out float score))
                        {
                            statistics.AddScore(score);
                        }
                    }
                }
            }
            return statistics;
        }
    }
}
