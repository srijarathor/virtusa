// C# program to illustrate the usage
// of File.SetLastAccessTime() method

// Using System and System.IO namespaces
using System;
using System.IO;

class GFG {
	public static void Main()
	{
		
		string myfile = @"file.txt";

		
		File.SetLastAccessTime(myfile, new DateTime(2020, 5, 4, 4, 5, 7));

		
		DateTime dt = File.GetLastAccessTime(myfile);
		Console.WriteLine("The last access date and"+
				" time for this file was {0}.", dt);
	}
}
