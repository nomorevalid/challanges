	public static string Smallest(int n)
	{
		BigInteger lcm = 1;
		for(int i=2;i<=n;i++)
			lcm *= i/GCD(lcm,i);
		return lcm.ToString();
	}
  public static BigInteger GCD(BigInteger a, BigInteger b) 
	{
  	while(b > 0) 
		{
      a %= b;
      if (a == 0) return b;
      b %= a;
  	}
  	return a;
	}