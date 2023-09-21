using HtmlAgilityPack;
public class websitereader
{
public void readsite(){
    
        string url = "https://www.interrail.eu/en"; 
        // Create a new HtmlWeb instance
        var web = new HtmlWeb();

        // Load the HTML content of the webpage
        var doc = web.Load(url);

        // Use XPath to select the HTML elements that contain the article titles
        var titleNodes = doc.DocumentNode.SelectNodes("//h1");

        if (titleNodes != null)
        {
            foreach (var titleNode in titleNodes)
            {
                Console.WriteLine(titleNode.InnerText);
            }
        }
        else
        {
            Console.WriteLine("No article titles found.");
        }
    }
}    
