using System.Collections.Generic;
using System.IO;

namespace Exercise10
{
    /// <summary>
    /// A simple helper class
    /// </summary>
    public class ListLoader
    {
        public static List<ProgrammingLanguage> LoadLanguages()
        {
            var sr = new StreamReader("languageData.txt");
            var line = string.Empty;
            var results = new List<ProgrammingLanguage>();

            while ((line = sr.ReadLine()) != null)
            {
                var data = line.Split('\t');

                // Wrong amount of fields on this row. Something is wrong with it. Skip it
                if (data.Length != 3)
                    continue;

                var lang = CreateLanguageFromArray(data);

                if (lang != null)
                    results.Add(lang);
            }

            return results;
        }

        /// <summary>
        /// Pre:  Array length == 3 and 
        /// Post:
        /// </summary>
        /// <param name="array">The array to parse</param>
        /// <returns>A new ProgrammingLanguage object or null if parsing failed</returns>
        private static ProgrammingLanguage CreateLanguageFromArray(string[] array)
        {
            int year;

            if (!int.TryParse(array[1], out year))
                return null;

            return new ProgrammingLanguage
                           {
                               Name = array[0],
                               ReleaseYear = year,
                               Description = array[2]
                           };
        }
    }
}