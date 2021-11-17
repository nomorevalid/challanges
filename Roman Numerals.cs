     public static int RM(string num)
     {
       Dictionary<char, int> numbers = new Dictionary<char, int>()
       {
         {'I', 1},{'V', 5},{'X', 10},{'L', 50},
         {'C', 100},{'D', 500},{'M', 1000}
       };
       int r = 0, p = 0;
       for (int i = num.Length - 1; i >= 0; i--)
       {
           int t = numbers[num[i]];
           if (t < p) r -= t;
           else r += t;
           p = t;
       }
       return r;  
     }