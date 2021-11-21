 public static string OrderPeople(int rows, int columns, int people)
        {
            if (people > rows * columns)return "overcrowded";
            int tempPeople = 0; int[,] multiString = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                if (tempPeople + 1 <= people) tempPeople++;
                else break;
                if (i % 2 == 0)
                {
                    multiString[i, 0] = tempPeople;
                    for (int k = 1; k < columns; k++)
                    {
                        if (tempPeople + 1 <= people)
                        {
                            tempPeople++;
                            multiString[i, k] = tempPeople;
                        }else break;
                    }
                }
                else
                {
                    multiString[i, columns - 1] = tempPeople;
                    for (int k = columns - 2; k >= 0; k--)
                    {
                        if (tempPeople + 1 <= people)
                        {
                            tempPeople++;
                            multiString[i, k] = tempPeople;
                        }else break;
                    }
                }
            }
            string returnString = "";
            for(int i=0;i<multiString.GetLength(0);i++)
            {
                for (int k = 0; k < multiString.GetLength(1); k++)
                {
                    if (k == multiString.GetLength(1) - 1)
                        returnString += multiString[i, k].ToString();
                    else returnString += multiString[i, k] + ", ";
                }
								if(i!= multiString.GetLength(0) - 1)
                	returnString += "\n";
            }
          	return  returnString;
        }