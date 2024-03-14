using System;
using System.Collections.Generic;

namespace CountryStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new List<ICountry>();

            Console.WriteLine("Welcome to the country assessment program!");
            Console.WriteLine("==========================================");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nEnter information about country {i + 1}:");
                Console.Write("Country name: ");
                string name = Console.ReadLine();

                var country = new CountryInMemory(name);
                countries.Add(country);

                Console.Write("How would you rate your overall impression of this country (scale 1-10): ");
                float impressions = float.Parse(Console.ReadLine());
                country.AddImpressions(impressions);

                Console.Write("How do you rate the nightlife in this country (scale 1-10): ");
                float nightlife = float.Parse(Console.ReadLine());
                country.AddNightlife(nightlife);

                Console.Write("How do you rate the local food in this country (scale 1-10): ");
                float localFood = float.Parse(Console.ReadLine());
                country.AddLocalFood(localFood);

                Console.Write("Is the country expensive? (1 - very expensive, 10 - very cheap): ");
                float costOfLiving = float.Parse(Console.ReadLine());
                country.AddCostOfLiving(costOfLiving);
            }

            // Display statistics for each country
            foreach (var country in countries)
            {
                Console.WriteLine($"\nStatistics for {country.Name}:");
                Console.WriteLine($"Average impressions: {country.GetImpressionsStatistics().Average}");
                Console.WriteLine($"Average nightlife: {country.GetNightlifeStatistics().Average}");
                Console.WriteLine($"Average local food: {country.GetLocalFoodStatistics().Average}");
                Console.WriteLine($"Average cost of living: {country.GetCostOfLivingStatistics().Average}");
            }
        }
    }
}

