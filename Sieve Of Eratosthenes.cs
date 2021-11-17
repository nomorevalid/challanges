        public static void Eratosthenes(int n)
        {
            BitArray a = new BitArray(n + 1, true);
            for (int i = 2; i * i <= n; i++)
                if (a[i] == true)
                    for (int k = i * i; k <= n; k += i)
                        a[k] = false;
            for (int l = 2; l <= n; l++)
                if (a[l] == true)
                    Console.WriteLine(l);
        }