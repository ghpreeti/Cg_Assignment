using System;
using System.Collections.Generic;
using System.Text;



namespace AssignmentPrac
{
    public class KeyValueStore
    {
        public static int[] Process(string[] commands)
        {
            var dict = new Dictionary<string, int>();
            var results = new List<int>();

            foreach (string cmd in commands)
            {
                var parts = cmd.Split(' ');
                string key = parts[1];

                if (parts[0] == "SET")
                    dict[key] = int.Parse(parts[2]);
                else if (parts[0] == "ADD")
                    dict[key] = dict.ContainsKey(key) ? dict[key] + int.Parse(parts[2]) : int.Parse(parts[2]);
                else if (parts[0] == "GET")
                    results.Add(dict.ContainsKey(key) ? dict[key] : 0);
            }
            return results.ToArray();
        }
    }
}
