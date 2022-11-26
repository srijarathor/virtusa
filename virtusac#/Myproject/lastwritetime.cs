using System;  
using System.IO;  
  
namespace GetSetFileLastWriteTimeSample  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            try  
            {  
                string filename = @"c:\Temp\CSharpCorner.txt";  
                if (!File.Exists(filename))  
                {  
                    File.Create(filename);  
                }  
                else  
                {  
                    // Set LastWriteTime   
                    File.SetLastWriteTime(filename, new DateTime(2000, 1, 1));  
                }  
  
                // Get time  
                DateTime dt = File.GetLastWriteTime(filename);  
                Console.WriteLine("The last write time for this file was {0}.", dt);  
  
                // Set last write time  
                File.SetLastWriteTime(filename, DateTime.Now);  
  
            }  
            catch (Exception e)  
            {  
                Console.WriteLine("The process failed: {0}", e.ToString());  
            }  
  
            Console.ReadKey();  
        }  
    }  
}  