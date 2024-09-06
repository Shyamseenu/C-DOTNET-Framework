using System;
using System.IO;

namespace FileReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Specify the file path
                string filePath = "myFile.txt";

                // Create or overwrite the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Hello, world!");
                    writer.WriteLine("This is some content written to the file.");
                }

                Console.WriteLine($"File '{filePath}' created and content written successfully.");

                // Read the file content
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string fileContent = reader.ReadToEnd();
                    Console.WriteLine($"File content:\n{fileContent}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}