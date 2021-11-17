	public static bool WithinTriangle(int[] p1, int[] p2, int[] p3, int[] test)
	{
    		float n = .5f * (-p2[1] * p3[0] + p1[1] * (-p2[0] + p3[0]) + p1[0] * (p2[1] - p3[1]) + p2[0] * p3[1]);
    		float m = (p1[1] * p3[0] - p1[0] * p3[1] + (p3[1] - p1[1]) * test[0] + (p1[0] - p3[0]) * test[1]) * (n < 0 ? -1 : 1);
   		float r = (p1[0] * p2[1] - p1[1] * p2[0] + (p1[1] - p2[1]) * test[0] + (p2[0] - p1[0]) * test[1]) * (n < 0 ? -1 : 1);
    		return m > 0 && r > 0 && (m + r) < 2 * n * (n < 0 ? -1 : 1);
	}