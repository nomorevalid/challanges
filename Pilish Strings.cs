        public static string PilishString(string txt)
        {
            int c = 0, d = 0;
            string p = "314159265358979";
            List<string> l = new List<string>();
            for (int i = 0; i < p.Length; i++)
            {
                if (string.Join("", l.ToArray()).Contains(txt)) break;
                if (c + int.Parse(p[i].ToString()) <= txt.Length)
                    l.Add(txt.Substring(c, int.Parse(p[i].ToString())));
                else
                {
                    d = int.Parse(p[i].ToString()) - txt.Substring(c).Length;
                    l.Add(txt.Substring(c) + new string(txt.Substring(c).Last(), d));
                    break;
                }
                c = string.Join("", l.ToArray()).Length;
            }
            return string.Join(" ", l.ToArray());
        }