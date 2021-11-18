  public static byte[] IntToVlq(long n)
   {
       if (n < 128) return new[] { (byte)n };
       string b = Convert.ToString(n, 2);
       List<byte> l = new List<byte>();
       l.Add(Convert.ToByte("0" + b.Substring(b.Length - 7, 7), 2));
       b = b.Substring(0, b.Length - 7);
       while (b.Length!=0)
       {
           if (b.Length > 6)
           {
               l.Add(Convert.ToByte("1" + b.Substring(b.Length - 7, 7), 2));
               b = b.Substring(0, b.Length - 7);
           }
           else
           {
               l.Add(Convert.ToByte("1" + new string('0', 7 - b.Length) + b.Substring(0), 2)); b = "";
           }
       }
       l.Reverse();
       return l.ToArray();
   }
   public static long VlqToInt(byte[] arr)
   {
       if (arr.Length == 1) return (long)arr[0];
       long l = 0;
       for (int i = 0; i < arr.Length; i++)
       {
           if (i == arr.Length - 1) l += arr[i];
           else l += (arr[i] - 128) * (long)Math.Pow(128, arr.Length - 1 - i);
       }
       return l;
   }