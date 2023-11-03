using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string inputFile = "Target.conf"; // Replace with the path to your input file
        string outputFile = "result.txt"; // Replace with the desired output file

        try
        {
            string[] base64Strings = File.ReadAllLines(inputFile);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (string base64Text in base64Strings)
                {
                    byte[] data = Convert.FromBase64String(base64Text);
                    string decodedText = Encoding.UTF8.GetString(data);

                    writer.WriteLine(decodedText);
                }
            }

            Console.WriteLine("Decoded strings saved to " + outputFile);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
