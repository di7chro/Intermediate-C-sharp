using System.Collections.Generic;
using System.IO;

namespace Excersise3
{
    public class ListLoader
    {
        public List<string> LoadListFromFile(string fileName)
        {
            var list = new List<string>();
            var sr = new StreamReader(fileName);
            var line = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                list.Add(line);
            }

            sr.Close();
            return list;
        }
    }
}