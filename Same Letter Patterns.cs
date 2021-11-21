    public static bool SameLetterPattern(string str1, string str2)
       {
            if (str1.Length != str2.Length) return false;
            string pattern1 = "";
            string pattern2 = "";
            for (int i = 1; i < str1.Length-1; i++)
            {
                if (str1[i - 1] == str1[i])
                    pattern1 = pattern1 + "1";
                else
                    pattern1 = pattern1 + "0";
                if (str2[i - 1] == str2[i])
                    pattern2 = pattern2 + "1";
                else
                    pattern2 = pattern2 + "0";
            }
           if (str1.First() == str1.Last())
            {
                pattern1 = pattern1 + "1";
                if (str2.First() == str2.Last())
                    pattern2 = pattern2 + "1";
                return pattern1 == pattern2;
            }
           else return pattern1 == pattern2;
        }