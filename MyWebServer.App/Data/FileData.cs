using MyWebServer.App.Data.Models;
using System.Collections.Generic;
using System.IO;

namespace MyWebServer.App.Data
{
    public class FileData : IData
    {
        public IEnumerable<Cat> Cats
        {
            get
            {
                var cats = File.ReadAllText("cats.txt");

                // parse the text
            }
        }
    }
}
