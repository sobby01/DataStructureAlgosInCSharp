using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class RemoveOuterParenthesis
    {
        public string Remove(string S)
        {
            StringBuilder builder = new StringBuilder();
            int indexer = 0;
            foreach (var item in S)
            {
                if (item == '(')
                {
                    indexer++;
                }

                if (indexer > 1)
                {
                    builder.Append(item);
                }

                if (item == ')')
                {
                    indexer--;
                }
            }
            return builder.ToString();
        }
    }
}
