namespace IcerSystem.FileArrange
{
    using System;
    using System.Collections.Generic;

    internal static class CommonStringExtension
    {
        public static string GetCommonSubstring(string[] array)
        {
            List<KeyValuePair<int, string>> str = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    str.Add(new KeyValuePair<int, string>(i, array[i].Substring(j)));
                }
            }

            str.Sort(FuncCompare);

            string finalString = string.Empty;

            for (int i = 0; i < str.Count - array.Length; i++)
            {
                bool[] flag = new bool[array.Length];
                List<string> continueStrs = new List<string>();
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (!flag[str[i + j].Key])
                    {
                        flag[str[i + j].Key] = true;
                        continueStrs.Add(str[i + j].Value);
                        count++;
                    }
                }

                if (count == array.Length)
                {
                    string result = GetCommonString(continueStrs.ToArray());
                    if (result.Length > finalString.Length)
                    {
                        finalString = result;
                    }
                }
            }

            return finalString;
        }

        private static string GetCommonString(string[] strs)
        {
            int len = int.MaxValue;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < len) len = strs[i].Length;
            }

            for (int i = 0; i < len; i++)
            {
                bool flag = true;
                for (int j = 0; j < strs.Length - 1; j++)
                {
                    if (strs[j][i] != strs[j + 1][i])
                    {
                        flag = false;
                        break;
                    }
                }

                if (!flag) return strs[0].Substring(0, i);
            }

            return strs[0].Substring(0, len);
        }

        private static int FuncCompare(KeyValuePair<int, string> x, KeyValuePair<int, string> y)
        {
            if (x.Value == y.Value) return 0;
            List<string> s = new List<string>();
            s.Add(x.Value);
            s.Add(y.Value);
            s.Sort();
            if (s[0] == x.Value) return -1;
            return 1;
        }
    }
}