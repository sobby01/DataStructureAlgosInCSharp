using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class Tour
    {
        public void CalculateTour()
        {
            int noOfCities = Convert.ToInt32(Console.ReadLine());

            Dictionary<string,int> citiesIndexer = new Dictionary<string, int>();

            for (int i = 0; i < noOfCities; i++)
            {
                string city = Console.ReadLine();
                citiesIndexer.Add(city, i+1);
            }

            long[,] costArray = new long[noOfCities,noOfCities];

            for (int i = 0; i < noOfCities; i++)
            {
                string costing = Console.ReadLine();

                if (costing != null)
                {
                    string[] cc = costing.Split(' ');

                    for (int j = 0; j < cc.Length; j++)
                    {
                        costArray[i, j] = Convert.ToInt64(cc[j]);
                    }
                }
            }

            int noOfcitiesGoingToVisit = Convert.ToInt32(Console.ReadLine());

            string[] visitingCities = new string[noOfcitiesGoingToVisit];

            for (int i = 0; i < noOfcitiesGoingToVisit; i++)
            {
                visitingCities[i] = Console.ReadLine();
            }

            long totalCost = 0;
            int lastIndexer = 0;

            for (int i = 0; i < visitingCities.Length; i++)
            {
                citiesIndexer.TryGetValue(visitingCities[i], out var indexer);
                //Find the length of Indexer
                totalCost += costArray[lastIndexer, indexer - 1];
                lastIndexer = indexer-1;
            }

            Console.WriteLine(totalCost);

        }
    }
}
