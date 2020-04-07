using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{

    /*
     Suppose Andy and Doris want to choose a restaurant for dinner, and they both have a
     list of favorite restaurants represented by strings.
    You need to help them find out their common interest with the least list index sum. 
    If there is a choice tie between answers, 
    output all of them with no order requirement. You could assume there always exists an answer.
     * Input:
["Shogun", "Tapioca Express", "Burger King", "KFC"]
["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"]
Output: ["Shogun"]
Explanation: The only restaurant they both like is "Shogun".
     */
    public class MinIndexSumOfTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            if (list1.Length < list2.Length)
            {
                FindRestaurant(list2, list1);
            }

            Dictionary<int, List<string>> restaurantMapper = new Dictionary<int, List<string>>();

            for(int list1Indexer=0; list1Indexer<list1.Length; list1Indexer++)
            {
                for (int list2Indexer = 0; list2Indexer < list2.Length; list2Indexer++)
                {
                    if (list1[list1Indexer].Equals(list2[list2Indexer], StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (!restaurantMapper.ContainsKey(list1Indexer + list2Indexer))
                        {
                            restaurantMapper.Add(list1Indexer +list2Indexer, new List<string>());
                        }

                        restaurantMapper[list1Indexer + list2Indexer].Add(list1[list1Indexer]);
                    }
                }
            }
            int min = Int32.MaxValue;
            
            foreach (var keyValuePair in restaurantMapper)
            {
                if (min > keyValuePair.Key)
                {
                    min = keyValuePair.Key;
                }    
            }

            return restaurantMapper[min].ToArray();
        }
    }
}
