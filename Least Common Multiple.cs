  public static int LCM(int[] array) 
  { 
      int returnInt = array[0]; 
      for (int i = 1; i < array.Length; i++) 
          returnInt = (((array[i] * returnInt)) / 
                  (Step(array[i], returnInt))); 
      return returnInt; 
  }
  public static int Step(int num1, int num2) => num2==0? num1:Step(num2,num1%num2);