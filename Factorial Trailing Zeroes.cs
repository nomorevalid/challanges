  	public static int TrailingZeroes(int n) 
	  {
		   int p = 1;
       int t = 0;
       while (Math.Pow(5, p) < n)
       {
           t += n / (int)Math.Pow(5, p);
           p++;
       }
       return t;
	  }