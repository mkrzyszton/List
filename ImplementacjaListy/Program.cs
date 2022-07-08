namespace ImplementacjaListy
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            Node item1 = new("i1");
            Node item2 = new("i2");
            Node item3 = new("i3");
            Node item4 = new("i4");
            Node item5 = new("i5");

            list.addNext(item1);
            list.addNext(item2);
            list.addNext(item3);
            list.addNext(item4);
            list.addNext(item5);
            
            list.getPrevious(item2);
            list.getPrevious(item1);
            list.remove(item3);
            list.display();

            System.Console.WriteLine(list.toBeggining());
            System.Console.WriteLine(list.toEnd());
        }
    }
}