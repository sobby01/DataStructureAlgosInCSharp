using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class GroupAnagrams
    {

        public IList<IList<string>> groupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> mapAnagrams = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                char[] sortedString = str.ToCharArray();
                Array.Sort(sortedString);
                string StringValue = new string(sortedString);
                if (mapAnagrams.ContainsKey(StringValue))
                {
                    IList<string> outPut = new List<string>();
                    mapAnagrams.TryGetValue(StringValue, out outPut);

                    if (outPut.Any())
                    {
                        outPut.Add(str);
                    }
                    mapAnagrams[StringValue] = outPut;
                }
                else
                {
                    IList<string> obj = new List<string>();
                    obj.Add(str);
                    mapAnagrams.Add(StringValue, obj);
                }
            }

            List<IList<string>> outputList = new List<IList<string>>();
            foreach (var mapAnagram in mapAnagrams)
            {
                outputList.Add(mapAnagram.Value);
            }

            return outputList;
        }

        public List<List<int>> anagrams(List<string> A)
        {
            List<List<int>> list = new List<List<int>>();
            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();

            for(int i = 0; i< A.Count; i++)
            {
                char[] arr = A[i].ToCharArray();

                Array.Sort(arr);
                string str = new string(arr);
               
                if (map.ContainsKey(str))
                {
                    map.TryGetValue(str, out List<int> val);
                    val.Add(i + 1);
                    map[str] = val;
                }
                else
                {
                    map.Add(str, new List<int>() { i+1 });
                }
            }

            int indexer = 0;
            foreach(KeyValuePair<string, List<int>> pairs in map)
            {
                if(pairs.Value.Count > 1)
                {
                    list.Add(pairs.Value);
                }
                   
            }

            return list;
        }
    }
}
