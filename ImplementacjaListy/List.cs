namespace ImplementacjaListy
{
    class List
    {
        static List<Node> nodeList = new List<Node>();
        Node ?head;
        Node ?rear;

        public void addNext(Node rear)
        {
            nodeList.Add(rear);
            this.rear = rear;
            this.head = nodeList[0];
        }

        public string getName(Node node)
        {
            return node.name;
        }

        public int getId(Node node)
        {
            return node.id;
        }

        public void getPrevious(Node node)
        {
            int index = 0;

            foreach (Node item in nodeList)
            {
                if (item == node)
                {
                    index = nodeList.IndexOf(item) - 1;

                    if (index == -1)
                        System.Console.WriteLine("Węzeł jest pierwszy w liście");
                    else
                        System.Console.WriteLine(nodeList[index].name);
                }
            }
        }

        public void remove(Node node)
        {
            nodeList.Remove(node);
        }

        public int count()
        {
            return nodeList.Count();
        }

        public void display()
        {
            foreach(Node node in nodeList)
            {
                System.Console.WriteLine(node.name);
            }
        }

        public string? toEnd()
        {
            if (rear == null) 
                return null;

            return rear.name;
        }

        public string? toBeggining()
        {
            if (head == null) 
                return null;

            return head.name;
        }
    }
}