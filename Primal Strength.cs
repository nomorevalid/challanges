		public static string PrimalStrength(int n)
		{
		  BitArray prime = new BitArray(n*2, true);
      int b = 0, a = 0;
      for (int i = 2; i * i <= n*2-1; i++)
          if (prime[i] == true)
              for (int j = i * i; j <= n*2-1; j += i)
                  prime[j] = false;
      for (int i = n+1, j = n-1; i < n * 2; i++, j--)
      {
          if (b != 0 && a != 0) break;
          if (prime[i] == true && a==0) a = i;
          if (prime[j] == true && b==0) b = j;
      }
      if (n - b == a - n) return "Balanced";
      else if (a - n < n - b) return "Strong";
      return "Weak";
		}