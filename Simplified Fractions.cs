public static string Simplify(string str)
        {
            string[] array = str.Split('/').ToArray();
            int[] meList = new int[] { int.Parse(array[0]), int.Parse(array[1]) };
            int N1 = meList[0], N2 = meList[1], divide = 2, bdivide=1;
            while (N1 > 1 || N2 > 1)
            {
                if (N1 % divide == 0 && N2 % divide == 0)
                {
                    bdivide *= divide;
                    N1 /= divide;
                    N2 /= divide;
                }
                else if (N1 % divide == 0)
                    N1 /= divide;
                else if (N2 % divide == 0)
                    N2 /= divide;
                else divide++;
            }
            bool control = meList[0] > meList[1] ? true : false;
            if (control && meList[0] % meList[1] == 0)
                return (meList[0] / meList[1]).ToString();

            return (meList[0] / bdivide).ToString() + "/"+(meList[1] / bdivide).ToString();
        }