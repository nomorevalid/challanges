      public static bool Centrifuge(int n, int k)
        {
            if (n == 1 || k == 1 || n - k == 1)  return false;
            else if (n == k || (n % 2 == 0 && k % 2 == 0) || k - 2 == n - k) return true;
            else
            {
                int gcd = GCD(n, k);
                if (gcd == n - k)return true;
                else return false;
            }        
        }
        public static int GCD(int a, int b)
        {
            int rem;
            while (b != 0)
            {
                rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }