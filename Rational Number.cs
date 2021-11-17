    public static string Rational(int a,int b)
    {
			     List<string> checkList = new List<string>();
            StringBuilder repeat = new StringBuilder();
            int multiply10 = (a % b) * 10, time = a / b, rem = a % b;
            string breaker = "";
            repeat.Append(a / b);
            repeat.Append(".");
            while (true)
            {
                if (!checkList.Contains(multiply10.ToString() + b.ToString()) || checkList == null)
                {
                    checkList.Add(multiply10.ToString() + b.ToString());
                    time = multiply10 / b;
                    rem = multiply10 % b;
                    multiply10 = rem * 10;
                    repeat.Append(time);
                }
                else
                {
                    breaker = multiply10.ToString() + b.ToString();
                    break;
                }
            }
            int index = checkList.FindIndex(x => x == breaker);
            string lastString = repeat.ToString().Substring(index + 1);
            if (((decimal)a/(decimal)b).ToString() == repeat.ToString().Substring(0, repeat.Length - 1))
                return repeat.ToString().Substring(0, repeat.Length - 1);
            else
                return repeat.ToString().Substring(0, index + 2) + "(" + repeat.ToString().Substring(index + 2) + ")";
    }