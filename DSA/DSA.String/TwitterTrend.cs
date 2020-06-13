using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSA.String
{
    public class TwitterTrend
    {
        public class CustomComparer : IComparer<KeyValuePair<string, int>>
        {
            public int Compare(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
            {
                if (a.Value.CompareTo(b.Value) == 0){

                    return a.Key.CompareTo(b.Key);
                }

                return a.Value.CompareTo(b.Value);
            }
        }

        public void ChkTwitterTrends()
        {
            //Max Heap implementation

            //Order by value and 
            string number1 = Console.ReadLine();

            int number = Convert.ToInt32(number1);
            Dictionary<string, int> collection = new Dictionary<string, int>();
            SortedDictionary<int, SortedSet<string>> otherCollection = new SortedDictionary<int, SortedSet<string>>();
            int pointer_X = -1;
            int pointer_y = -1;
            while (number > 0)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    return;

                for (int i = 0; i < input.Length; i++)
                {
                    // if true, increment 'count_x' 
                    if (input[i] == '#')
                        pointer_X = i;

                    // if true accumulate 'count_x' 
                    // to 'tot_count' 
                    if ((input[i] == ' ' || i == input.Length-1) && pointer_X != -1)
                    {
                        pointer_y = i;
                        string subString =
                            input.Substring(pointer_X, pointer_y - pointer_X + 1);
                        subString = subString.TrimEnd();
                        int value = 0;
                        //Collection is string, int
                        //OtherCollection is Int, List<String>
                        if (collection.ContainsKey(subString))
                        {
                            value = collection[subString] + 1; // othercollection : key : 1 : Saurabh // Key 2: Saurabh
                            collection[subString] = value;

                            //Delete from value -1;
                            if (otherCollection.ContainsKey(value - 1))
                            {
                                otherCollection[value-1].Remove(subString);
                            }

                            //This string contains in Other Collection.
                            //OtherCollection : value-1 i will get the hashset and remove xs string.
                            // I will add subString in OtherCollection with value key
                            if (otherCollection.ContainsKey(value))
                            {
                                var collectionOfString = otherCollection[value];
                                collectionOfString.Add(subString);
                            }
                            else
                            {
                                otherCollection.Add(value, new SortedSet<string>() { subString });
                            }
                        }
                        else
                        {
                            value = 1;
                            collection.Add(subString, value);

                            if (otherCollection.ContainsKey(value))
                            {
                                otherCollection[value].Add(subString);
                            }
                            else
                            {
                                otherCollection.Add(value, new SortedSet<string>(){subString});
                            }
                            //This string does not exist in OtherCollection
                        }
                        pointer_X = -1;
                        pointer_y = -1;
                    }
                }
                

                number--;
                pointer_X = -1;
                pointer_y = -1;
            }

            int counter = 5;

            foreach (var pair in otherCollection.OrderByDescending(x =>x.Key))
            {
                if (counter <= 0)
                    break;
                var ss = pair.Value.OrderBy(x => x);
                foreach (string s in ss)
                {
                    if (counter > 0)
                        Console.WriteLine(s);
                    else if (counter <= 0)
                        break;
                    counter--;
                }
            }
        }

        public void TwitterTrends_1()
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {

                if (n >= 1 && n <= 1000)
                {
                    var tweets = new SortedDictionary<string, int>();
                    for (int i = 0; i < n; i++)
                    {
                        var tweet = Console.ReadLine();

                        if (tweet.Length > 140)
                        {
                            tweet = tweet.Substring(0, 139);
                        }

                        var regex = new Regex(@"(?<=#)\w+");
                        var matches = regex.Matches(tweet);

                        foreach (Match m in matches)
                        {
                            if (tweets.ContainsKey(m.Value))
                            {
                                tweets[m.Value] = tweets[m.Value] + 1;
                            }
                            else
                            {
                                tweets.Add(m.Value, 0);
                            }
                        }


                    }
                    GetTopFiveTrendingTweets(tweets);
                }
                else
                {
                    Console.WriteLine("Not supported");
                }
            }

            Console.Read();
        }

        public void GetTopFiveTrendingTweets(IDictionary<string, int> tweets)
        {
            var q = tweets
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key, StringComparer.Ordinal).Take(5).ToList();

            foreach (var x in q)
            {
                Console.WriteLine("#" + x.Key);
            }

        }
    }
}
