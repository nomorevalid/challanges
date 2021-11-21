    public static bool ValidatePassword(string str)
        {
            int total = 0;
            if (str.Length > 5 && str.Length < 25)
            {
                char[] charArray = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=', '_', '-', '{', '}', '[', ']', ':', ';', '”', '\'', '?', '<', '>', ',', '.' };
                for (int i = 1; i < str.Length; i++)
                {
                    if (charArray.Any(x => x == str[i]) && str.Any(x => char.IsLower(x)) && str.Any(x => char.IsUpper(x)) && str.Any(x => char.IsNumber(x)))
                    {
                        total++;
                        break;
                    }
                    else if (Regex.IsMatch(str, @"(.)\1\1") || str.Contains("è"))
                        return false;
                }
            }
            return total == 1;
        }