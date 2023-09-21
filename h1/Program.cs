using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Provide the correct file path to your JSON file
            string filePath = "Linklist.json";

            // Read the JSON content from the file using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string jsonString = reader.ReadToEnd();
                Console.WriteLine(jsonString);

                // Deserialize the JSON data into a C# object (string in this case)
                string fromJson = JsonConvert.DeserializeObject<string>(jsonString);
                char[] chars={',',' '};
                string [] strings=fromJson.Split(chars);
                
JsonReformatter jsonReformatter=new();
System.Console.WriteLine(jsonReformatter.ReformatJson(strings));
            
           

                // Now, you can work with the deserialized data
     //           Console.WriteLine("Deserialized JSON data:"+fromJson);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

// using System;
// using System.Diagnostics;

// class Program
// {
//     static void Main(string[] args)
//     {
 //         string batchFilePath = @"nosair.bat";

//         try
//         {
//             Process.Start(batchFilePath);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("An error occurred: " + ex.Message);
//         }
//     }
// }
