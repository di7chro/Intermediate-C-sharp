
using System.Collections.Generic;
using System.IO;

namespace Exercise4
{
    class ListLoader {

        public List<LanguageData> LoadListFromFile(string fileName)
        {
            var list = new List<LanguageData>();
            var sr = new StreamReader(fileName);
            var line = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                LanguageData OneLineOfData = new LanguageData();
                string [] temp = line.Split('\t');
                OneLineOfData.Name = temp[0];
                OneLineOfData.Year = int.Parse(temp[1]);
                OneLineOfData.Description = temp[2];

                list.Add(OneLineOfData);
            }

            sr.Close();
            return list;
        }
    }
}

