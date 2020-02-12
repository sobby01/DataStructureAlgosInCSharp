using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class KeyoardProb
    {
        public int CalculateTime(string keyboard, string word)
        {
            Dictionary<char, int> keyboardCollection = new Dictionary<char, int>();

            for (int indexer = 0; indexer < keyboard.Length; indexer++)
            {
                keyboardCollection.Add(keyboard[indexer], indexer);
            }

            int time = 0; int keyValue = 0;
            int lastKeyPoint = 0;
            for (int i = 0; i < word.Length; i++)
            {
                keyboardCollection.TryGetValue(word[i], out keyValue);
                if (i == 0)
                {
                    time = time + keyValue;
                }
                else
                {
                    int minDistance = Math.Abs(keyValue - lastKeyPoint);
                    time = time + minDistance;
                }

                lastKeyPoint = keyValue;
            }

            return time;
        }
    }
}
