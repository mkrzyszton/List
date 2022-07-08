namespace ImplementacjaListy
{
    class Node
    {
        static int total = 0;
        public int id;
        public string name;
        public Node ?next;

        public Node(string name)
        {
            ++total;
            this.name = name;
            this.id = total;
        }
    }
        
}