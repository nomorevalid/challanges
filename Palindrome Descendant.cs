        public static bool PalindromeDescendant(int num)
        {
            if (IsPalindrome(num)) return true;
            int len = num.ToString().Length;
            string str = "";
            while (len >=4 )
            {
                int[] array;
                if (len == num.ToString().Length)
                {
                    array = num.ToString().Select(x => int.Parse(x.ToString())).ToArray();
                    len /= 2;
                }
                else
                {
                    array = null;
                    array = str.Select(x => int.Parse(x.ToString())).ToArray();
                    str = "";
                    len /= 2;
                }
                for (int i = 0; i < array.Length; i += 2)
                    str += (array[i] + array[i + 1]).ToString();
                if (IsPalindrome(int.Parse(str))) return true;
            }
            return false;
        }
        public static bool IsPalindrome(int num)
        {
            int remainder, sum = 0, temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                sum = (sum * 10) + remainder;
                num = num / 10;
            }
            if (temp == sum)
                return true;
            return false;
        }