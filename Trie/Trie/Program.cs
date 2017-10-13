using System;

namespace Trie
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Trie t = new Trie();
            Console.WriteLine(string.Format("t.search(fubar): {0}", t.Search("fubar")));
			Console.WriteLine(string.Format("t.StartsWith(fubar): {0}", t.StartsWith("fubar")));
			Console.WriteLine(string.Format("t.Insert(a)"));
            t.Insert("a");
			Console.WriteLine(string.Format("t.search(a): {0}", t.Search("a")));
			Console.WriteLine(string.Format("t.StartsWith(a): {0}", t.StartsWith("a")));
			Console.WriteLine(string.Format("t.StartsWith(fub): {0}", t.StartsWith("fub")));

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
		}
    }
}
