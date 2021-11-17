		public static string LoneliestNumber(int l, int h)
		{
  		int Lp = 0, Hp = 0, n = 0, d = 0, p = 0;
      BitArray array = new BitArray(h + h + 1,true);
      array[0] = false; array[1] = false;
      for (int i = 2; i * i < array.Length; i++)
          if (array[i] == true)
              for (int k = i * i; k < array.Length; k += i)
                  array[k] = false;
      for (int i = l; i <= h; i++)
      {
          for(int k=i;k>=2;k-- )
          {
              if(array[k]==true && k!=i)
              {
                  Lp = k;
                  break;
              }
          }
          for (int k = i; k < array.Length; k++)
          {
              if (array[k] == true && k != i)
              {
                  Hp = k;
                  break;
              }
          }
          Lp = i == 0 ? 2 : Lp;
          if (Math.Abs(i - Lp) > d && Hp - i > d)
          {
              n = i;
              d = Math.Abs(i - Lp) > Hp - i ? Hp - i : Math.Abs(i - Lp);
              p = Math.Abs(i - Lp) == Hp - i ? Hp : Math.Abs(i - Lp) > Hp - i ? Hp : Lp;
          }
      }
      return $"number: {n}, distance: {d}, closest: {p}";
  }	