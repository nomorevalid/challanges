   public static string Bemirp(int n) 
   {
      if (B(n)) return "B";
      else if (E(n)) return "E";
      else if (P(n)) return "P";
      return "C";
   }	
    public static bool P(int n)
    {
      if (n % 2 == 0 || n < 2) return false;
      if (n == 2) return true;
      int d = (int)Math.Floor(Math.Sqrt(n));
      for (int i = 3; i <= d; i += 2)
          if (n % i == 0) return false;
      return true;
    }
    public static bool E(int n) => P(n) && P(int.Parse(new string(n.ToString().Reverse().ToArray()))) && int.Parse(new string(n.ToString().Reverse().ToArray())) != n;
    public static bool B(int n)
    {
        int a = int.Parse(n.ToString().Replace('6', '5').Replace('9', '6').Replace('5', '9'));
        int r = int.Parse(new string(a.ToString().Reverse().ToArray()));
        if (!E(a) || !E(r)) return false;
        return true;
    }