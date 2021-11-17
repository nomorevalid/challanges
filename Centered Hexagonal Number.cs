     public static string HexagonalNumbers(int n = 1)
        {
            if (n == 1) return " o ";
            float d = (float)((3 + Math.Sqrt(12 * n - 3)) / 6);
            if (d - (int)d != 0) return "Invalid";
            int start = (int)d;
            int mid = 0;
            for (int i = start; i < start + start; i++)
            {
                if (mid + mid + i == n)
                {
                    mid = i;
                    break;
                }
                mid += i;
            }
            string returnString = "";
            int spaceCount = mid - start + 1;
            Stack<string> stack = new Stack<string>();
            for (int t = start; t <mid; t++)
            {
                returnString += string.Concat(new string(' ', spaceCount), new string('o', t).Aggregate(string.Empty, (x, y) => x + y + ' ').TrimEnd(), new string(' ', spaceCount)) + "\n";
                stack.Push(string.Concat(new string(' ', spaceCount), new string('o', t).Aggregate(string.Empty, (x, y) => x + y + ' ').TrimEnd(), new string(' ', spaceCount)) + "\n");
                spaceCount--;
            }
            returnString += string.Concat(new string(' ', spaceCount), new string('o', mid).Aggregate(string.Empty, (x, y) => x + y + ' ')) + "\n";
            return returnString + string.Concat(stack).Substring(0,string.Concat(stack).Length-1);
        }