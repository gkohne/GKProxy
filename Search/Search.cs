using System;
using System.Collections.Generic;

namespace Search
{
    public static class Search
    {
        /// <summary>
        /// Find search text in raw output
        /// </summary>
        /// <param name="str">Raw output</param>
        /// <param name="value">Search string</param>
        /// <returns></returns>
        public static List<string> Find(string str, string value)
        {
            List<string> returntext = new List<string>();

            foreach (int index in AllIndexesOf(str, value))
            {
                returntext.Add(SurroundingText(index, value, str));
            }

            return returntext;
        }

        public static void ShowSearchForm(string raw, string searchtext)
        {
            List<string> returntext = Find(raw, searchtext);
            FormSearch form = new FormSearch();
            form.listBoxSearch.DataSource = returntext;
            form.labelCountvalue.Text = returntext.Count.ToString();
            form.Show();
        }
        private static List<int> AllIndexesOf(string str, string value)
        {
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index, StringComparison.Ordinal);
                if (index == -1)
                {
                    return indexes;
                }

                indexes.Add(index);
            }
        }

        private static string SurroundingText(int index, string text, string str)
        {
            // need to make dynamic 
            int length = text.Length + 10;

            string surroundingText = str.Substring(index, length);

            return surroundingText;
        }


    }
}
