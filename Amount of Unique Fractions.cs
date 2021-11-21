    public static double UniqueFract()
    {
      List<double> list = new List<double>();
      double t;
      for (int i = 1; i <= 9; i++)
          for (int k = 0; k <= i; k++)
          {
              t = (double)k / (double)i;
              if (!list.Contains(t) && t != 1.0)
                  list.Add(t);
          }
      return list.Sum();
    }