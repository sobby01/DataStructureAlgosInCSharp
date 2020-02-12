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
    }
}
