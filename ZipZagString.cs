using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class ZipZagString
    {
        public string Convert(string s, int numRows)
        {
            var rowToIndexMapping = new Dictionary<int, List<int>>(numRows);

            for (int i = 1; i <= numRows; ++i)
            {
                rowToIndexMapping.Add(i, new List<int>(s.Length/numRows));
            }

            int row = 1;
            bool goingDown = true;
            for (int i = 0; i < s.Length; ++i)
            {
                rowToIndexMapping[row].Add(i);

                if (goingDown)
                {
                    if (row < numRows)
                    {
                        row++;
                    }
                    else
                    {
                        goingDown = false;
                        row = (row < 1) ? 1 : row - 1;
                    }
                }
                else
                {
                    if (row > 1)
                    {
                        row--;
                    }
                    else
                    {
                        goingDown = true;
                        row = (row > numRows) ? numRows : row - 1;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <= numRows; ++i)
            {
                var indices = rowToIndexMapping[i];

                foreach (var item in indices)
                {
                    sb.Append(s[item]);
                }
            }

            return sb.ToString();
        }
    }
}
