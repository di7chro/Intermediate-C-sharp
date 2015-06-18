using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercise3
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
