using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.String
{
    public class RomanToInt
    {
        private int RomanDictionary(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return -1;
        }

        public int ToInt(string romanInteger)
        {
            int toInt = 0;
            for (int indexer = 0; indexer < romanInteger.Length; indexer++)
            {
                int value1 = RomanDictionary(romanInteger[indexer]);

                if (indexer + 1 < romanInteger.Length)
                {
                    int value2 = RomanDictionary(romanInteger[indexer + 1]);

                    if (value1 >= value2)
                    {
                        toInt = toInt + value1;
                    }
                    else
                    {
                        toInt = toInt + (value2 - value1);
                        indexer++;
                    }
                }
                else
                {
                    toInt = toInt + value1;
                    indexer++;
                }
            }

            return toInt;
        }
    }
}
