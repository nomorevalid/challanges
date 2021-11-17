	public static long[] MaxMin(long n)
  {
      int maxC = 0, maxT = 0, minC = 0, minT = 0, minNum = 9, maxNum = 0;
      string s = n.ToString();
      bool control1 = false, control2 = false;
      for (int i = 0; i < s.Length - 1; i++)
      {
          if (minNum < 9) control1 = true;
          if (maxNum > 0) control2 = true;
          if (control1 && control2) break;
          for (int k = i + 1; k < s.Length; k++)
          {
              if (i == k) continue;
              if ((int)s[k] - '0' < (int)s[i] - '0' && (int)s[k] - '0' <= minNum)
              {
                  if (i == 0 && (int)s[k] - '0' == 0 ) { }
                  else
                  {
                      if (!control1)
                      {
                          minC = i;
                          minT = k;
                          minNum = (int)s[k] - '0';
                      }
                  }
              }
              if ((int)s[k] - '0' > (int)s[i] - '0' && (int)s[k] - '0' >= maxNum)
              {
                  if (!control2)
                  {
                      maxC = i;
                      maxT = k;
                      maxNum = (int)s[k] - '0';
                  }
              }
          }
      }
      return new long[] { long.Parse(Swap(n.ToString(), maxC, maxT)), long.Parse(Swap(n.ToString(), minC, minT)) };
  }
  public static string Swap(string str, int pos1, int pos2)
  {
      char[] ar = str.ToCharArray();
      char temp = ar[pos1];
      ar[pos1] = ar[pos2];
      ar[pos2] = temp;
      return new string(ar);
  }