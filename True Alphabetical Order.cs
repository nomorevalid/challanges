    public static string TrueAlphabetic(string str)
    {
	    var a = str.Replace(" ", "").ToCharArray();
      Array.Sort(a);
      string s = new string(a);
      for (int i = 0; i < str.Length; i++)
          if (str[i] == ' ')
              s=s.Insert(i, " ");
      return s;
    }