        public static int Prefix(string exp)
        {
            var e = exp.Split(" ");
            Stack s = new Stack();
            for (int i = e.Length-1; i >=0; i--)
                if ("+-/*".Contains(e[i]))
                    s.Push(Do(e[i], Convert.ToInt32(s.Pop()), Convert.ToInt32(s.Pop())));
                else
                    s.Push(e[i]);
            return Convert.ToInt32(s.Pop());
        }