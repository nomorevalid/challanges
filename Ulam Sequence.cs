  public static int Ulam(int n)
  {
      List<int> l = new List<int> { 1, 2 }; int c = 0, s = 3;
      while (l.Count < n)
      {
          for (int j = 0; j < l.Count - 1; j++)
          {
              for (int k = j + 1; k < l.Count; k++)
              {
                  if (l[j] + l[k] == s) c++;
                  if (c > 1) break;
              }
              if (c > 1) break;
          }
          if (c == 1) l.Add(s); s++; c = 0;
      }
      return l[l.Count-1];
  }