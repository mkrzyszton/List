namespace ImplementacjaListy
{
	class Program
	{
		static void Main(string[] args)
		{
			NodeList list = new NodeList();
			list.insertFirst(3);
			list.insertFirst(5);
			list.insertLast(7);
			list.insertLast(9);
			list.insert(6, 1);

			list.display();
			list.deleteFirst();
			list.display();
			list.deleteLast();
			list.display();
			list.delete(1);
			list.display();
		}
	}
}
