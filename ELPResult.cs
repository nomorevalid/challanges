        public static string EPLResult(string[] table, string team)
        {
            List<Tuple<string,int,int>> l = new List<Tuple<string, int, int>>();
            string[] a;
            for (int i = 0; i < table.Length; i++)
            {
                a = table[i].Split(",");
                l.Add(Tuple.Create(a[0], int.Parse(a[2]) * 3 + int.Parse(a[3]), int.Parse(a[5])));
            }
            l = l.OrderByDescending(x => x.Item2).ThenByDescending(x => x.Item3).ToList();
            int k = l.FindIndex(x => x.Item1 == team);
            string t = k > 3 ? "th" : k == 3 ? "rd" : k == 2 ? "nd" : "st";
            return $"{l.ElementAt(k).Item1} came {k+1+t} with {l.ElementAt(k).Item2} points and a goal difference of {l.ElementAt(k).Item3}!";
        }