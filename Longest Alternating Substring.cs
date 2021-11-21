		public static string LongestSubstring(string digits)
		{
			List<string> l = new List<string>();
      int s = -1, e = -1;
      bool control = false;
      for (int i = 0; i < digits.Length-1; i++)
      {
          if (!control)
          {
              if (int.Parse(digits[i].ToString()) % 2 != int.Parse(digits[i + 1].ToString()) % 2)
              {
                  s = i;
                  control = true;
              }
          }
          else
          {
              if (int.Parse(digits[i].ToString()) % 2 == int.Parse(digits[i + 1].ToString()) % 2)
              {
                  e = i;
                  control = false;
              }
          }
          if (s != -1 && e != -1)
          {
              l.Add(digits.Substring(s, e - s+1));
              s =- 1;
              e = -1;
          }
				  else if (s != -1 && e == -1 && i + 1 == digits.Length-1)
           	  l.Add(digits.Substring(s, digits.Length - s ));
      }
      return l.Aggregate(string.Empty, (x, y) => y.Length > x.Length ? y : x);
		}