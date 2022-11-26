// C# program to illustrate the usage
// of File.GetCreationTime(String) method


using System;
using System.IO;

class GFG {
	static void Main(string[] args)
	{

          DateTime fileCreatedDate = File.GetCreationTime(@"file.txt");
        Console.WriteLine("File created on: " + fileCreatedDate);
	}
}
