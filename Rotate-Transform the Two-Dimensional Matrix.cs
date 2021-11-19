  public static int[,] RotateTransform(int[,] arr, int num)
  {
      int l = arr.GetLength(0), c = Math.Abs(num);
      int[,] r = new int[l, l], t = arr;
      while (c > 0)
      {
          for (int i = 0; i < l; ++i)
              for (int j = 0; j < l; ++j)
              {
                  if(num>0) r[i, j] = t[l - j - 1, i];
                  else r[i, j] = t[j, l - i - 1];
              }
          c--;
          t = (int[,])r.Clone();
      }
      return r;
  }