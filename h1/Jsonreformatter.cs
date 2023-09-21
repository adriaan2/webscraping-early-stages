using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class JsonReformatter
{
    public Dictionary<string, string> ReformatJson(string[] urls)
    {
        Dictionary<string, string> formattedData = new Dictionary<string, string>();

        for (int i = 0; i < urls.Length; i++)
        {
            string key = "Key" + (i + 1); // You can customize the key naming if needed.
            string value = urls[i];
            formattedData.Add(key, value);
        }

        return formattedData;
    }

    public string ConvertToJson(string[] urls)
    {
        Dictionary<string, string> formattedData = ReformatJson(urls);
        string json = JsonConvert.SerializeObject(formattedData, Formatting.Indented);
        return json;
    }
}
