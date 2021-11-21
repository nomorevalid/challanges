public class Node<T> where T : IComparable
{
    public T Data;
    public Node<T> Left;
    public Node<T> Right;
    public Node(T data)
    {
        Data = data;
    }
    public void Insert(T data)
    {
			if(data.CompareTo(Data) < 0)
       {
           if(Left != null)
               Left.Insert(data);
           else
               Left = new Node<T>(data);
       }
       else
       {
           if (Right != null)
               Right.Insert(data);
           else 
               Right = new Node<T>(data);
       }
    }
    public IEnumerable<T> GetTreeData()
    {
				List<T> list = new List<T>();
				if(Left!=null)
        	foreach (var item in Left.GetTreeData().ToList())
            	list.Add(item);
				list.Add(Data);
				if(Right!=null)
       	  foreach (var item in Right.GetTreeData().ToList())
            	list.Add(item);
        return list;
    }
}