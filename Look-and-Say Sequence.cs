   public static IEnumerable<long> LookAndSay(long start, int n)
   {
       string s = start.ToString();
       var l = new List<long>(){start};
       for (int i = 0; i < n-1; i++)
       {
           s = LaS(s);
           l.Add(long.Parse(s));
       }
       return l;
   }
   public static string LaS(string str)
   {
       StringBuilder s = new StringBuilder();
       string t = str.ToString();
       int c = 0;
       char ch = t[0];
       for (int i = 0; i < t.Length; i++)
       {
           if (ch == t[i])
               c++;
           else
           {
               s.Append(c.ToString() + ch);
               ch = t[i];
               c = 1;
           }
       }
       s.Append(c.ToString() + ch);
       return s.ToString();
   }
}