  public static string ExpressFactors(int n) 
	{
		 int a, b;
     string s = "";
     for (a = 2; n > 1; a++)
     {
         if (n % a == 0)
         {
             b = 0;
             while (n % a == 0)
             {
                 n /= a;
                 b++;
             }
             s += b > 1 ? s.Length > 0 ? " x " + a + "^" + b : a + "^" + b : s.Length > 0 ? " x " + a : a.ToString();
         }
     }
     return s;
	}